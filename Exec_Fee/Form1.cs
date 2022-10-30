using System.Reflection.Metadata.Ecma335;

namespace Exec_Fee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "�p�⨮��";

            ageTextBox.MaxLength = 3;

            resultLabel.Text = String.Empty;
            resultLabel.Font = new Font("�з���", 12, FontStyle.Bold);
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // ���o�~��
            int age = 0;
            try { age = GetAge(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            // �P�_�k�k
            bool gender = false;
			try { gender = GetGender(); }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}


            // �ھګȤ�ʧO�Φ~�֭p�����I����
            var result = GatFee(age, gender); 
            
            // �e�{���G
            resultLabel.Text = result.ToString();
        }
        /// <summary>
        /// �̦~�֩ʧO�p�⨮��
        /// </summary>
        /// <param name="age">�~��</param>
        /// <param name="gender">�ʧO</param>
        /// <returns></returns>
        private object GatFee(int age, bool gender)
        {
			/* �W�h�p�U:
             * - <=3 �s��
             * - >=70, �k, 2��
             * - >=60, �k, 3��
             * - ����, 15��*/
			decimal aldultFee = 15,
				oldMan = 70, oldWoman = 3;
			decimal fare = 0;
			string reason = string.Empty; // ��]

			if (age >= oldMan && gender == true)
			{
				fare = oldMan;
				reason = "�W�L�C�Q���k��";
			}
			else if (age >= oldWoman && gender == false)
			{
				fare = oldWoman;
				reason = "�W�L���Q���k��";
			}
			else if (age <= 3)
			{
				fare = 0;
				reason = "�~�֨S�����T��";
			}
			else
			{
				fare = aldultFee;
				if (gender == true)
				{ reason = "�~�ֶW�L�T���A\n�B�S�����C�Q��"; }
				else
				{ reason = "�~�ֶW�L�T���A\n�B�S�������Q��"; }
			}
            return $"����: {fare}\r\n" +
               $"��]: \r\n{reason}";
		}

        private bool GetGender()
        {
            // �p�G�S�����
            if (manRadioButton.Checked == false
                && womanRadioButton.Checked == false)
            { throw new Exception("�п�ܩʧO");
            }
            // ��ܨk�k
            return (manRadioButton.Checked == true)
                ? true : false;
        }

        private int GetAge()
        {
            string input = ageTextBox.Text;
            bool isint = int.TryParse(input, out int value);

            return (isint && value > 0) ? value 
                : throw new Exception("�п�J�~�֡A�~�֬������");
        }
    }
}