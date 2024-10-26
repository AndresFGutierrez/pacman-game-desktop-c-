namespace PacmanGame
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerAnimacion = new System.Windows.Forms.Timer(this.components);
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblVidas = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.timerJuego = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerAnimacion
            // 
            this.timerAnimacion.Enabled = true;
            this.timerAnimacion.Tick += new System.EventHandler(this.timerAnimacion_Tick);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.ForeColor = System.Drawing.Color.Lime;
            this.lblPuntaje.Location = new System.Drawing.Point(62, 13);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(105, 25);
            this.lblPuntaje.TabIndex = 0;
            this.lblPuntaje.Text = "Puntaje : 0";
            // 
            // lblVidas
            // 
            this.lblVidas.AutoSize = true;
            this.lblVidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidas.ForeColor = System.Drawing.Color.Lime;
            this.lblVidas.Location = new System.Drawing.Point(239, 13);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(89, 25);
            this.lblVidas.TabIndex = 1;
            this.lblVidas.Text = "Vidas : 5";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.Lime;
            this.lblTiempo.Location = new System.Drawing.Point(419, 13);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(105, 25);
            this.lblTiempo.TabIndex = 2;
            this.lblTiempo.Text = "Tiempo : 0";
            // 
            // timerJuego
            // 
            this.timerJuego.Enabled = true;
            this.timerJuego.Interval = 1000;
            this.timerJuego.Tick += new System.EventHandler(this.timerJuego_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(998, 607);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblVidas);
            this.Controls.Add(this.lblPuntaje);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacman";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerAnimacion;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblVidas;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Timer timerJuego;
    }
}

