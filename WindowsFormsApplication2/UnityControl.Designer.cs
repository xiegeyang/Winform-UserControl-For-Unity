using System;

namespace Unity
{
    partial class UnityControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(string src)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnityControl));
            this.axUnityWebPlayer1 = new AxUnityWebPlayerAXLib.AxUnityWebPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axUnityWebPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axUnityWebPlayer1
            // 
            this.Controls.Add(this.axUnityWebPlayer1);
            ((System.ComponentModel.ISupportInitialize)(this.axUnityWebPlayer1)).EndInit();
            axUnityWebPlayer1.src = src;
            System.Windows.Forms.AxHost.State _state = axUnityWebPlayer1.OcxState;
            axUnityWebPlayer1.Dispose();

            axUnityWebPlayer1 = new AxUnityWebPlayerAXLib.AxUnityWebPlayer();
            ((System.ComponentModel.ISupportInitialize)(axUnityWebPlayer1)).BeginInit();
            this.SuspendLayout();
            axUnityWebPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            axUnityWebPlayer1.Name = "Unity3D";
            axUnityWebPlayer1.OcxState = _state;
            axUnityWebPlayer1.Size = new System.Drawing.Size(691, 418);
            axUnityWebPlayer1.TabIndex = 0;
            Controls.Add(axUnityWebPlayer1);
            ((System.ComponentModel.ISupportInitialize)(axUnityWebPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.axUnityWebPlayer1.OnExternalCall += new AxUnityWebPlayerAXLib._DUnityWebPlayerAXEvents_OnExternalCallEventHandler(this.axUnityWebPlayer1_OnExternalCall);
            // 
            // UnityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axUnityWebPlayer1);
            this.Name = "UnityControl";
            this.Size = new System.Drawing.Size(670, 363);
            ((System.ComponentModel.ISupportInitialize)(this.axUnityWebPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxUnityWebPlayerAXLib.AxUnityWebPlayer axUnityWebPlayer1;
    }
}
