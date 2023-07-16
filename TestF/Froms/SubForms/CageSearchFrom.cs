using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestF.Forms.SubForms.Info_forms;

namespace TestF.forms
{
    public partial class CageSearchFrom : Form

    {
        //TODO: זה דף החיפוש כלוב

        /* ********** אפשרות חיפוש כלוב לפי מספר סידורי / חומר כל מצב בנפרד ***********
         * 
         * 1. במקרה של תוצאה אחת – להציג את הכלוב
         * 
         * 2. במקרה של מספר תוצאות – להציג רשימה ממוינת לפי מספר כלוב
         *      2.1 (במסך הצגת הכלוב יופיעו פרטי הכלוב ורשימה של הציפורים שנמצאים בו (לפי מספר סידורי
         * 
         * 3. במקרה של לחיצה על כלוב ספציפי בטבלה נעבור לדף הספציפי שלו
         */

        private MianFrom fatherFrom;

        //ctor
        public CageSearchFrom(MianFrom main)
        {
            InitializeComponent();
            fatherFrom = main;
        }

        //----------------כפתורי חיפוש----------------------------
        private void Search_Click(object sender, EventArgs e)
        {
            if (cageNumber.Texts == "מספר כלוב" && sexBirdBox.Texts == "             חומר הכלוב")
            {
                CageDataSetFrom from = new CageDataSetFrom(fatherFrom, this);
                from.ShowDialog();
            }
            else
            {
                CageDataSetFrom from = new CageDataSetFrom(fatherFrom, this, cageNumber.Texts, sexBirdBox.Texts);
                from.ShowDialog();
            }
        }
        //---------- כפתור זמני למעבר למקרה ספציפי של מציאת ציפור ספציפית ------------

        //----- ניקוי תבות-----
        private void cageNumber_Click(object sender, EventArgs e)
        {
            if (cageNumber.Texts == "מספר כלוב")
                cageNumber.Texts = String.Empty;
        }

        private void cageNumber_Leave(object sender, EventArgs e)
        {
            if (cageNumber.Texts == "")
                cageNumber.Texts = "מספר כלוב";
        }

        private void cageNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
