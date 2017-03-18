namespace KHR_CONTROL_TEST1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.コマンドテキストボックス = new System.Windows.Forms.TextBox();
            this.送信ボタン = new System.Windows.Forms.Button();
            this.シリアルポート = new System.IO.Ports.SerialPort(this.components);
            this.RCB返信テキストボックス = new System.Windows.Forms.TextBox();
            this.コマンドラベル = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // コマンドテキストボックス
            // 
            this.コマンドテキストボックス.Location = new System.Drawing.Point(12, 24);
            this.コマンドテキストボックス.Name = "コマンドテキストボックス";
            this.コマンドテキストボックス.Size = new System.Drawing.Size(262, 19);
            this.コマンドテキストボックス.TabIndex = 0;
            // 
            // 送信ボタン
            // 
            this.送信ボタン.Location = new System.Drawing.Point(297, 24);
            this.送信ボタン.Name = "送信ボタン";
            this.送信ボタン.Size = new System.Drawing.Size(82, 31);
            this.送信ボタン.TabIndex = 1;
            this.送信ボタン.Text = "コマンド送信";
            this.送信ボタン.UseVisualStyleBackColor = true;
            this.送信ボタン.Click += new System.EventHandler(this.送信ボタン_Click);
            // 
            // シリアルポート
            // 
            this.シリアルポート.BaudRate = 115200;
            this.シリアルポート.Parity = System.IO.Ports.Parity.Even;
            this.シリアルポート.PortName = "COM3";
            this.シリアルポート.ReadTimeout = 100;
            // 
            // RCB返信テキストボックス
            // 
            this.RCB返信テキストボックス.Location = new System.Drawing.Point(12, 87);
            this.RCB返信テキストボックス.Name = "RCB返信テキストボックス";
            this.RCB返信テキストボックス.Size = new System.Drawing.Size(262, 19);
            this.RCB返信テキストボックス.TabIndex = 2;
            // 
            // コマンドラベル
            // 
            this.コマンドラベル.AutoSize = true;
            this.コマンドラベル.Location = new System.Drawing.Point(10, 9);
            this.コマンドラベル.Name = "コマンドラベル";
            this.コマンドラベル.Size = new System.Drawing.Size(83, 12);
            this.コマンドラベル.TabIndex = 3;
            this.コマンドラベル.Text = "送信するコマンド";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "RCB4からの返信";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 118);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.コマンドラベル);
            this.Controls.Add(this.RCB返信テキストボックス);
            this.Controls.Add(this.送信ボタン);
            this.Controls.Add(this.コマンドテキストボックス);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox コマンドテキストボックス;
        private System.Windows.Forms.Button 送信ボタン;
        private System.IO.Ports.SerialPort シリアルポート;
        private System.Windows.Forms.TextBox RCB返信テキストボックス;
        private System.Windows.Forms.Label コマンドラベル;
        private System.Windows.Forms.Label label1;
    }
}

