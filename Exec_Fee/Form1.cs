using System.Reflection.Metadata.Ecma335;

namespace Exec_Fee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "計算車資";

            ageTextBox.MaxLength = 3;

            resultLabel.Text = String.Empty;
            resultLabel.Font = new Font("標楷體", 12, FontStyle.Bold);
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // 取得年齡
            int age = 0;
            try { age = GetAge(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            // 判斷男女
            bool gender = false;
			try { gender = GetGender(); }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}


            // 根據客戶性別及年齡計算應付車資
            var result = GatFee(age, gender); 
            
            // 呈現結果
            resultLabel.Text = result.ToString();
        }
        /// <summary>
        /// 依年齡性別計算車資
        /// </summary>
        /// <param name="age">年齡</param>
        /// <param name="gender">性別</param>
        /// <returns></returns>
        private object GatFee(int age, bool gender)
        {
            /* 規則如下:
             * - <=3 零元
             * - >=70, 男, 2元
             * - >=60, 女, 3元
             * - 全票, 15元*/
            decimal fare = 0,
                aldultFee = 15, oldManFee = 2, oldWomanFee = 3;
            int oldManAge = 70, oldWomanAge = 60, kidAge = 3;
			string reason = string.Empty; // 原因

			if (age >= oldManAge && gender == true)
			{
				fare = oldManFee;
				reason = $"超過{oldManAge}歲男性";
			}
			else if (age >= oldWomanAge && gender == false)
			{
				fare = oldWomanFee;
				reason = $"超過{oldWomanAge}歲女性";
			}
			else if (age <= kidAge)
			{
				fare = 0;
				reason = $"年齡沒有滿{kidAge}歲";
			}
			else
			{
				fare = aldultFee;
				if (gender == true)
				{ reason = $"年齡超過{kidAge}歲，\n且沒有滿{oldManAge}歲"; }
				else
				{ reason = $"年齡超過{kidAge}歲，\n且沒有滿{oldWomanAge}歲"; }
			}
            return $"車資: {fare}\r\n" +
               $"原因: \r\n{reason}";
		}

        private bool GetGender()
        {
            // 如果沒有選擇
            if (manRadioButton.Checked == false
                && womanRadioButton.Checked == false)
            { throw new Exception("請選擇性別");
            }
            // 選擇男女
            return (manRadioButton.Checked == true)
                ? true : false;
        }

        private int GetAge()
        {
            string input = ageTextBox.Text;
            bool isint = int.TryParse(input, out int value);

            return (isint && value > 0) ? value 
                : throw new Exception("請輸入年齡，年齡為正整數");
        }
    }
}