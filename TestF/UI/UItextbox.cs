using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestF.UI
{
    [DefaultEvent("_TextChanged")]
    public partial class UItextbox : UserControl
    {
        //שדות
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor= Color.HotPink;
        private bool isFocused =false;

        //ctor
        public UItextbox(){InitializeComponent();}
        //Events
        public event EventHandler _TextChanged;

        //--------  Style -- overlead
        [Category("Doron Style")]
        public Color BorderColor { get => borderColor; set{borderColor = value; this.Invalidate();}}
        [Category("Doron Style")]
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        [Category("Doron Style")]
        public bool UnderlinedStyle 
        { get => underlinedStyle; set { underlinedStyle = value; this.Invalidate(); } }
        [Category("Doron Style")]
        public bool PasswordChar
        { get => textBox1.UseSystemPasswordChar;set=> textBox1.UseSystemPasswordChar = value; }
        [Category("Doron Style")]
        public bool Multiline
        { get => textBox1.Multiline; set => textBox1.Multiline = value; }
        [Category("Doron Style")]
        public override Color BackColor
        { get => base.BackColor; set { base.BackColor = value; textBox1.BackColor = value; } }
        [Category("Doron Style")]
        public override Color ForeColor
        { get => base.ForeColor; set { base.ForeColor = value;textBox1.ForeColor = value; } }
        [Category("Doron Style")]
        public override Font Font
        { get => base.Font; set { base.Font = value;textBox1.Font = value;if (this.DesignMode) UpdateControlHeight(); } }
        [Category("Doron Style")]
        public  string Texts
        { get => textBox1.Text; set => textBox1.Text = value; }
        [Category("Doron Style")]
        public Color BorderFocusColor
        { get => borderFocusColor; set => borderFocusColor = value; }
        

        //**** overridden Method
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            // Draw border
            using(Pen penBorder=new Pen(borderColor, borderSize)) {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                
                if(!isFocused)
                {
                    if(underlinedStyle)
                        graph.DrawLine(penBorder,0,this.Height-1,this.Width,this.Height-1);
                    else
                        graph.DrawLine(penBorder,0,0,this.Width-0.5F,this.Height-0.5F);
                }
                else
                {
                    penBorder.Color = borderFocusColor;
                    if (underlinedStyle)
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawLine(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }

                if (underlinedStyle)
                    graph.DrawLine(penBorder, 0, this.Height-1, this.Width,this.Height-1);
                else
                    graph.DrawRectangle(penBorder,0,0,this.Width -0.5F,this.Height-0.5F);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {if(_TextChanged != null) _TextChanged.Invoke(sender, e);}

        private void textBox1_Click(object sender, EventArgs e){this.OnClick(e);}

        private void textBox1_MouseEnter(object sender, EventArgs e){this.OnMouseEnter(e);}

        private void textBox1_MouseLeave(object sender, EventArgs e){this.OnMouseLeave(e);}

        public void Clear() { this.textBox1.Clear(); }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e){this.OnKeyPress(e);}

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }
    }
}
