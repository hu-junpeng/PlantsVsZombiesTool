namespace PlantsVsZombiesTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGet = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnMoney = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtLev = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(44, 83);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(93, 23);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "启用-阳光无限";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnMoney
            // 
            this.btnMoney.Location = new System.Drawing.Point(158, 83);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(75, 23);
            this.btnMoney.TabIndex = 1;
            this.btnMoney.Text = "无限金钱";
            this.btnMoney.UseVisualStyleBackColor = true;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(158, 38);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtLev
            // 
            this.txtLev.Location = new System.Drawing.Point(55, 40);
            this.txtLev.Name = "txtLev";
            this.txtLev.Size = new System.Drawing.Size(65, 21);
            this.txtLev.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 157);
            this.Controls.Add(this.txtLev);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnMoney);
            this.Controls.Add(this.btnGet);
            this.Name = "Form1";
            this.Text = "植物大战僵尸外挂";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtLev;
    }
}

