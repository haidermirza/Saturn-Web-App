<%@ Page Title="Devices" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Devices.aspx.cs" Inherits="haiderWebApp.Devices" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


	<div class="row">

		<div class="col-xs-2">
			<a href="Rooms.aspx" class="btn btn-primary btn-sm"> < Back </a>
		</div>

		<div class="col-xs-10">
			<h2>My Smart Devices</h2>
		</div>

	</div>




	<asp:GridView AutoGenerateColumns="false" ID="gvDevices" runat="server" AllowSorting="True" Width="100%" OnSelectedIndexChanged="gvDevices_SelectedIndexChanged">
		<Columns>

			<asp:TemplateField ItemStyle-HorizontalAlign="Center">

				<ItemTemplate>

					<div class="col-xs-8">
						<a href="#" class="btn btn-primary btn-block">
							<asp:Label ID="lblName" runat="server" Text='<% #Eval("Name") %>'></asp:Label>
						</a>
					</div>

					<div class="col-xs-4">

						<input id="checkID" type="checkbox" data-toggle="toggle" data-style="slow" runat="server" data-onstyle="success" data-offstyle="danger">
						<p></p>
					</div>

					<%--					<div class="col-xs-4">
							<label>
							</label>
					</div>--%>
				</ItemTemplate>

				<ItemStyle HorizontalAlign="Center"></ItemStyle>

			</asp:TemplateField>

		</Columns>
	</asp:GridView>







	<%--

	

	<div class="row">

		<div class="col-xs-8">
			<a href="#" class="btn btn-primary btn-block">Light</a>
		</div>

		<div class="col-xs-4">
			<input type="checkbox" checked data-toggle="toggle" data-style="slow">
		</div>

	</div>

	<div class="row">

		<div class="col-xs-8">
			<a href="#" class="btn btn-primary btn-block">Fan</a>
		</div>

		<div class="col-xs-4">
			<input type="checkbox" checked data-toggle="toggle" data-style="slow">
		</div>

	</div>

	<div class="row">

		<div class="col-xs-8">
			<a href="#" class="btn btn-primary btn-block">Table Lamp</a>
		</div>

		<div class="col-xs-4">
			<input type="checkbox" checked data-toggle="toggle" data-style="slow">
		</div>


	</div>--%>
</asp:Content>
