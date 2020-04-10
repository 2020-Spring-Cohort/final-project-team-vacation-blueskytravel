// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function sanityCheck() {
    alert('hello!')
}


<script runat="server">

    protected void Button_Click(object sender, EventArgs e)
{
        Button btn = (Button)sender;
btn.Text = (Int32.Parse(btn.Text) + 1).ToString();
}
</script>

