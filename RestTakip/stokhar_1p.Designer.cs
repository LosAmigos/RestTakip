namespace RestTakip
{
    partial class stokhar_1p
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stokhar_1p));
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DataAccess.DataConnection dataConnection1 = new DevExpress.DataAccess.DataConnection();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.pieDashboardItem1 = new DevExpress.DashboardCommon.PieDashboardItem();
            this.dataSource1 = new DevExpress.DashboardCommon.DataSource();
            this.rangeFilterDashboardItem1 = new DevExpress.DashboardCommon.RangeFilterDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeFilterDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pieDashboardItem1
            // 
            dimension1.DataMember = "STOKADI";
            this.pieDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.pieDashboardItem1.ComponentName = "pieDashboardItem1";
            dimension2.DataMember = "TARIH";
            dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
            measure1.DataMember = "CIKISFIYAT";
            this.pieDashboardItem1.DataItemRepository.Clear();
            this.pieDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.pieDashboardItem1.DataItemRepository.Add(dimension2, "DataItem1");
            this.pieDashboardItem1.DataItemRepository.Add(measure1, "DataItem2");
            this.pieDashboardItem1.DataSource = this.dataSource1;
            this.pieDashboardItem1.IgnoreMasterFilters = false;
            this.pieDashboardItem1.Name = "Stok Toplam Çıkış Fiyatı";
            this.pieDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2});
            this.pieDashboardItem1.ShowCaption = true;
            this.pieDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure1});
            // 
            // dataSource1
            // 
            this.dataSource1.ComponentName = "dataSource1";
            this.dataSource1.DataProviderSerializable = resources.GetString("dataSource1.DataProviderSerializable");
            this.dataSource1.Name = "dash_conn";
            // 
            // rangeFilterDashboardItem1
            // 
            dimension3.DataMember = "TARIH";
            dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
            this.rangeFilterDashboardItem1.Argument = dimension3;
            this.rangeFilterDashboardItem1.ComponentName = "rangeFilterDashboardItem1";
            dimension4.DataMember = "STOKADI";
            measure2.DataMember = "CIKISFIYAT";
            this.rangeFilterDashboardItem1.DataItemRepository.Clear();
            this.rangeFilterDashboardItem1.DataItemRepository.Add(dimension4, "DataItem0");
            this.rangeFilterDashboardItem1.DataItemRepository.Add(dimension3, "DataItem1");
            this.rangeFilterDashboardItem1.DataItemRepository.Add(measure2, "DataItem2");
            this.rangeFilterDashboardItem1.DataSource = this.dataSource1;
            this.rangeFilterDashboardItem1.IgnoreMasterFilters = true;
            this.rangeFilterDashboardItem1.Name = "Range Filter 1";
            simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line;
            simpleSeries1.AddDataItem("Value", measure2);
            this.rangeFilterDashboardItem1.Series.AddRange(new DevExpress.DashboardCommon.SimpleSeries[] {
            simpleSeries1});
            this.rangeFilterDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4});
            this.rangeFilterDashboardItem1.ShowCaption = false;
            // 
            // stokhar_1p
            // 
            dataConnection1.Name = "localhost_los_amigosConnection";
            dataConnection1.ParametersSerializable = resources.GetString("dataConnection1.ParametersSerializable");
            dataConnection1.ProviderKey = "MySql";
            this.DataConnections.Add(dataConnection1);
            this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {
            this.dataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.pieDashboardItem1,
            this.rangeFilterDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.pieDashboardItem1;
            dashboardLayoutItem1.Weight = 80.821917808219183D;
            dashboardLayoutItem2.DashboardItem = this.rangeFilterDashboardItem1;
            dashboardLayoutItem2.Weight = 19.17808219178082D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Stok Hareketi";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeFilterDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.PieDashboardItem pieDashboardItem1;
        private DevExpress.DashboardCommon.DataSource dataSource1;
        private DevExpress.DashboardCommon.RangeFilterDashboardItem rangeFilterDashboardItem1;
    }
}
