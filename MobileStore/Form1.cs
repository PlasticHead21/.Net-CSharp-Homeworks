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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbx_ListOfPhones.DisplayMember = "Model";
            lbx_ListOfPhones.DataSource = PhoneRepository.GetListOfPhones();
            lbx_ListOfPhones.SelectedIndex = -1;

            chLbx.DataSource = PhoneRepository.GetOptions();
            chLbx.DisplayMember = "OptionName";
        }

        private void lbx_ListOfPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhoneInfo phone = lbx_ListOfPhones.SelectedItem as PhoneInfo;
            if(phone != null)
            {
                
                tbx_Model.Text = phone.Model;
                tbx_OS.Text = phone.OS;
                tbx_Processor.Text = phone.Processor;
                tbx_Price.Text = phone.Price.ToString();
                pictureBox1.Load(phone.Picture);
                ///////////////////////////////////////////
                lbx_Options.DataSource = phone.GetPhoneOptions();
                lbx_Options.DisplayMember = "OptionName";
                ///////////////////////////////////////////
                tbx_ModelR.Text = phone.Model;
                tbx_OSR.Text = phone.OS;
                tbx_ProcessorR.Text = phone.Processor;
                tbx_Picture.Text = phone.Picture;
                tbx_PriceR.Text = phone.Price.ToString();
            }
        }

        private void btn_SaveInFile_Click(object sender, EventArgs e)
        {
            if(lbx_ListOfPhones.Items.Count != 0)
            {
                PhoneRepository.SavePhones();
                MessageBox.Show("Список телефонов был сохранён", "Сохранено");
            }           
        }

        private void btn_LoadFromFile_Click(object sender, EventArgs e)
        { 
            lbx_ListOfPhones.DataSource = PhoneRepository.LoadPhones();
            lbx_ListOfPhones.DisplayMember = "Model";
        }

        private void btn_ClearList_Click(object sender, EventArgs e)
        {
            lbx_ListOfPhones.DataSource = null;
            lbx_ListOfPhones.Items.Clear();
        }

        private void btn_DelPhone_Click(object sender, EventArgs e)
        {
            PhoneInfo phone = lbx_ListOfPhones.SelectedItem as PhoneInfo;
            PhoneRepository.DeletePhone(phone);
        }

        private void btn_AddOption_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tbx_NameOfOption.Text))
            {
                PhoneRepository.AddOption(tbx_NameOfOption.Text); 
            }
            else
            {
                MessageBox.Show("Не введено название добавляемой опции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
            PhoneInfo phone = lbx_ListOfPhones.SelectedItem as PhoneInfo;
            if(phone != null)
            {
                for (int i = 0; i < chLbx.Items.Count; i++)
                {
                    if (chLbx.GetItemChecked(i))
                    {
                        phone.options.Add(chLbx.Items[i] as Option);
                    }
                }

                if(!String.IsNullOrEmpty(tbx_ModelR.Text) & tbx_ModelR.Text != phone.Model)
                {
                    phone.Model = tbx_ModelR.Text; 
                }
                if(!String.IsNullOrEmpty(tbx_OSR.Text) & tbx_OSR.Text != phone.OS)
                {
                    phone.OS = tbx_OSR.Text;
                }
                if(!String.IsNullOrEmpty(tbx_ProcessorR.Text) & tbx_ProcessorR.Text != phone.Processor)
                {
                    phone.Processor = tbx_ProcessorR.Text;
                }
                if(!String.IsNullOrEmpty(tbx_PriceR.Text))
                {
                    phone.Price = Convert.ToDecimal(tbx_PriceR.Text);
                }
                if(!String.IsNullOrEmpty(tbx_Picture.Text) & tbx_Picture.Text != phone.Picture)
                {
                    phone.Picture = tbx_Picture.Text;
                }
                PhoneRepository.phones[lbx_ListOfPhones.SelectedIndex] = phone;
                lbx_ListOfPhones.DataSource = PhoneRepository.GetListOfPhones();
            }           
        }

        private void btn_DeleteOption_Click(object sender, EventArgs e)
        {
            Option removableOption = chLbx.SelectedItem as Option;
            if(removableOption != null)
            {
                PhoneRepository.options.Remove(removableOption);
            }
        }

        private void btn_AddNewPhone_Click(object sender, EventArgs e)
        {
            AddPhoneForm form = new AddPhoneForm();
            form.Show();
            lbx_ListOfPhones.DataSource = PhoneRepository.GetListOfPhones();
        }

        private void btn_ClearField_Click(object sender, EventArgs e)
        {
            chLbx.DataSource = null;
        }
    }
}
