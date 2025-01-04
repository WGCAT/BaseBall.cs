using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace BaseBall
{
    public partial class Form1 : Form
    {
        int num1 = 10;
        int num2 = 10;
        int num3 = 10;

        int Cnt = 0;
        int win = 0;
        int lose = 0;

        int[] inputArr = new int[3] { 10, 10, 10 };
        int[] randomArr = new int[3] { 10, 10, 10 };

        int strike = 0;
        int ball = 0;

        string answer = "";
        bool start = false;
        bool game = false;

        public Form1()
        {
            InitializeComponent();

            lblBall.Text = "";
            lblStrike.Text = "";
            lblTest.Text = "";
            
        }

        




        private void btnGeneration_Click(object sender, EventArgs e)
        {

            lblBall.Text = "";
            lbxHistory.Items.Clear();
            lbxSB.Items.Clear();
            lblTest.Text = win.ToString() + "승" + lose.ToString() + "패";

            Random random = new Random();
            

            for (int i = 0; i < randomArr.Length; i++)
            {
                int num = random.Next(0, 10);

                if (randomArr.Contains(num))
                {
                    num = random.Next(0, 10);
                    i--;
                }
                else
                {
                    randomArr[i] = num;
                }
            }

            answer = string.Concat(randomArr);

            start = true;
            lblBool.Text = "Game Start!!";
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string SB = "";
            strike = 0;
            ball = 0;

            // 첫번째 텍스트박스
            if (tbNum1 != null)
            {
                num1 = int.Parse(tbNum1.Text);
                if (num1 >= 0 && num1 < 10)
                {
                    game = true;
                    inputArr[0] = num1;
                }
                else
                {
                    game = false;
                }
            }
            else
            {
                game = false;
            }

            // 두번째 텍스트박스
            if (tbNum2 != null)
            {
                num2 = int.Parse(tbNum2.Text);
                if (num2 >= 0 && num2 < 10)
                {
                    game = true;
                    inputArr[1] = num2;
                }
                else
                {
                    game = false;
                }
            }
            else
            {
                game = false;
            }

            // 세번째 텍스트박스
            if (tbNum3 != null)
            {
                num3 = int.Parse(tbNum3.Text);
                if (num3 >= 0 && num3 < 10)
                {
                    game = true;
                    inputArr[2] = num3;
                }
                else
                {
                    game = false;
                }
            }
            else
            {
                game = false;
            }

            // 중복 탐색
            for (int i = 0; i < inputArr.Length; i++)
            {
                for (int j = i+1; j < inputArr.Length; j++)
                {
                    if (inputArr[i] == inputArr[j])
                    {
                        game = false;
                        break;
                    }
                }
            }

            if (start && game)
            {
                // 볼 탐색
                for (int i = 0; i < inputArr.Length; i++)
                {
                    if (randomArr.Contains(inputArr[i]))
                    {
                        if(inputArr[i] != randomArr[i])
                        {
                        ball++;
                        }
                    }           
                }

                // 스트라이크 탐색
                for (int i = 0;i < inputArr.Length; i++)
                {
                    if (inputArr[i] == randomArr[i])
                    {
                        strike++;                  
                    }
                }

                SB = strike.ToString() + "/" + ball.ToString();

                // 볼 스트라이크 텍스트 표시
                lbxHistory.Items.Add(string.Concat(inputArr));
                lbxSB.Items.Add(SB);
                lblStrike.Text = strike.ToString();
                lblBall.Text = ball.ToString();
                Cnt++;
            }
            else if (!start)
            {
                MessageBox.Show("시작을 먼저 눌러주세요!!");
            }
            else if (!game)
            {
                MessageBox.Show("숫자를 정확히 입력해주세요!!\n(중복불가, 숫자범위 : 0~9)");
            }

            // 승리/패배 조건
            if (strike == 3)
            {
                win++;
                MessageBox.Show("승리!!\n재경기를 원하시면 시작버튼을 누르세요");
                lblBool.Text = "재경기 ㄱㄱ";
            }

            if (Cnt == 10)
            {
                lose++;
                MessageBox.Show("패배!!\n재경기를 원하시면 시작버튼을 누르세요");
                lblBool.Text = "재경기 ㄱㄱ";
            }


        }
    }
}
