<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<%@ Register assembly="obout_ListBox" namespace="Obout.ListBox"tagprefix="cc1" %>
    <form id="form1" runat="server">
        <cc1:ListBox ID="ListBox1" runat="server" 
            style="top: 0px; left: 0px; height: 200px; width: 100px; background-color:Aqua;"
            BackColor="#FF66CC" BorderColor="#FF99CC" BorderStyle="Dashed" 
            Font-Names="Andalus" FolderStyle="../../Content/skins/premiere_blue" >
            <cc1:ListBoxItem ID="ListBoxItem1" runat="server" Text="lala" />
            <cc1:ListBoxItem ID="ListBoxItem2" runat="server" Text="bla" />
            <cc1:ListBoxItem ID="ListBoxItem3" runat="server" Text="asdasd"/>
        </cc1:ListBox>
    </form>


