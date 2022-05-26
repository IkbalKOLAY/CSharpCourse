
namespace EntityFrameworkDemo
{
    partial class Form1
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.lblStockAMountUpdate = new System.Windows.Forms.Label();
            this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.lblStockAmountAdd = new System.Windows.Forms.Label();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.lblUnitPriceAdd = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblNameAdd = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxGetById = new System.Windows.Forms.Button();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(315, 409);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 23);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblStockAMountUpdate);
            this.gbxUpdate.Controls.Add(this.tbxStockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUpdate.Location = new System.Drawing.Point(404, 185);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(242, 202);
            this.gbxUpdate.TabIndex = 12;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a Product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(109, 173);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(109, 81);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitPriceUpdate.TabIndex = 4;
            // 
            // lblStockAMountUpdate
            // 
            this.lblStockAMountUpdate.AutoSize = true;
            this.lblStockAMountUpdate.Location = new System.Drawing.Point(18, 130);
            this.lblStockAMountUpdate.Name = "lblStockAMountUpdate";
            this.lblStockAMountUpdate.Size = new System.Drawing.Size(73, 13);
            this.lblStockAMountUpdate.TabIndex = 5;
            this.lblStockAMountUpdate.Text = "Stock Amount";
            // 
            // tbxStockAmountUpdate
            // 
            this.tbxStockAmountUpdate.Location = new System.Drawing.Point(109, 130);
            this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            this.tbxStockAmountUpdate.Size = new System.Drawing.Size(100, 21);
            this.tbxStockAmountUpdate.TabIndex = 6;
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(18, 81);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(52, 13);
            this.lblUnitPriceUpdate.TabIndex = 3;
            this.lblUnitPriceUpdate.Text = "Unit Price";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(109, 36);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(100, 21);
            this.tbxNameUpdate.TabIndex = 1;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(18, 36);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(34, 13);
            this.lblNameUpdate.TabIndex = 2;
            this.lblNameUpdate.Text = "Name";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.button1);
            this.gbxAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxAdd.Controls.Add(this.lblStockAmountAdd);
            this.gbxAdd.Controls.Add(this.tbxStockAmount);
            this.gbxAdd.Controls.Add(this.lblUnitPriceAdd);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.lblNameAdd);
            this.gbxAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAdd.Location = new System.Drawing.Point(84, 185);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(242, 202);
            this.gbxAdd.TabIndex = 11;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Product";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(109, 81);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitPrice.TabIndex = 4;
            // 
            // lblStockAmountAdd
            // 
            this.lblStockAmountAdd.AutoSize = true;
            this.lblStockAmountAdd.Location = new System.Drawing.Point(18, 130);
            this.lblStockAmountAdd.Name = "lblStockAmountAdd";
            this.lblStockAmountAdd.Size = new System.Drawing.Size(73, 13);
            this.lblStockAmountAdd.TabIndex = 5;
            this.lblStockAmountAdd.Text = "Stock Amount";
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(109, 130);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(100, 21);
            this.tbxStockAmount.TabIndex = 6;
            // 
            // lblUnitPriceAdd
            // 
            this.lblUnitPriceAdd.AutoSize = true;
            this.lblUnitPriceAdd.Location = new System.Drawing.Point(18, 81);
            this.lblUnitPriceAdd.Name = "lblUnitPriceAdd";
            this.lblUnitPriceAdd.Size = new System.Drawing.Size(52, 13);
            this.lblUnitPriceAdd.TabIndex = 3;
            this.lblUnitPriceAdd.Text = "Unit Price";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(109, 36);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 21);
            this.tbxName.TabIndex = 1;
            // 
            // lblNameAdd
            // 
            this.lblNameAdd.AutoSize = true;
            this.lblNameAdd.Location = new System.Drawing.Point(18, 36);
            this.lblNameAdd.Name = "lblNameAdd";
            this.lblNameAdd.Size = new System.Drawing.Size(34, 13);
            this.lblNameAdd.TabIndex = 2;
            this.lblNameAdd.Text = "Name";
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(51, 44);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(628, 116);
            this.dgwProducts.TabIndex = 10;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(513, 12);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 14;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(451, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Search";
            // 
            // tbxGetById
            // 
            this.tbxGetById.Location = new System.Drawing.Point(340, 12);
            this.tbxGetById.Name = "tbxGetById";
            this.tbxGetById.Size = new System.Drawing.Size(75, 23);
            this.tbxGetById.TabIndex = 16;
            this.tbxGetById.Text = "GetById";
            this.tbxGetById.UseVisualStyleBackColor = true;
            this.tbxGetById.Click += new System.EventHandler(this.tbxGetById_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxGetById);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.Label lblStockAMountUpdate;
        private System.Windows.Forms.TextBox tbxStockAmountUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.Label lblStockAmountAdd;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.Label lblUnitPriceAdd;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblNameAdd;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button tbxGetById;
    }
}

