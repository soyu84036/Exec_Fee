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
            /* 規則如下:
             * - <=3 零元
             * - >=70, 男, 2元
             * - >=60, 女, 3元
             * - 全票, 15元*/

            decimal aldult = 15,
                oldMan = 70, oldWoman = 3;
            decimal fare = 0;
            string reason = string.Empty; // 原因

            if (age >= 70 && gender == true)
            {
                fare = oldMan;
                reason = "超過七十歲男性";            
            }
            else if (age >= 60 && gender == false)
            { 
                fare = oldWoman;
                reason = "超過六十歲女性";
			}
			else if (age <= 3)
            { 
                fare = 0;
				reason = "年齡沒有滿三歲";
			}
            else 
            { 
                fare = aldult;
                if (gender == true)
                { reason = "年齡超過三歲，\n且沒有滿七十歲"; }
                else 
                { reason = "年齡超過三歲，\n且沒有滿六十歲"; }
			}

            // 呈現結果
            resultLabel.Text = $"車資: {fare}\r\n" +
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