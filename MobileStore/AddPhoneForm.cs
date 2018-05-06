using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStore
{
    public partial class AddPhoneForm : Form
    {
        public AddPhoneForm()
        {
            InitializeComponent();
        }

        private void btn_AddPhone_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tbx_NewModel.Text) & !String.IsNullOrEmpty(tbx_NewOs.Text) & 
                !String.IsNullOrEmpty(tbx_NewProcessor.Text) & !String.IsNullOrEmpty(tbx_NewPrice.Text))
            {
                if(String.IsNullOrEmpty(tbx_Picture.Text)) { tbx_Picture.Text = "NotFound.jpg"; }
                PhoneRepository.AddPhone(new PhoneInfo()
                {
                    Model = tbx_NewModel.Text,
                    OS = tbx_NewOs.Text,
                    Processor = tbx_NewProcessor.Text,
                    Price = Convert.ToDecimal(tbx_NewPrice.Text),
                    Picture = tbx_Picture.Text
                });
            }
            else
            {
                MessageBox.Show("Не все поля заполненны.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Close();
        }
    }
}
