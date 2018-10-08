namespace binary_tree
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tablo = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.Value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tablo
            // 
            this.Tablo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tablo.Location = new System.Drawing.Point(12, 12);
            this.Tablo.Name = "Tablo";
            this.Tablo.Size = new System.Drawing.Size(480, 436);
            this.Tablo.TabIndex = 3;
            this.Tablo.TabStop = false;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.print);
            this.panel.Controls.Add(this.del);
            this.panel.Controls.Add(this.add);
            this.panel.Controls.Add(this.Value);
            this.panel.Location = new System.Drawing.Point(498, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(173, 436);
            this.panel.TabIndex = 4;
            this.panel.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите значение:";
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(6, 164);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(161, 23);
            this.print.TabIndex = 3;
            this.print.Text = "Обновить";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(95, 128);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(72, 23);
            this.del.TabIndex = 2;
            this.del.Text = "Удалить";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(6, 128);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(72, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(6, 89);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(161, 20);
            this.Value.TabIndex = 0;
            this.Value.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Value_KeyDown);
            this.Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Value_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Колескин";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 460);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Tablo);
            this.Name = "Form1";
            this.Text = "Бинарное Дерево";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Tablo;
        private System.Windows.Forms.GroupBox panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Label label2;
    }
}

