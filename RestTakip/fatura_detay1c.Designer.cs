namespace RestTakip
{
    partial class fatura_detay1c
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
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fatura_detay1c));
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries2 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DataAccess.DataConnection dataConnection1 = new DevExpress.DataAccess.DataConnection();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.chartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.dataSource2 = new DevExpress.DashboardCommon.DataSource();
            this.rangeFilterDashboardItem1 = new DevExpress.DashboardCommon.RangeFilterDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeFilterDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // chartDashboardItem1
            // 
            dimension1.DataMember = "stokadi";
            dimension2.DataMember = "birim";
            this.chartDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1,
            dimension2});
            this.chartDashboardItem1.AxisX.TitleVisible = false;
            this.chartDashboardItem1.ComponentName = "chartDashboardItem1";
            dimension3.DataMember = "tarih";
            dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
            measure1.DataMember = "miktar";
            this.chartDashboardItem1.DataItemRepository.Clear();
            this.chartDashboardItem1.DataItemRepository.Add(dimension3, "DataItem3");
            this.chartDashboardItem1.DataItemRepository.Add(dimension2, "DataItem2");
            this.chartDashboardItem1.DataItemRepository.Add(measure1, "DataItem1");
            this.chartDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.chartDashboardItem1.DataSource = this.dataSource2;
            this.chartDashboardItem1.IgnoreMasterFilters = false;
            this.chartDashboardItem1.Name = "Stok Adedi";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.TitleVisible = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.AddDataItem("Value", measure1);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1});
            this.chartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3});
            this.chartDashboardItem1.ShowCaption = true;
            // 
            // dataSource2
            // 
            this.dataSource2.ComponentName = "dataSource2";
            this.dataSource2.DataProviderSerializable = resources.GetString("dataSource2.DataProviderSerializable");
            this.dataSource2.Name = "dash_conn";
            // 
            // rangeFilterDashboardItem1
            // 
            dimension4.DataMember = "tarih";
            dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
            this.rangeFilterDashboardItem1.Argument = dimension4;
            this.rangeFilterDashboardItem1.ComponentName = "rangeFilterDashboardItem1";
            dimension5.DataMember = "stokadi";
            measure2.DataMember = "miktar";
            this.rangeFilterDashboardItem1.DataItemRepository.Clear();
            this.rangeFilterDashboardItem1.DataItemRepository.Add(dimension5, "DataItem2");
            this.rangeFilterDashboardItem1.DataItemRepository.Add(measure2, "DataItem1");
            this.rangeFilterDashboardItem1.DataItemRepository.Add(dimension4, "DataItem0");
            this.rangeFilterDashboardItem1.DataSource = this.dataSource2;
            this.rangeFilterDashboardItem1.HiddenDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension5});
            this.rangeFilterDashboardItem1.IgnoreMasterFilters = true;
            this.rangeFilterDashboardItem1.Name = "Range Filter 1";
            simpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line;
            simpleSeries2.AddDataItem("Value", measure2);
            this.rangeFilterDashboardItem1.Series.AddRange(new DevExpress.DashboardCommon.SimpleSeries[] {
            simpleSeries2});
            this.rangeFilterDashboardItem1.ShowCaption = false;
            // 
            // fatura_detay1c
            // 
            dataConnection1.Name = "localhost_los_amigosConnection";
            dataConnection1.ParametersSerializable = resources.GetString("dataConnection1.ParametersSerializable");
            dataConnection1.ProviderKey = "MySql";
            this.DataConnections.Add(dataConnection1);
            this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {
            this.dataSource2});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.chartDashboardItem1,
            this.rangeFilterDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.chartDashboardItem1;
            dashboardLayoutItem1.Weight = 80.479452054794521D;
            dashboardLayoutItem2.DashboardItem = this.rangeFilterDashboardItem1;
            dashboardLayoutItem2.Weight = 19.520547945205479D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Fatura Detay";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeFilterDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItem1;
        private DevExpress.DashboardCommon.DataSource dataSource2;
        private DevExpress.DashboardCommon.RangeFilterDashboardItem rangeFilterDashboardItem1;
    }
}
