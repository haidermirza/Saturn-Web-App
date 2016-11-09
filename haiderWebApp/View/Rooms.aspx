<%@ Page Title="Rooms" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Rooms.aspx.cs" Inherits="haiderWebApp.Rooms" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

	<h3>Haider's Smart Home</h3>


	<ul class="breadcrumb">
		<li class="active">Home</li>
	</ul>

	<asp:GridView AutoGenerateColumns="false" ID="gvRooms" runat="server" AllowSorting="True" Width="100%" OnRowCommand="gvRooms_RowCommand">
		<Columns>

			<asp:TemplateField ItemStyle-HorizontalAlign="Center">

				<ItemTemplate>


					<div class="col-xs-8">

						<asp:LinkButton ID="lnkEdit" runat="server" CommandName="GetDevices"
							CommandArgument='<%# Bind("ID") %>' Text='<%# Bind("Name") %>' CausesValidation="false" class="btn btn-default btn-block" />
					</div>



				</ItemTemplate>

			</asp:TemplateField>

		</Columns>
	</asp:GridView>




</asp:Content>
