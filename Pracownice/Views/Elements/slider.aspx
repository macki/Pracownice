<%@ Page Language="C#" MasterPageFile="~/Views/Elements/ListBox.master" %>
<%@ Register TagPrefix="obout" Namespace="Obout.ListBox" Assembly="obout_ListBox" %>
<%@ Register TagPrefix="obout" Namespace="Obout.Interface" Assembly="obout_Interface" %>

<asp:Content runat="server" ContentPlaceHolderID="head">
    <script type="text/javascript">

        function ListBox1_ItemClick(sender, selectedIndex) {
            window.location.href = '/Home/Index/' + selectedIndex;
        }
    </script>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">


    <obout:ListBox runat="server" ID="ListBox1" Width="178"
        DataSourceID="sds1" DataTextField="NazwaMiasta" DataValueField="BazowaListaMiastId"
        style="top: 0px; left: 0px; display:block" 
        Font-Names="Andalus" FolderStyle="../../Content/skins/plain" 
        Font-Size="Large" Height="285px" Focused="true"
        >
        <ClientSideEvents 
            OnItemClick="ListBox1_ItemClick" />
    </obout:ListBox>
    
    <asp:SqlDataSource ID="sds1" runat="server" SelectCommand="SELECT * FROM [BazowaListaMiast]"
		ConnectionString="<%$ ConnectionStrings:PracowniceEntities %>" 
        ProviderName="<%$ ConnectionStrings:PracowniceEntities.ProviderName %>"></asp:SqlDataSource>
	
</asp:Content>