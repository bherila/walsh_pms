<%@ Page Title="" Language="C#" MasterPageFile="~/template.master" AutoEventWireup="true" CodeBehind="browse.aspx.cs" Inherits="WalshPM_v2.Browse" %>
<%@ Register assembly="DevExpress.Web.ASPxTreeList.v8.3, Version=8.3.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxTreeList" tagprefix="dxwtl" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v8.3, Version=8.3.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register src="browse_list.ascx" tagname="browse_list" tagprefix="uc1" %>
<%@ Register assembly="WalshPM_v2" namespace="WalshPM_v2.code" tagprefix="cc1" %>
<%@ Register assembly="WalshPM_v2" namespace="WalshPM_v2" tagprefix="cc2" %>
<%@ Register assembly="obout_Splitter2_Net" namespace="OboutInc.Splitter2" tagprefix="obspl" %>
<%@ Register assembly="DevExpress.Web.v8.3, Version=8.3.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPopupControl" tagprefix="dxpc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
	
	
	
	
	<obspl:Splitter ID="Splitter1" runat="server">
		<leftpanel>
			<content>
				<cc2:browse_dir_tree ID="browse_dir_tree1" runat="server" ondirchanged="browse_dir_tree1_DirChanged" />
			</content>
		</leftpanel>
		<rightpanel>
			<content>
				<uc1:browse_list ID="browse_list1" runat="server" />
			</content>
		</rightpanel>
	</obspl:Splitter>
	
</asp:Content>
