using System;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace MapControl_GeocodePanel {
    public partial class Form1 : Form {
        InformationLayer GeocodeLayer { get { return (InformationLayer)mapControl1.Layers["GeocodeLayer"]; } }
        BingGeocodeDataProvider GeocodeProvider { get { return (BingGeocodeDataProvider)GeocodeLayer.DataProvider; } }

        public Form1() {
            InitializeComponent();
        }

        private void bSearch_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(teLatitude.Text)) {
                MessageBox.Show("Latitude field should be filled.");
                return;
            }
            double latitude = Double.Parse(teLatitude.Text);
            if ((latitude > 90) || (latitude < -90)) {
                MessageBox.Show("Latitude must be less than or equal to 90 and greater than or equal to - 90. Correct the input value.");
                return;
            }

            if (String.IsNullOrEmpty(teLongitude.Text)) {
                MessageBox.Show("Longitude field should be filled.");
                return;
            }
            double longitude = Double.Parse(teLongitude.Text);
            if ((longitude > 180) || (longitude < -180)) {
                MessageBox.Show("Longitude must be less than or equal to 180 and greater than or equal to - 180. Correct the input value.");
                return;
            }
           
            GeocodeProvider.RequestLocationInformation(new GeoPoint(latitude, longitude), null);
        }
    }
}
