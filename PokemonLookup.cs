using PokeAPI;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PokemonTestAPI
{
    public partial class frmPokemonLookup : Form
    {
        PokemonInformation pokemonInformation = new PokemonInformation();
        public frmPokemonLookup()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Initiates a search after the user presses the button that calls the PokemonLookup function in PokemonInformation cs file then puts the info into the corresponding text boxes.
        /// </summary>
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string[] speciesInfo = await pokemonInformation.PokemonLookup(txtSpecies.Text);

            if (speciesInfo != null)
            {
                txtSpecies.Text = speciesInfo[0];
                txtHappiness.Text = speciesInfo[1];
                txtCaptureRate.Text = speciesInfo[2];
                txtHabitat.Text = speciesInfo[3];
                txtGrowthRate.Text = speciesInfo[4];
                txtFlavor.Text = speciesInfo[5];
                txtEggGroup.Text = speciesInfo[6];
            }
        }
    }
}
