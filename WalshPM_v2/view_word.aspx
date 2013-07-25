<%@ Page Title="" Language="C#" MasterPageFile="~/template.master" AutoEventWireup="true" CodeBehind="view_word.aspx.cs" Inherits="WalshPM_v2.view_word" %>
<%@ Register assembly="obout_Splitter2_Net" namespace="OboutInc.Splitter2" tagprefix="obspl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
<h1><asp:Literal runat="server" ID="title" /></h1>

	<obspl:Splitter ID="Splitter1" runat="server">
		<leftpanel WidthDefault="200">
			<content>
				Info
			</content>
		</leftpanel>
		<rightpanel>
			<content>
				<div style="width: 100%; height: 100%; overflow: auto;">
				<asp:Literal EnableViewState="false" runat="server" ID="litHtml"/>
				</div>
			</content>
		</rightpanel>
	</obspl:Splitter>

</asp:Content>
