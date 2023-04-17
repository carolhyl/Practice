namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox = new System.Windows.Forms.TextBox();
			this.labelTag = new System.Windows.Forms.Label();
			this.button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(108, 107);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(459, 36);
			this.textBox.TabIndex = 0;
			// 
			// labelTag
			// 
			this.labelTag.AutoSize = true;
			this.labelTag.Location = new System.Drawing.Point(104, 186);
			this.labelTag.Name = "labelTag";
			this.labelTag.Size = new System.Drawing.Size(64, 24);
			this.labelTag.TabIndex = 1;
			this.labelTag.Text = "label1";
			// 
			// button
			// 
			this.button.Location = new System.Drawing.Point(262, 246);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(123, 45);
			this.button.TabIndex = 2;
			this.button.Text = "Moew";
			this.button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(661, 357);
			this.Controls.Add(this.button);
			this.Controls.Add(this.labelTag);
			this.Controls.Add(this.textBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Label labelTag;
		private System.Windows.Forms.Button button;
	}
}

