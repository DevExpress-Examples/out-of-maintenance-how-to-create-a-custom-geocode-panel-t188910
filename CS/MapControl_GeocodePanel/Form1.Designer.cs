namespace MapControl_GeocodePanel {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraMap.ImageTilesLayer imageTilesLayer1 = new DevExpress.XtraMap.ImageTilesLayer();
            DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            DevExpress.XtraMap.InformationLayer informationLayer1 = new DevExpress.XtraMap.InformationLayer();
            DevExpress.XtraMap.BingGeocodeDataProvider bingGeocodeDataProvider1 = new DevExpress.XtraMap.BingGeocodeDataProvider();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.teLatitude = new DevExpress.XtraEditors.TextEdit();
            this.lciLatitude = new DevExpress.XtraLayout.LayoutControlItem();
            this.teLongitude = new DevExpress.XtraEditors.TextEdit();
            this.lciLongitude = new DevExpress.XtraLayout.LayoutControlItem();
            this.bSearch = new System.Windows.Forms.Button();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLatitude.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLatitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLongitude.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.bSearch);
            this.layoutControl1.Controls.Add(this.teLongitude);
            this.layoutControl1.Controls.Add(this.teLatitude);
            this.layoutControl1.Controls.Add(this.mapControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(624, 441);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lciLatitude,
            this.lciLongitude,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(624, 441);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // mapControl1
            // 
            imageTilesLayer1.DataProvider = bingMapDataProvider1;
            informationLayer1.DataProvider = bingGeocodeDataProvider1;
            informationLayer1.Name = "GeocodeLayer";
            this.mapControl1.Layers.Add(imageTilesLayer1);
            this.mapControl1.Layers.Add(informationLayer1);
            this.mapControl1.Location = new System.Drawing.Point(4, 28);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(616, 409);
            this.mapControl1.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.mapControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(620, 413);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // teLatitude
            // 
            this.teLatitude.Location = new System.Drawing.Point(59, 4);
            this.teLatitude.Name = "teLatitude";
            this.teLatitude.Size = new System.Drawing.Size(191, 20);
            this.teLatitude.StyleController = this.layoutControl1;
            this.teLatitude.TabIndex = 5;
            // 
            // lciLatitude
            // 
            this.lciLatitude.Control = this.teLatitude;
            this.lciLatitude.Location = new System.Drawing.Point(0, 0);
            this.lciLatitude.Name = "lciLatitude";
            this.lciLatitude.Size = new System.Drawing.Size(250, 24);
            this.lciLatitude.Text = "Latitude:";
            this.lciLatitude.TextSize = new System.Drawing.Size(51, 13);
            // 
            // teLongitude
            // 
            this.teLongitude.Location = new System.Drawing.Point(309, 4);
            this.teLongitude.Name = "teLongitude";
            this.teLongitude.Size = new System.Drawing.Size(191, 20);
            this.teLongitude.StyleController = this.layoutControl1;
            this.teLongitude.TabIndex = 6;
            // 
            // lciLongitude
            // 
            this.lciLongitude.Control = this.teLongitude;
            this.lciLongitude.Location = new System.Drawing.Point(250, 0);
            this.lciLongitude.Name = "lciLongitude";
            this.lciLongitude.Size = new System.Drawing.Size(250, 24);
            this.lciLongitude.Text = "Longitude:";
            this.lciLongitude.TextSize = new System.Drawing.Size(51, 13);
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(504, 4);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(116, 20);
            this.bSearch.TabIndex = 7;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.bSearch;
            this.layoutControlItem4.Location = new System.Drawing.Point(500, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(120, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLatitude.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLatitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLongitude.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.Button bSearch;
        private DevExpress.XtraEditors.TextEdit teLongitude;
        private DevExpress.XtraEditors.TextEdit teLatitude;
        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciLatitude;
        private DevExpress.XtraLayout.LayoutControlItem lciLongitude;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;

    }
}

