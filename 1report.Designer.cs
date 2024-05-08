namespace _22_day
{
    partial class report1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.confectioneryDBDataSet = new _22_day.ConfectioneryDBDataSet();
            this.productsTableAdapter = new _22_day.ConfectioneryDBDataSetTableAdapters.ProductsTableAdapter();
            this.fKOrderDetailsProductIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsTableAdapter = new _22_day.ConfectioneryDBDataSetTableAdapters.OrderDetailsTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.confectioneryDBDataSet1 = new _22_day.ConfectioneryDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confectioneryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrderDetailsProductIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confectioneryDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.confectioneryDBDataSet;
            // 
            // confectioneryDBDataSet
            // 
            this.confectioneryDBDataSet.DataSetName = "ConfectioneryDBDataSet";
            this.confectioneryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // fKOrderDetailsProductIDBindingSource
            // 
            this.fKOrderDetailsProductIDBindingSource.DataMember = "FK_OrderDetails_ProductID";
            this.fKOrderDetailsProductIDBindingSource.DataSource = this.productsBindingSource;
            // 
            // orderDetailsTableAdapter
            // 
            this.orderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "_22_day.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // confectioneryDBDataSet1
            // 
            this.confectioneryDBDataSet1.DataSetName = "ConfectioneryDBDataSet";
            this.confectioneryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report1";
            this.Text = "_1report";
            this.Load += new System.EventHandler(this.report1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confectioneryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrderDetailsProductIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confectioneryDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ConfectioneryDBDataSet confectioneryDBDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ConfectioneryDBDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource fKOrderDetailsProductIDBindingSource;
        private ConfectioneryDBDataSetTableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ConfectioneryDBDataSet confectioneryDBDataSet1;
    }
}