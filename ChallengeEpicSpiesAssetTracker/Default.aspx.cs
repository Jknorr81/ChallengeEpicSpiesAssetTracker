using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assetNames = new string[0];
                double[] electionsRigged = new double[0];
                double[] actsOfSubterfuge = new double[0];

                ViewState.Add("AssetNames", assetNames);
                ViewState.Add("ElectionsRigged", electionsRigged);
                ViewState.Add("ActsOfSubterfuge", actsOfSubterfuge);
            }
        }

        protected void addAssetButton_Click(object sender, EventArgs e)
        {
            string[] assetNames = (string[])ViewState["AssetNames"];
            Array.Resize(ref assetNames, assetNames.Length + 1);
            int newestAsset = assetNames.GetUpperBound(0);
            assetNames[newestAsset] = nameTextBox.Text;
            ViewState.Add("AssetNames", assetNames);


            double [] electionsRigged = (double [])ViewState["ElectionsRigged"];
            Array.Resize(ref electionsRigged, electionsRigged.Length + 1);
            int newestElectionRigged = electionsRigged.GetUpperBound(0);
            electionsRigged[newestElectionRigged] = int.Parse(electionsTextBox.Text);
            ViewState.Add("ElectionsRigged", electionsRigged);


            double[] actsOfSubterfuge = (double[])ViewState["ActsOfSubterfuge"];
            Array.Resize(ref actsOfSubterfuge, actsOfSubterfuge.Length + 1);
            int newestActsOfSubterfuge = actsOfSubterfuge.GetUpperBound(0);
            actsOfSubterfuge[newestActsOfSubterfuge] = int.Parse(subterfugeTextBox.Text);
            ViewState.Add("ActsOfSubterfuge", actsOfSubterfuge);

            resultLabel.Text = string.Format(
                "Total Elections Rigged: {0}<br />" +
                "Average Acts of Subterfuge per Asset: {1:N2}<br />" +
                "(Last Asset you added: {2}):",
                electionsRigged.Sum(),
                actsOfSubterfuge.Average(),
                assetNames.Last());

            nameTextBox.Text = "";
            electionsTextBox.Text = "";
            subterfugeTextBox.Text = "";

        }
    }
}