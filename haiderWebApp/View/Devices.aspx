<%@ Page Title="Devices" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Devices.aspx.cs" Inherits="haiderWebApp.Devices" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


	<div class="row">
		<div class="col-xs-10">
			<h3>My Smart Devices</h3>
		</div>
	</div>

	<div class="list-group">

		<ul class="breadcrumb">
			<li><a href="/View/Rooms.aspx">Home</a></li>
			<li class="active">
				<asp:Label ID="lblRoomName" runat="server"></asp:Label></li>
		</ul>




		<asp:GridView ID="gvDevices" runat="server" AutoGenerateColumns="False" Width="98%"
			CellPadding="4"
			OnRowCommand="gvDevices_RowCommand">

			<AlternatingRowStyle BackColor="White" ForeColor="#284775" />

			<Columns>

				<asp:TemplateField HeaderText="" ItemStyle-Width="3%" ItemStyle-HorizontalAlign="Center">
					<ItemTemplate>
						<asp:Button ID="btnAcknowledge" CausesValidation="false" runat="server" Text='<%# Eval("State").ToString()=="True"?"OFF":"ON" %>'
							CommandName="OP"
							CommandArgument='<%# Eval("ID").ToString() %>' />
					</ItemTemplate>
				</asp:TemplateField>


				<asp:TemplateField HeaderText="Generated Date" ItemStyle-Width="15%" ItemStyle-HorizontalAlign="Left">
					<ItemTemplate>
						<asp:Label ID="lblName" runat="server" Text='<%# Eval("Name").ToString()%>'>
						</asp:Label>
						<%--<asp:HiddenField ID="lblAlarmID" runat="server" Value='<%# Eval("AlaramID").ToString() %>' />--%>
					</ItemTemplate>
				</asp:TemplateField>

			</Columns>
			<EditRowStyle BackColor="#999999" />
			<FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
			<HeaderStyle BackColor="White" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" />
			<PagerStyle ForeColor="Black" HorizontalAlign="Center" Font-Size="Medium" />
			<RowStyle BackColor="#F7F6F3" ForeColor="#333333" Height="30px" />
			<SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
			<SortedAscendingCellStyle BackColor="#E9E7E2" />
			<SortedAscendingHeaderStyle BackColor="#506C8C" />
			<SortedDescendingCellStyle BackColor="#FFFDF8" />
			<SortedDescendingHeaderStyle BackColor="#6F8DAE" />
		</asp:GridView>

	</div>


</asp:Content>
