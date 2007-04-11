﻿namespace KeePass.Forms
{
	partial class PluginsForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.m_btnOK = new System.Windows.Forms.Button();
			this.m_lvPlugins = new System.Windows.Forms.ListView();
			this.m_chName = new System.Windows.Forms.ColumnHeader();
			this.m_chVersion = new System.Windows.Forms.ColumnHeader();
			this.m_chAuthor = new System.Windows.Forms.ColumnHeader();
			this.m_chDesc = new System.Windows.Forms.ColumnHeader();
			this.m_chFile = new System.Windows.Forms.ColumnHeader();
			this.m_lblSeparator = new System.Windows.Forms.Label();
			this.m_bannerImage = new System.Windows.Forms.PictureBox();
			this.m_grpPluginDesc = new System.Windows.Forms.GroupBox();
			this.m_lblSelectedPluginDesc = new System.Windows.Forms.Label();
			this.m_linkPlugins = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
			this.m_grpPluginDesc.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_btnOK
			// 
			this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnOK.Location = new System.Drawing.Point(532, 406);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(75, 23);
			this.m_btnOK.TabIndex = 0;
			this.m_btnOK.Text = "&Close";
			this.m_btnOK.UseVisualStyleBackColor = true;
			this.m_btnOK.Click += new System.EventHandler(this.OnBtnClose);
			// 
			// m_lvPlugins
			// 
			this.m_lvPlugins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.m_chName,
            this.m_chVersion,
            this.m_chAuthor,
            this.m_chDesc,
            this.m_chFile});
			this.m_lvPlugins.FullRowSelect = true;
			this.m_lvPlugins.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.m_lvPlugins.HideSelection = false;
			this.m_lvPlugins.Location = new System.Drawing.Point(12, 66);
			this.m_lvPlugins.Name = "m_lvPlugins";
			this.m_lvPlugins.ShowItemToolTips = true;
			this.m_lvPlugins.Size = new System.Drawing.Size(595, 210);
			this.m_lvPlugins.TabIndex = 1;
			this.m_lvPlugins.UseCompatibleStateImageBehavior = false;
			this.m_lvPlugins.View = System.Windows.Forms.View.Details;
			this.m_lvPlugins.SelectedIndexChanged += new System.EventHandler(this.OnPluginListSelectedIndexChanged);
			// 
			// m_chName
			// 
			this.m_chName.Text = "Plugin";
			this.m_chName.Width = 197;
			// 
			// m_chVersion
			// 
			this.m_chVersion.Text = "Version";
			this.m_chVersion.Width = 106;
			// 
			// m_chAuthor
			// 
			this.m_chAuthor.Text = "Author";
			this.m_chAuthor.Width = 136;
			// 
			// m_chDesc
			// 
			this.m_chDesc.Text = "Description";
			this.m_chDesc.Width = 0;
			// 
			// m_chFile
			// 
			this.m_chFile.Text = "File Path";
			this.m_chFile.Width = 119;
			// 
			// m_lblSeparator
			// 
			this.m_lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.m_lblSeparator.Location = new System.Drawing.Point(0, 398);
			this.m_lblSeparator.Name = "m_lblSeparator";
			this.m_lblSeparator.Size = new System.Drawing.Size(619, 2);
			this.m_lblSeparator.TabIndex = 3;
			// 
			// m_bannerImage
			// 
			this.m_bannerImage.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_bannerImage.Location = new System.Drawing.Point(0, 0);
			this.m_bannerImage.Name = "m_bannerImage";
			this.m_bannerImage.Size = new System.Drawing.Size(619, 60);
			this.m_bannerImage.TabIndex = 0;
			this.m_bannerImage.TabStop = false;
			// 
			// m_grpPluginDesc
			// 
			this.m_grpPluginDesc.Controls.Add(this.m_lblSelectedPluginDesc);
			this.m_grpPluginDesc.Location = new System.Drawing.Point(12, 282);
			this.m_grpPluginDesc.Name = "m_grpPluginDesc";
			this.m_grpPluginDesc.Size = new System.Drawing.Size(595, 102);
			this.m_grpPluginDesc.TabIndex = 2;
			this.m_grpPluginDesc.TabStop = false;
			// 
			// m_lblSelectedPluginDesc
			// 
			this.m_lblSelectedPluginDesc.Location = new System.Drawing.Point(6, 16);
			this.m_lblSelectedPluginDesc.Name = "m_lblSelectedPluginDesc";
			this.m_lblSelectedPluginDesc.Size = new System.Drawing.Size(583, 64);
			this.m_lblSelectedPluginDesc.TabIndex = 0;
			this.m_lblSelectedPluginDesc.Text = "<>";
			// 
			// m_linkPlugins
			// 
			this.m_linkPlugins.AutoSize = true;
			this.m_linkPlugins.Location = new System.Drawing.Point(9, 411);
			this.m_linkPlugins.Name = "m_linkPlugins";
			this.m_linkPlugins.Size = new System.Drawing.Size(97, 13);
			this.m_linkPlugins.TabIndex = 4;
			this.m_linkPlugins.TabStop = true;
			this.m_linkPlugins.Text = "Get More Plugins...";
			this.m_linkPlugins.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPluginsLinkClicked);
			// 
			// PluginsForm
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_btnOK;
			this.ClientSize = new System.Drawing.Size(619, 441);
			this.Controls.Add(this.m_linkPlugins);
			this.Controls.Add(this.m_grpPluginDesc);
			this.Controls.Add(this.m_lblSeparator);
			this.Controls.Add(this.m_lvPlugins);
			this.Controls.Add(this.m_btnOK);
			this.Controls.Add(this.m_bannerImage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PluginsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Plugins";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
			this.Load += new System.EventHandler(this.OnFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).EndInit();
			this.m_grpPluginDesc.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox m_bannerImage;
		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.ListView m_lvPlugins;
		private System.Windows.Forms.ColumnHeader m_chName;
		private System.Windows.Forms.ColumnHeader m_chVersion;
		private System.Windows.Forms.ColumnHeader m_chAuthor;
		private System.Windows.Forms.Label m_lblSeparator;
		private System.Windows.Forms.ColumnHeader m_chFile;
		private System.Windows.Forms.GroupBox m_grpPluginDesc;
		private System.Windows.Forms.Label m_lblSelectedPluginDesc;
		private System.Windows.Forms.ColumnHeader m_chDesc;
		private System.Windows.Forms.LinkLabel m_linkPlugins;
	}
}