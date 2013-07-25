<%@ Page Language="C#" AutoEventWireup="true"%>
Your file download will start in a moment. Please wait...
<iframe width="1" height="1" src='save_file.aspx?id=<%= Request["id"] %>' onload="window.close();"></iframe>
<script>setTimeout("window.close();", 1000);</script>