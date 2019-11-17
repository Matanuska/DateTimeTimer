namespace DateTimeTimer
{
    partial class TimeZoneCombo
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstTimezones = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstTimezones
            // 
            this.lstTimezones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTimezones.FormattingEnabled = true;
            this.lstTimezones.Location = new System.Drawing.Point(3, 3);
            this.lstTimezones.Name = "lstTimezones";
            this.lstTimezones.Size = new System.Drawing.Size(283, 21);
            this.lstTimezones.TabIndex = 0;
            this.lstTimezones.SelectedIndexChanged += new System.EventHandler(this.lstTimezones_SelectedIndexChanged);
            // 
            // TimeZoneCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstTimezones);
            this.Name = "TimeZoneCombo";
            this.Size = new System.Drawing.Size(286, 25);
            this.Load += new System.EventHandler(this.TimeZoneCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox lstTimezones;
    }
}
