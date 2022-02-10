namespace Browser
{
    partial class TabUC
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabUC));
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.tableUrl = new System.Windows.Forms.TableLayoutPanel();
            this.btnPageSettings = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnWebsiteConfig = new System.Windows.Forms.Button();
            this.WebBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tableMain.SuspendLayout();
            this.tableControls.SuspendLayout();
            this.tableUrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 1;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.tableControls, 0, 0);
            this.tableMain.Controls.Add(this.WebBrowser, 0, 1);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Margin = new System.Windows.Forms.Padding(0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 2;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMain.Size = new System.Drawing.Size(800, 450);
            this.tableMain.TabIndex = 2;
            // 
            // tableControls
            // 
            this.tableControls.ColumnCount = 6;
            this.tableControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableControls.Controls.Add(this.btnRefresh, 0, 0);
            this.tableControls.Controls.Add(this.btnForward, 0, 0);
            this.tableControls.Controls.Add(this.btnSettings, 5, 0);
            this.tableControls.Controls.Add(this.btnHome, 2, 0);
            this.tableControls.Controls.Add(this.btnPrevious, 0, 0);
            this.tableControls.Controls.Add(this.tableUrl, 4, 0);
            this.tableControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableControls.Location = new System.Drawing.Point(0, 0);
            this.tableControls.Margin = new System.Windows.Forms.Padding(0);
            this.tableControls.Name = "tableControls";
            this.tableControls.RowCount = 1;
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableControls.Size = new System.Drawing.Size(800, 30);
            this.tableControls.TabIndex = 7;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(63, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnForward.BackgroundImage")));
            this.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnForward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Location = new System.Drawing.Point(33, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(24, 24);
            this.btnForward.TabIndex = 2;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.BtnForward_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(773, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(24, 24);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(93, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(24, 24);
            this.btnHome.TabIndex = 4;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.BackgroundImage")));
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(3, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(24, 24);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // tableUrl
            // 
            this.tableUrl.BackColor = System.Drawing.SystemColors.Window;
            this.tableUrl.ColumnCount = 3;
            this.tableUrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableUrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableUrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableUrl.Controls.Add(this.btnPageSettings, 0, 0);
            this.tableUrl.Controls.Add(this.txtUrl, 1, 0);
            this.tableUrl.Controls.Add(this.btnWebsiteConfig, 2, 0);
            this.tableUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableUrl.Location = new System.Drawing.Point(123, 3);
            this.tableUrl.Name = "tableUrl";
            this.tableUrl.RowCount = 1;
            this.tableUrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableUrl.Size = new System.Drawing.Size(644, 24);
            this.tableUrl.TabIndex = 8;
            // 
            // btnPageSettings
            // 
            this.btnPageSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPageSettings.BackgroundImage")));
            this.btnPageSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPageSettings.FlatAppearance.BorderSize = 0;
            this.btnPageSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageSettings.Location = new System.Drawing.Point(3, 3);
            this.btnPageSettings.Name = "btnPageSettings";
            this.btnPageSettings.Size = new System.Drawing.Size(22, 18);
            this.btnPageSettings.TabIndex = 11;
            this.btnPageSettings.UseVisualStyleBackColor = true;
            // 
            // txtUrl
            // 
            this.txtUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(33, 3);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(578, 17);
            this.txtUrl.TabIndex = 6;
            this.txtUrl.WordWrap = false;
            this.txtUrl.Enter += new System.EventHandler(this.TxtUrl_Enter);
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUrl_KeyDown);
            this.txtUrl.Leave += new System.EventHandler(this.TxtUrl_Leave);
            // 
            // btnWebsiteConfig
            // 
            this.btnWebsiteConfig.FlatAppearance.BorderSize = 0;
            this.btnWebsiteConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebsiteConfig.Location = new System.Drawing.Point(619, 3);
            this.btnWebsiteConfig.Name = "btnWebsiteConfig";
            this.btnWebsiteConfig.Size = new System.Drawing.Size(22, 18);
            this.btnWebsiteConfig.TabIndex = 10;
            this.btnWebsiteConfig.UseVisualStyleBackColor = true;
            // 
            // WebBrowser
            // 
            this.WebBrowser.CreationProperties = null;
            this.WebBrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser.Location = new System.Drawing.Point(0, 30);
            this.WebBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(800, 420);
            this.WebBrowser.TabIndex = 0;
            this.WebBrowser.ZoomFactor = 1D;
            this.WebBrowser.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.WebBrowser_NavigationCompleted);
            // 
            // TabUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TabUC";
            this.Size = new System.Drawing.Size(800, 450);
            this.tableMain.ResumeLayout(false);
            this.tableControls.ResumeLayout(false);
            this.tableUrl.ResumeLayout(false);
            this.tableUrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.TableLayoutPanel tableControls;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPrevious;
        private Microsoft.Web.WebView2.WinForms.WebView2 WebBrowser;
        private System.Windows.Forms.TableLayoutPanel tableUrl;
        private System.Windows.Forms.Button btnWebsiteConfig;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnPageSettings;
    }
}
