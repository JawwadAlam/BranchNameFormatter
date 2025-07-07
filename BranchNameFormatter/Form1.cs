using System.ComponentModel;
using System.Diagnostics;

namespace BranchNameFormatter;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }


    private async void btnGenerate_Click(object sender, EventArgs e)
    {
        string input = txtInput.Text.Trim();
        txtBranchName.Text = GenerateBranchName(input);
    }

    public static string GenerateBranchName(string input)
    {
        var hasDashAt3rdCharacter = input.IndexOf('-') == 2;
        string branchName = input.Replace("-", "").Replace(" ", "-").Replace("/", "-").Replace(":", "").Replace(",", "").Replace(".", "").Replace("'", "").Replace("--", "-").Replace(">", "-");

        if (hasDashAt3rdCharacter)
        {
            branchName = branchName.Insert(2, "-");
        }

        Clipboard.SetText(branchName);

        return branchName;
    }
}
