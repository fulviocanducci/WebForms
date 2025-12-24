<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Grid.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <asp:UpdatePanel ID="UpdatePanel1" runat="server">
      <ContentTemplate>
         <div>
            <div class="row">
               <div class="col-md-10 mb-2">
                  <asp:TextBox ID="TxtName" runat="server" CssClass="form-control form-control-sm" CausesValidation="True"></asp:TextBox>
               </div>
               <div class="col-md-2 mb-2">
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="text-danger" Display="Dynamic" ErrorMessage="*" ControlToValidate="TxtName" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
               </div>
               <div class="col-md-12 mb-2">
                  <asp:Button ID="BtnAdd" runat="server" Text="Adicionar" OnClick="BtnAdd_Click" CssClass="btn btn-sm btn-primary" />
               </div>
            </div>
         </div>
         <asp:GridView ID="GridViewPeople" runat="server"
            AutoGenerateColumns="False"
            AllowPaging="True"
            AllowCustomPaging="true"
            Width="500px"
            CellPadding="4"
            ForeColor="#333333"
            EnableViewState="true"
            OnPageIndexChanging="GridViewPeople_PageIndexChanging"
            GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
               <asp:BoundField DataField="Id" HeaderText="Id" HeaderStyle-Width="100px">
                  <ControlStyle Width="100px" />
                  <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
               </asp:BoundField>
               <asp:BoundField DataField="Name" HeaderText="Nome" HeaderStyle-Width="400px">
                  <ControlStyle Width="400px" />
                  <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
               </asp:BoundField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
         </asp:GridView>
      </ContentTemplate>
   </asp:UpdatePanel>
</asp:Content>
