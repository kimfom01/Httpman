using Httpman.Core;

namespace Httpman;

public partial class Httpman : Form
{
    public Httpman()
    {
        InitializeComponent();
    }

    private async void goButton_Click(object sender, EventArgs e)
    {
        if (!ValidateUrl(urlInput.Text))
        {
            MessageBox.Show("Please enter a URL!", "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var requestClient = RequestFactory.GetHttpResolver();

        statusStripText.Text = "Making Request";

        var result = await requestClient.MakeRequest(urlInput.Text, null, RequestType.GET);

        statusStripText.Text = "Done";

        if (result.Body is not null)
        {
            resultTextbox.Text = result.Body;
        }
    }

    private bool ValidateUrl(string urlString)
    {
        statusStripText.Text = "Validating";

        if (urlString is null)
        {
            statusStripText.Text = "Invalid URL";
            return false;
        }


        try
        {
            _ = new Uri(urlString);

            statusStripText.Text = string.Empty;
            return true;
        }
        catch
        {
            statusStripText.Text = "Invalid URL";
            return false;
        }
    }
}
