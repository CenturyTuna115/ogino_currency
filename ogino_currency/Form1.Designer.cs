using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace ogino_currency
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TitleLBL = new Label();
            amountlbl = new Label();
            fromLBL = new Label();
            toLBL = new Label();
            amounttext = new TextBox();
            fromCurrencyBox = new ComboBox();
            toCurrencybox = new ComboBox();
            convertBTN = new Button();
            label1 = new Label();
            label2 = new Label();
            convertedtxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            onlylabel = new Label();
            CurrentRatetxtbox = new TextBox();
            SuspendLayout();
            // 
            // TitleLBL
            // 
            TitleLBL.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLBL.ForeColor = Color.DarkGreen;
            TitleLBL.Location = new Point(70, 9);
            TitleLBL.Name = "TitleLBL";
            TitleLBL.Size = new Size(555, 82);
            TitleLBL.TabIndex = 0;
            TitleLBL.Text = "Maya Currency Converter";
            TitleLBL.TextAlign = ContentAlignment.TopCenter;
            // 
            // amountlbl
            // 
            amountlbl.AutoSize = true;
            amountlbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountlbl.ForeColor = Color.DarkSlateGray;
            amountlbl.Location = new Point(70, 104);
            amountlbl.Name = "amountlbl";
            amountlbl.Size = new Size(140, 20);
            amountlbl.TabIndex = 1;
            amountlbl.Text = "Amount to Convert";
            // 
            // fromLBL
            // 
            fromLBL.AutoSize = true;
            fromLBL.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            fromLBL.ForeColor = Color.DarkSlateGray;
            fromLBL.Location = new Point(90, 168);
            fromLBL.Name = "fromLBL";
            fromLBL.Size = new Size(111, 20);
            fromLBL.TabIndex = 2;
            fromLBL.Text = "From Currency";
            // 
            // toLBL
            // 
            toLBL.AutoSize = true;
            toLBL.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            toLBL.ForeColor = Color.DarkSlateGray;
            toLBL.Location = new Point(103, 234);
            toLBL.Name = "toLBL";
            toLBL.Size = new Size(91, 20);
            toLBL.TabIndex = 3;
            toLBL.Text = "To Currency";
            // 
            // amounttext
            // 
            amounttext.Location = new Point(222, 101);
            amounttext.Multiline = true;
            amounttext.Name = "amounttext";
            amounttext.Size = new Size(221, 28);
            amounttext.TabIndex = 4;
            amounttext.KeyPress += amounttext_KeyPress;
            // 
            // fromCurrencyBox
            // 
            fromCurrencyBox.FormattingEnabled = true;
            fromCurrencyBox.Location = new Point(222, 165);
            fromCurrencyBox.Name = "fromCurrencyBox";
            fromCurrencyBox.Size = new Size(221, 28);
            fromCurrencyBox.TabIndex = 5;
            fromCurrencyBox.SelectedIndexChanged += fromCurrencyBox_SelectedIndexChanged;
            // 
            // toCurrencybox
            // 
            toCurrencybox.FormattingEnabled = true;
            toCurrencybox.Location = new Point(222, 234);
            toCurrencybox.Name = "toCurrencybox";
            toCurrencybox.Size = new Size(221, 28);
            toCurrencybox.TabIndex = 6;
            toCurrencybox.SelectedIndexChanged += toCurrencybox_SelectedIndexChanged;
            // 
            // convertBTN
            // 
            convertBTN.BackColor = Color.FromArgb(255, 255, 192);
            convertBTN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            convertBTN.ForeColor = Color.DarkSlateGray;
            convertBTN.Location = new Point(222, 302);
            convertBTN.Name = "convertBTN";
            convertBTN.Size = new Size(221, 52);
            convertBTN.TabIndex = 7;
            convertBTN.Text = "Convert";
            convertBTN.UseVisualStyleBackColor = false;
            convertBTN.Click += convertBTN_Click;
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(497, 287);
            label1.Name = "label1";
            label1.Size = new Size(301, 212);
            label1.TabIndex = 8;
            // 
            // label2
            // 
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(664, 253);
            label2.Name = "label2";
            label2.Size = new Size(134, 101);
            label2.TabIndex = 9;
            // 
            // convertedtxt
            // 
            convertedtxt.Location = new Point(222, 383);
            convertedtxt.Name = "convertedtxt";
            convertedtxt.Size = new Size(221, 27);
            convertedtxt.TabIndex = 10;
            convertedtxt.ReadOnlyChanged += convertedtxt_ReadOnlyChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(144, 390);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 11;
            label3.Text = "Result";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 12;
            label4.Text = "label4";
            // 
            // onlylabel
            // 
            onlylabel.AutoSize = true;
            onlylabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            onlylabel.ForeColor = Color.DarkSlateGray;
            onlylabel.Location = new Point(549, 101);
            onlylabel.Name = "onlylabel";
            onlylabel.Size = new Size(165, 20);
            onlylabel.TabIndex = 13;
            onlylabel.Text = "Current Exchange Rate";
            // 
            // CurrentRatetxtbox
            // 
            CurrentRatetxtbox.Location = new Point(549, 141);
            CurrentRatetxtbox.Name = "CurrentRatetxtbox";
            CurrentRatetxtbox.Size = new Size(221, 27);
            CurrentRatetxtbox.TabIndex = 14;
            CurrentRatetxtbox.ReadOnlyChanged += CurrentRatetxtbox_ReadOnlyChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 207, 141);
            ClientSize = new Size(810, 499);
            Controls.Add(CurrentRatetxtbox);
            Controls.Add(onlylabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(convertedtxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(convertBTN);
            Controls.Add(toCurrencybox);
            Controls.Add(fromCurrencyBox);
            Controls.Add(amounttext);
            Controls.Add(toLBL);
            Controls.Add(fromLBL);
            Controls.Add(amountlbl);
            Controls.Add(TitleLBL);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLBL;
        private Label amountlbl;
        private Label fromLBL;
        private Label toLBL;
        private TextBox amounttext;
        private ComboBox fromCurrencyBox;
        private ComboBox toCurrencybox;
        private Button convertBTN;
        private Label label1;
        private Label label2;
        private TextBox convertedtxt;
        private Label label3;
        private Label label4;
        private Label onlylabel;
        private TextBox CurrentRatetxtbox;
    }
}
