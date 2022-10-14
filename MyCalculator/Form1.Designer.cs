namespace MyCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Result = new System.Windows.Forms.Panel();
            this.Lscore = new System.Windows.Forms.Label();
            this.Buttons_panel = new System.Windows.Forms.Panel();
            this.Bsquareroot = new System.Windows.Forms.Button();
            this.Bsquare = new System.Windows.Forms.Button();
            this.Bdot = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.Bequals = new System.Windows.Forms.Button();
            this.Bmultiply = new System.Windows.Forms.Button();
            this.Bdivide = new System.Windows.Forms.Button();
            this.Bminus = new System.Windows.Forms.Button();
            this.Badd = new System.Windows.Forms.Button();
            this.Bbackspace = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.Bclear = new System.Windows.Forms.Button();
            this.Result.SuspendLayout();
            this.Buttons_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Result.Controls.Add(this.Lscore);
            this.Result.Dock = System.Windows.Forms.DockStyle.Top;
            this.Result.Location = new System.Drawing.Point(0, 0);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(333, 137);
            this.Result.TabIndex = 0;
            // 
            // Lscore
            // 
            this.Lscore.BackColor = System.Drawing.Color.Black;
            this.Lscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lscore.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lscore.ForeColor = System.Drawing.Color.White;
            this.Lscore.Location = new System.Drawing.Point(34, 48);
            this.Lscore.Name = "Lscore";
            this.Lscore.Size = new System.Drawing.Size(270, 39);
            this.Lscore.TabIndex = 0;
            this.Lscore.Text = "0";
            this.Lscore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Buttons_panel
            // 
            this.Buttons_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Buttons_panel.Controls.Add(this.Bsquareroot);
            this.Buttons_panel.Controls.Add(this.Bsquare);
            this.Buttons_panel.Controls.Add(this.Bdot);
            this.Buttons_panel.Controls.Add(this.B0);
            this.Buttons_panel.Controls.Add(this.Bequals);
            this.Buttons_panel.Controls.Add(this.Bmultiply);
            this.Buttons_panel.Controls.Add(this.Bdivide);
            this.Buttons_panel.Controls.Add(this.Bminus);
            this.Buttons_panel.Controls.Add(this.Badd);
            this.Buttons_panel.Controls.Add(this.Bbackspace);
            this.Buttons_panel.Controls.Add(this.B9);
            this.Buttons_panel.Controls.Add(this.B8);
            this.Buttons_panel.Controls.Add(this.B7);
            this.Buttons_panel.Controls.Add(this.B6);
            this.Buttons_panel.Controls.Add(this.B5);
            this.Buttons_panel.Controls.Add(this.B3);
            this.Buttons_panel.Controls.Add(this.B4);
            this.Buttons_panel.Controls.Add(this.B2);
            this.Buttons_panel.Controls.Add(this.B1);
            this.Buttons_panel.Controls.Add(this.Bclear);
            this.Buttons_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Buttons_panel.Location = new System.Drawing.Point(0, 137);
            this.Buttons_panel.Name = "Buttons_panel";
            this.Buttons_panel.Size = new System.Drawing.Size(333, 310);
            this.Buttons_panel.TabIndex = 1;
            // 
            // Bsquareroot
            // 
            this.Bsquareroot.BackColor = System.Drawing.Color.Black;
            this.Bsquareroot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bsquareroot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bsquareroot.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bsquareroot.ForeColor = System.Drawing.Color.White;
            this.Bsquareroot.Location = new System.Drawing.Point(34, 240);
            this.Bsquareroot.Name = "Bsquareroot";
            this.Bsquareroot.Size = new System.Drawing.Size(63, 47);
            this.Bsquareroot.TabIndex = 19;
            this.Bsquareroot.Text = "√";
            this.Bsquareroot.UseVisualStyleBackColor = false;
            this.Bsquareroot.Click += new System.EventHandler(this.Bsquareroot_Click);
            this.Bsquareroot.MouseEnter += new System.EventHandler(this.Bsquareroot_MouseEnter);
            this.Bsquareroot.MouseLeave += new System.EventHandler(this.Bsquareroot_MouseLeave);
            // 
            // Bsquare
            // 
            this.Bsquare.BackColor = System.Drawing.Color.Black;
            this.Bsquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bsquare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bsquare.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bsquare.ForeColor = System.Drawing.Color.White;
            this.Bsquare.Location = new System.Drawing.Point(172, 28);
            this.Bsquare.Name = "Bsquare";
            this.Bsquare.Size = new System.Drawing.Size(63, 47);
            this.Bsquare.TabIndex = 18;
            this.Bsquare.Text = "x²";
            this.Bsquare.UseVisualStyleBackColor = false;
            this.Bsquare.Click += new System.EventHandler(this.Bsquare_Click);
            this.Bsquare.MouseEnter += new System.EventHandler(this.Bsquare_MouseEnter);
            this.Bsquare.MouseLeave += new System.EventHandler(this.Bsquare_MouseLeave);
            // 
            // Bdot
            // 
            this.Bdot.BackColor = System.Drawing.Color.Black;
            this.Bdot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bdot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bdot.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdot.ForeColor = System.Drawing.Color.White;
            this.Bdot.Location = new System.Drawing.Point(172, 240);
            this.Bdot.Name = "Bdot";
            this.Bdot.Size = new System.Drawing.Size(63, 47);
            this.Bdot.TabIndex = 17;
            this.Bdot.Text = ",";
            this.Bdot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bdot.UseVisualStyleBackColor = false;
            this.Bdot.Click += new System.EventHandler(this.Bdot_Click);
            this.Bdot.MouseEnter += new System.EventHandler(this.Bdot_MouseEnter);
            this.Bdot.MouseLeave += new System.EventHandler(this.Bdot_MouseLeave);
            // 
            // B0
            // 
            this.B0.BackColor = System.Drawing.Color.Black;
            this.B0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B0.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B0.ForeColor = System.Drawing.Color.White;
            this.B0.Location = new System.Drawing.Point(103, 240);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(63, 47);
            this.B0.TabIndex = 16;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = false;
            this.B0.Click += new System.EventHandler(this.B0_Click);
            this.B0.MouseEnter += new System.EventHandler(this.B0_MouseEnter);
            this.B0.MouseLeave += new System.EventHandler(this.B0_MouseLeave);
            // 
            // Bequals
            // 
            this.Bequals.BackColor = System.Drawing.Color.Black;
            this.Bequals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bequals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bequals.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bequals.ForeColor = System.Drawing.Color.White;
            this.Bequals.Location = new System.Drawing.Point(241, 240);
            this.Bequals.Name = "Bequals";
            this.Bequals.Size = new System.Drawing.Size(63, 47);
            this.Bequals.TabIndex = 15;
            this.Bequals.Text = "=";
            this.Bequals.UseVisualStyleBackColor = false;
            this.Bequals.Click += new System.EventHandler(this.Bequals_Click);
            this.Bequals.MouseEnter += new System.EventHandler(this.Bequals_MouseEnter);
            this.Bequals.MouseLeave += new System.EventHandler(this.Bequals_MouseLeave);
            // 
            // Bmultiply
            // 
            this.Bmultiply.BackColor = System.Drawing.Color.Black;
            this.Bmultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bmultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bmultiply.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bmultiply.ForeColor = System.Drawing.Color.White;
            this.Bmultiply.Location = new System.Drawing.Point(241, 28);
            this.Bmultiply.Name = "Bmultiply";
            this.Bmultiply.Size = new System.Drawing.Size(63, 47);
            this.Bmultiply.TabIndex = 14;
            this.Bmultiply.Text = "×";
            this.Bmultiply.UseVisualStyleBackColor = false;
            this.Bmultiply.Click += new System.EventHandler(this.Bmultiply_Click);
            this.Bmultiply.MouseEnter += new System.EventHandler(this.Bmultiply_MouseEnter);
            this.Bmultiply.MouseLeave += new System.EventHandler(this.Bmultiply_MouseLeave);
            // 
            // Bdivide
            // 
            this.Bdivide.BackColor = System.Drawing.Color.Black;
            this.Bdivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bdivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bdivide.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdivide.ForeColor = System.Drawing.Color.White;
            this.Bdivide.Location = new System.Drawing.Point(241, 187);
            this.Bdivide.Name = "Bdivide";
            this.Bdivide.Size = new System.Drawing.Size(63, 47);
            this.Bdivide.TabIndex = 13;
            this.Bdivide.Text = "÷";
            this.Bdivide.UseVisualStyleBackColor = false;
            this.Bdivide.Click += new System.EventHandler(this.Bdivide_Click);
            this.Bdivide.MouseEnter += new System.EventHandler(this.Bdivide_MouseEnter);
            this.Bdivide.MouseLeave += new System.EventHandler(this.Bdivide_MouseLeave);
            // 
            // Bminus
            // 
            this.Bminus.BackColor = System.Drawing.Color.Black;
            this.Bminus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bminus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bminus.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bminus.ForeColor = System.Drawing.Color.White;
            this.Bminus.Location = new System.Drawing.Point(241, 134);
            this.Bminus.Name = "Bminus";
            this.Bminus.Size = new System.Drawing.Size(63, 47);
            this.Bminus.TabIndex = 12;
            this.Bminus.Text = "-";
            this.Bminus.UseVisualStyleBackColor = false;
            this.Bminus.Click += new System.EventHandler(this.Bminus_Click);
            this.Bminus.MouseEnter += new System.EventHandler(this.Bminus_MouseEnter);
            this.Bminus.MouseLeave += new System.EventHandler(this.Bminus_MouseLeave);
            // 
            // Badd
            // 
            this.Badd.BackColor = System.Drawing.Color.Black;
            this.Badd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Badd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Badd.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Badd.ForeColor = System.Drawing.Color.White;
            this.Badd.Location = new System.Drawing.Point(241, 81);
            this.Badd.Name = "Badd";
            this.Badd.Size = new System.Drawing.Size(63, 47);
            this.Badd.TabIndex = 11;
            this.Badd.Text = "+";
            this.Badd.UseVisualStyleBackColor = false;
            this.Badd.Click += new System.EventHandler(this.Badd_Click);
            this.Badd.MouseEnter += new System.EventHandler(this.Badd_MouseEnter);
            this.Badd.MouseLeave += new System.EventHandler(this.Badd_MouseLeave);
            // 
            // Bbackspace
            // 
            this.Bbackspace.BackColor = System.Drawing.Color.Black;
            this.Bbackspace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bbackspace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bbackspace.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bbackspace.ForeColor = System.Drawing.Color.White;
            this.Bbackspace.Location = new System.Drawing.Point(103, 28);
            this.Bbackspace.Name = "Bbackspace";
            this.Bbackspace.Size = new System.Drawing.Size(63, 47);
            this.Bbackspace.TabIndex = 10;
            this.Bbackspace.Text = "←";
            this.Bbackspace.UseVisualStyleBackColor = false;
            this.Bbackspace.Click += new System.EventHandler(this.Bbackspace_Click);
            this.Bbackspace.MouseEnter += new System.EventHandler(this.Bbackspace_MouseEnter);
            this.Bbackspace.MouseLeave += new System.EventHandler(this.Bbackspace_MouseLeave);
            // 
            // B9
            // 
            this.B9.BackColor = System.Drawing.Color.Black;
            this.B9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B9.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B9.ForeColor = System.Drawing.Color.White;
            this.B9.Location = new System.Drawing.Point(172, 81);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(63, 47);
            this.B9.TabIndex = 9;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = false;
            this.B9.Click += new System.EventHandler(this.B9_Click);
            this.B9.MouseEnter += new System.EventHandler(this.B9_MouseEnter);
            this.B9.MouseLeave += new System.EventHandler(this.B9_MouseLeave);
            // 
            // B8
            // 
            this.B8.BackColor = System.Drawing.Color.Black;
            this.B8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B8.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B8.ForeColor = System.Drawing.Color.White;
            this.B8.Location = new System.Drawing.Point(103, 81);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(63, 47);
            this.B8.TabIndex = 8;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = false;
            this.B8.Click += new System.EventHandler(this.B8_Click);
            this.B8.MouseEnter += new System.EventHandler(this.B8_MouseEnter);
            this.B8.MouseLeave += new System.EventHandler(this.B8_MouseLeave);
            // 
            // B7
            // 
            this.B7.BackColor = System.Drawing.Color.Black;
            this.B7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B7.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B7.ForeColor = System.Drawing.Color.White;
            this.B7.Location = new System.Drawing.Point(34, 81);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(63, 47);
            this.B7.TabIndex = 7;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = false;
            this.B7.Click += new System.EventHandler(this.B7_Click);
            this.B7.MouseEnter += new System.EventHandler(this.B7_MouseEnter);
            this.B7.MouseLeave += new System.EventHandler(this.B7_MouseLeave);
            // 
            // B6
            // 
            this.B6.BackColor = System.Drawing.Color.Black;
            this.B6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B6.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B6.ForeColor = System.Drawing.Color.White;
            this.B6.Location = new System.Drawing.Point(172, 134);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(63, 47);
            this.B6.TabIndex = 6;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = false;
            this.B6.Click += new System.EventHandler(this.B6_Click);
            this.B6.MouseEnter += new System.EventHandler(this.B6_MouseEnter);
            this.B6.MouseLeave += new System.EventHandler(this.B6_MouseLeave);
            // 
            // B5
            // 
            this.B5.BackColor = System.Drawing.Color.Black;
            this.B5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B5.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B5.ForeColor = System.Drawing.Color.White;
            this.B5.Location = new System.Drawing.Point(103, 134);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(63, 47);
            this.B5.TabIndex = 5;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = false;
            this.B5.Click += new System.EventHandler(this.B5_Click);
            this.B5.MouseLeave += new System.EventHandler(this.B5_MouseLeave);
            this.B5.MouseHover += new System.EventHandler(this.B5_MouseHover);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.Black;
            this.B3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.ForeColor = System.Drawing.Color.White;
            this.B3.Location = new System.Drawing.Point(172, 187);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(63, 47);
            this.B3.TabIndex = 4;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            this.B3.MouseEnter += new System.EventHandler(this.B3_MouseEnter);
            this.B3.MouseLeave += new System.EventHandler(this.B3_MouseLeave);
            // 
            // B4
            // 
            this.B4.BackColor = System.Drawing.Color.Black;
            this.B4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B4.ForeColor = System.Drawing.Color.White;
            this.B4.Location = new System.Drawing.Point(34, 134);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(63, 47);
            this.B4.TabIndex = 3;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = false;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            this.B4.MouseEnter += new System.EventHandler(this.B4_MouseEnter);
            this.B4.MouseLeave += new System.EventHandler(this.B4_MouseLeave);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.Black;
            this.B2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.ForeColor = System.Drawing.Color.White;
            this.B2.Location = new System.Drawing.Point(103, 187);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(63, 47);
            this.B2.TabIndex = 2;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            this.B2.MouseEnter += new System.EventHandler(this.B2_MouseEnter);
            this.B2.MouseLeave += new System.EventHandler(this.B2_MouseLeave);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Black;
            this.B1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.ForeColor = System.Drawing.Color.White;
            this.B1.Location = new System.Drawing.Point(34, 187);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(63, 47);
            this.B1.TabIndex = 1;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            this.B1.MouseEnter += new System.EventHandler(this.B1_MouseEnter);
            this.B1.MouseLeave += new System.EventHandler(this.B1_MouseLeave);
            // 
            // Bclear
            // 
            this.Bclear.BackColor = System.Drawing.Color.Black;
            this.Bclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bclear.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bclear.ForeColor = System.Drawing.Color.White;
            this.Bclear.Location = new System.Drawing.Point(34, 28);
            this.Bclear.Name = "Bclear";
            this.Bclear.Size = new System.Drawing.Size(63, 47);
            this.Bclear.TabIndex = 0;
            this.Bclear.Text = "C";
            this.Bclear.UseVisualStyleBackColor = false;
            this.Bclear.Click += new System.EventHandler(this.Bclear_Click);
            this.Bclear.MouseEnter += new System.EventHandler(this.Bclear_MouseEnter);
            this.Bclear.MouseLeave += new System.EventHandler(this.Bclear_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(333, 447);
            this.Controls.Add(this.Buttons_panel);
            this.Controls.Add(this.Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Result.ResumeLayout(false);
            this.Buttons_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Result;
        private System.Windows.Forms.Label Lscore;
        private System.Windows.Forms.Panel Buttons_panel;
        private System.Windows.Forms.Button Bequals;
        private System.Windows.Forms.Button Bmultiply;
        private System.Windows.Forms.Button Bdivide;
        private System.Windows.Forms.Button Bminus;
        private System.Windows.Forms.Button Badd;
        private System.Windows.Forms.Button Bbackspace;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button Bclear;
        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Button Bdot;
        private System.Windows.Forms.Button Bsquare;
        private System.Windows.Forms.Button Bsquareroot;
    }
}

