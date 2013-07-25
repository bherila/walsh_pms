<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="browse_list.ascx.cs" Inherits="WalshPM_v2.browse_list" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3, Version=8.3.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v8.3, Version=8.3.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<dxwgv:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" Width="100%">
	<Columns>
		<dxwgv:GridViewCommandColumn VisibleIndex="0">
		</dxwgv:GridViewCommandColumn>
		<dxwgv:GridViewDataHyperLinkColumn FieldName="Link" VisibleIndex="1">
			<PropertiesHyperLinkEdit TextField="Name" Target="mainFrame">
			</PropertiesHyperLinkEdit>
		</dxwgv:GridViewDataHyperLinkColumn>
		<dxwgv:GridViewDataHyperLinkColumn FieldName="Preview_Link" VisibleIndex="2">
			<PropertiesHyperLinkEdit Text="Preview" Target="mainFrame">
			</PropertiesHyperLinkEdit>
		</dxwgv:GridViewDataHyperLinkColumn>
		<dxwgv:GridViewDataTextColumn FieldName="Size" VisibleIndex="2" Width="100px">
		</dxwgv:GridViewDataTextColumn>
		<dxwgv:GridViewDataDateColumn FieldName="LastModified" VisibleIndex="3" Width="100px">
		</dxwgv:GridViewDataDateColumn>
		<dxwgv:GridViewDataTextColumn FieldName="Type" VisibleIndex="4" Width="100px">
		</dxwgv:GridViewDataTextColumn>
	</Columns>
	<SettingsPager Mode="ShowAllRecords">
	</SettingsPager>
</dxwgv:ASPxGridView>
