DELIMITER $$

DROP FUNCTION IF EXISTS `walshco`.`pmCanSeeObject` $$
CREATE DEFINER=`bherila`@`%.optonline.net` FUNCTION `pmCanSeeObject`(objectId int unsigned, authToken varchar(75)) RETURNS int(11)
BEGIN
  DECLARE current_id int;
  DECLARE view_permission varchar(75);
  DECLARE view_count int;
  DECLARE userid int;
  DECLARE ANTILOCK int;
  DECLARE expiry datetime;
  DECLARE retval int;
  DECLARE tmpcnt int;

  SET ANTILOCK = 100;

  SELECT user_id into userid FROM pm_auth where auth_token = authToken limit 1;
  if (userid < 1 or userid is null) then
    return 0;
  end if;

  SELECT DATE_SUB(NOW(), INTERVAL 60 SECOND) INTO expiry;
  DELETE from pm_security WHERE mc_cache = 'true' and mc_created < expiry;
  SET view_permission = null;
  SELECT ax_view_info INTO view_permission FROM pm_security WHERE accessor_id = userid and mc_cache = 'true' and object_id = objectId limit 1;


  IF (view_permission = 'allow') THEN
    return 1;
  ELSEIF (view_permission = 'deny') THEN
    return 0;
  END IF;

  SET current_id = objectId;
  WHILE (ANTILOCK > 0 AND current_id >= 0) DO
    SET ANTILOCK = ANTILOCK - 1;
    SELECT count(ax_view_info) into tmpcnt from pm_security where object_id = current_id and accessor_id = userid and accessor_type = 'User' limit 1;
    IF (tmpcnt > 0) THEN
      SELECT ax_view_info INTO view_permission FROM pm_security WHERE object_id = current_id and accessor_id = userid and accessor_type = 'User' limit 1;
      IF (view_permission = 'deny' or current_id = 0) THEN
        SET ANTILOCK = 0;
      END IF;
    END IF;
    SELECT parent_object_id INTO current_id FROM pm_objects WHERE object_id = current_id limit 1;
  END WHILE;


  if (view_permission is null) THEN return 99; END IF;
  if (view_permission = 'allow') THEN
    SET retval = 1;
  else
    SET retval = 0;
  end if;

  INSERT INTO pm_security (object_id, accessor_id, accessor_type, ax_view_info, mc_cache, mc_created) VALUES (objectId,userid,'User',view_permission,'true',NOW() );

  return retval;

END $$

DELIMITER ;