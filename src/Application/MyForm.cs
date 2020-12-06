using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XmlNotepad {

    /// <summary>
    /// Example subclass of the XmlNotepad main Form.
    /// </summary>
    public class MyForm : FormMain {

        public override void SaveConfig() {
            base.SaveConfig();
        }

        private void InitializeComponent()
        {
            this.tabPageTreeView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageTreeView
            // 
            this.tabPageTreeView.Location = new System.Drawing.Point(0, 23);
            this.tabPageTreeView.Size = new System.Drawing.Size(736, 337);
            // 
            // tabPageHtmlView
            // 
            this.tabPageHtmlView.Location = new System.Drawing.Point(0, 23);
            this.tabPageHtmlView.Size = new System.Drawing.Size(736, 337);
            // 
            // MyForm
            // 
            this.ClientSize = new System.Drawing.Size(736, 525);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.tabPageTreeView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}