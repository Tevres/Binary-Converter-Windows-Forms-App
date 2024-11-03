using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BinaryConverter : Form
    {
        public BinaryConverter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBoxNumberInput.Text, out int eingegebeneZahl);

            // Initialisiere eine leere Zeichenfolge für die Binärzahl
            string binaerZahl = "";

            // Liste zur Speicherung der Schritte
            List<string> schritte = new List<string>(); 
            
            // Konvertiere die eingegebene Zahl in die binäre Darstellung
            while (eingegebeneZahl > 0)
            {
                int bit = eingegebeneZahl % 2;
                int h = eingegebeneZahl / 2;
                int rest = eingegebeneZahl - (h * 2);
                
                // Füge den aktuellen Schritt zur Liste hinzu
                schritte.Add($"--> {eingegebeneZahl} / 2 = {h} Rest: {rest}");

                // Füge das Bit zur Binärzahl hinzu
                binaerZahl = bit.ToString() + binaerZahl;

                // Aktualisiere die eingegebene Zahl
                eingegebeneZahl = h; 
            }

            // Wenn die Eingabe 0 ist, muss die Binärdarstellung "0" sein
            if (binaerZahl == "")
            {
                binaerZahl = "0";
            }

            // Gebe alle Schritte aus
            label1.Text = "Binär: " + binaerZahl + "\n\nSchritte:\n" + string.Join("\n", schritte);
        }
    




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumberInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BinaryConverter_Load(object sender, EventArgs e)
        {

        }
    }
}
