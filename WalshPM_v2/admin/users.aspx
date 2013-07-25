<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeBehind="users.aspx.cs" Inherits="WalshPM_v2.admin.users" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3, Version=8.3.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v8.3, Version=8.3.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register assembly="DevExpress.Xpo.v8.3, Version=8.3.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Xpo" tagprefix="dxxpo" %>
<script runat="server">

</script>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
	<dxwgv:ASPxGridView ID="grid" runat="server" AutoGenerateColumns="False" DataSourceID="ds" KeyFieldName="Oid" Width="441px">
		<Columns>
			<dxwgv:GridViewCommandColumn VisibleIndex="0" Width="100px">
				<EditButton Visible="True">
				</EditButton>
				<NewButton Visible="True">
				</NewButton>
				<DeleteButton Visible="True">
				</DeleteButton>
				<ClearFilterButton Visible="True">
				</ClearFilterButton>
			</dxwgv:GridViewCommandColumn>
			<dxwgv:GridViewDataTextColumn FieldName="Oid" ReadOnly="True" Visible="False" VisibleIndex="1" Width="100px">
			</dxwgv:GridViewDataTextColumn>
			<dxwgv:GridViewDataTextColumn FieldName="Username" SortIndex="0" SortOrder="Ascending" VisibleIndex="1" Width="100px">
			</dxwgv:GridViewDataTextColumn>
			<dxwgv:GridViewDataTextColumn FieldName="Name" VisibleIndex="2">
			</dxwgv:GridViewDataTextColumn>
			<dxwgv:GridViewDataCheckColumn FieldName="IsAdmin" VisibleIndex="3" Width="70px">
			</dxwgv:GridViewDataCheckColumn>
		</Columns>
		<SettingsPager PageSize="20">
		</SettingsPager>
		<Settings ShowFilterRow="True" />
</dxwgv:ASPxGridView>
<dxxpo:XpoDataSource ID="ds" runat="server" TypeName="WalshPM_v2.code.data.PMUser">
</dxxpo:XpoDataSource>
</asp:Content>
