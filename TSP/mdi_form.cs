/* главная форма программы;
 * возможно открытие файла даных;
 * сохранение файла данных;
 * создание нового файла данных;
 * проведение дисперсионного анализа;
 * проведение анализа ТСП;
 * проведенеие анализа соответствий;
 * вызов справки;
 * вызов окна "о программе..."
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Ocenka_mer_svyzei
{
    public partial class mdi_form : Form
    {            
        public mdi_form()
        {
            InitializeComponent();   
        }

        newdata data_frm;

        private void определитьПрименимыйМетодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Analysis analysis_frm = new Analysis();
            analysis_frm.MdiParent = this;
            analysis_frm.Show();
        }

        private void бисериальныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bs bs_frm = new bs();
            bs_frm.MdiParent = this;
            bs_frm.Show();
        }

        private void ранговобисериальныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbs rbs_frm = new rbs();
            rbs_frm.MdiParent = this;
            rbs_frm.Show();
        }       

        private void тетрахорическийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tetra tetra_frm = new tetra();
            tetra_frm.MdiParent = this;
            tetra_frm.Show();
        }

        private void точечнобисериальныToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tbs tbs_frm = new tbs();
            tbs_frm.MdiParent = this;
            tbs_frm.Show();
        }
                
        private void Help_MenuItem_Click(object sender, EventArgs e)
        {
            // форма со справкой
            help_form help_frm = new help_form();
            help_frm.MdiParent = this;
            help_frm.Show();
        }

        private void About_MenuItem_Click(object sender, EventArgs e)
        {
            // форма "о программе..."
            about_form about_frm = new about_form();
            about_frm.MdiParent = this;
            about_frm.Show();
        }

        private void New_MenuItem_Click(object sender, EventArgs e)
        {
            // создание файла данных
            try
            {
                data_frm = new newdata();
                data_frm.MdiParent = this;     
                data_frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Exit_MenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TSP_MenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                diagram1 data_frm = new diagram1();                    
                data_frm.MdiParent = this;
                data_frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void произведениеМоментовПирсонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PearsonFrm pearsFrm = new PearsonFrm();
            pearsFrm.MdiParent = this;
            pearsFrm.Show();
        }

        private void спирменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpearmanFrm spearmFrm = new SpearmanFrm();
            spearmFrm.MdiParent = this;
            spearmFrm.Show();
        }
    }
}