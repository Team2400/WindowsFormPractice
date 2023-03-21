using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPractice
{
    public partial class Form1 : Form
    {
        public enum ComboBoxParseCase
        {
            None,
            Year,
            Month,
            Day,
            Combine
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;

            for (int i = localDate.Year - 100; i <= localDate.Year - 1; i++)
            {
                cmbYear.Items.Add(i);
            }

            for (int i = 1; i <= 12; i++)
            {
                cmbMonth.Items.Add(i);
            }

            // [TODO] 날짜 선택지를 앞의 년, 월 에 따라 유효한 값들로만 채울 수 없을까?
            for (int i = 1; i <= 31; i++)
            {
                cmbDay.Items.Add(i);
            }

            /*
             * 원본 코드: cmbYear.SelectedIndex = cmbYear.Items.Count - 1;
             * 원본 코드는 event handler 인 cmb_ItemOrTextChanged 처음 한 번 실행 시키기 위해 존재한다.
             * 그러나 년도만 값이 배정되어 있는것이 부자연스럽다고 생각됨.
             * 따라서 인위적으로 event Handler 만 호출하여 년도를 default 상태로 다른 값과 통일 시키는 방향으로 수정하였음.
             */
            cmb_ItemOrTextChanged(null, null);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtNote.SelectAll();
            txtNote.Focus();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtNote.SelectedText);
        }

        private void rdoDotum_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(rdoDotum.Text, txtNote.Font.Size, txtNote.Font.Style);
            txtNote.Font = f;
        }

        private void rdoGulim_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(rdoGulim.Text, txtNote.Font.Size, txtNote.Font.Style);
            txtNote.Font = f;
        }

        private void rdoGungsuh_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(rdoGungsuh.Text, txtNote.Font.Size, txtNote.Font.Style);
            txtNote.Font = f;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(txtNote.Font.FontFamily, txtNote.Font.Size, FontStyle.Bold ^ txtNote.Font.Style);
            txtNote.Font = f;
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(txtNote.Font.FontFamily, txtNote.Font.Size, FontStyle.Underline ^ txtNote.Font.Style);
            txtNote.Font = f;
        }

        private void checkItalic_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(txtNote.Font.FontFamily, txtNote.Font.Size, FontStyle.Italic ^ txtNote.Font.Style);
            txtNote.Font = f;
        }

        private void btnListToChecked_Click(object sender, EventArgs e)
        {
            if (lstLanguages.SelectedItem != null)
            {
                cklLanguages.Items.Add(lstLanguages.SelectedItem, false);
                lstLanguages.Items.Remove(lstLanguages.SelectedItem);
            }
        }

        private void btnCheckedToList_Click(object sender, EventArgs e)
        {
            while (cklLanguages.CheckedItems.Count > 0)
            {
                string item = (string)cklLanguages.CheckedItems[0];
                lstLanguages.Items.Add(item);
                cklLanguages.Items.Remove(item);
            }
        }

        private void btnChecedToTextBox_Click(object sender, EventArgs e)
        {
            foreach (string item in cklLanguages.CheckedItems)
            {
                txtNote2.Text += item + "\r\n";
            }
        }

        private void cmb_ItemOrTextChanged(object sender, EventArgs e)
        {
            switch (GetComboBoxParseCase())
            {
                case ComboBoxParseCase.Year:
                    lblToggle.Text = "태어난 년도를 입력하세요.";
                    break;
                case ComboBoxParseCase.Month:
                    lblToggle.Text = "태어난 월을 입력하세요";
                    break;
                case ComboBoxParseCase.Day:
                    lblToggle.Text = "태어난 일(날짜)를 입력하세요";
                    break;
                case ComboBoxParseCase.None:
                    lblToggle.Text = "";
                    break;
                default:
                    // araise exception
                    break;
            }
        }

        private ComboBoxParseCase GetComboBoxParseCase()
        {
            if (cmbYear.SelectedItem == null)
            {
                return ComboBoxParseCase.Year;
            }
            else if (cmbMonth.SelectedItem == null)
            {
                return ComboBoxParseCase.Month;
            }
            else if (cmbDay.SelectedItem == null)
            {
                return ComboBoxParseCase.Day;
            }
            else if (!IsDate((int)cmbYear.SelectedItem, (int)cmbMonth.SelectedItem, (int)cmbDay.SelectedItem))
            {
                return ComboBoxParseCase.Combine;
            }
            else
            {
                return ComboBoxParseCase.None;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (GetComboBoxParseCase() != ComboBoxParseCase.None)
            { 
                return; 
            }
            txtNote3.Clear();

            int year = (int)cmbYear.SelectedItem;
            int month = (int)cmbMonth.SelectedItem;
            int day = (int)cmbDay.SelectedItem;

            DateTime BirthDay = new DateTime(year, month, day);
            DateTime CurrentDate = DateTime.Now;
            txtNote3.Text += "세는 나이 : " + (CurrentDate.Year - BirthDay.Year + 1).ToString() + "\r\n";

            int age = CurrentDate.Year - BirthDay.Year;
            if (CurrentDate.Month < BirthDay.Month)
            {
                age -= 1;
            } else if (CurrentDate.Month == BirthDay.Month && CurrentDate.Day < BirthDay.Day)
            {
                age -= 1;
            }
            txtNote3.Text += "만나이: " + age.ToString() + "\r\n";
        }

        public bool IsDate(int year, int month, int day)
        {
            return year > 0 && month > 0 && month <= 12 && day > 0 && day <= DateTime.DaysInMonth(year, month);
        }
    }
}

