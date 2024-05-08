namespace _22_day
{
    partial class Form4
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
            this.confectioneryDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.confectioneryDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            // 
            // OrdersBindingSource
            // 
            this.OrdersBindingSource.DataMember = "Orders";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.confectioneryDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.BindingSource OrdersBindingSource;
        private System.Windows.Forms.BindingSource confectioneryDBDataSet1BindingSource;
    }
}