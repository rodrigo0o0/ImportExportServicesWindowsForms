namespace ExportarImportarServicos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLocalPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnListServices = new System.Windows.Forms.Button();
            this.txtNameService = new System.Windows.Forms.TextBox();
            this.lblNameService = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.checkedListBoxServices = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnLocalPath
            // 
            this.btnLocalPath.Location = new System.Drawing.Point(522, 386);
            this.btnLocalPath.Name = "btnLocalPath";
            this.btnLocalPath.Size = new System.Drawing.Size(181, 27);
            this.btnLocalPath.TabIndex = 0;
            this.btnLocalPath.Text = "Localizar Caminho";
            this.btnLocalPath.UseVisualStyleBackColor = true;
            this.btnLocalPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 393);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(483, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnListServices
            // 
            this.btnListServices.Location = new System.Drawing.Point(522, 35);
            this.btnListServices.Name = "btnListServices";
            this.btnListServices.Size = new System.Drawing.Size(181, 23);
            this.btnListServices.TabIndex = 2;
            this.btnListServices.Text = "Listar Serviços";
            this.btnListServices.UseVisualStyleBackColor = true;
            this.btnListServices.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNameService
            // 
            this.txtNameService.Location = new System.Drawing.Point(12, 35);
            this.txtNameService.Name = "txtNameService";
            this.txtNameService.Size = new System.Drawing.Size(343, 20);
            this.txtNameService.TabIndex = 3;
            this.txtNameService.Text = "Digite o nome do serviço";
            // 
            // lblNameService
            // 
            this.lblNameService.AutoSize = true;
            this.lblNameService.Location = new System.Drawing.Point(12, 9);
            this.lblNameService.Name = "lblNameService";
            this.lblNameService.Size = new System.Drawing.Size(139, 13);
            this.lblNameService.TabIndex = 4;
            this.lblNameService.Text = "Contém no nome do serviço";
            this.lblNameService.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(400, 38);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(94, 17);
            this.cbActive.TabIndex = 5;
            this.cbActive.Text = "Serviço ativo?";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxServices
            // 
            this.checkedListBoxServices.FormattingEnabled = true;
            this.checkedListBoxServices.Location = new System.Drawing.Point(15, 72);
            this.checkedListBoxServices.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.checkedListBoxServices.Name = "checkedListBoxServices";
            this.checkedListBoxServices.Size = new System.Drawing.Size(340, 229);
            this.checkedListBoxServices.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBoxServices);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.lblNameService);
            this.Controls.Add(this.txtNameService);
            this.Controls.Add(this.btnListServices);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnLocalPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnListServices;
        private System.Windows.Forms.TextBox txtNameService;
        private System.Windows.Forms.Label lblNameService;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.CheckedListBox checkedListBoxServices;
    }
}

