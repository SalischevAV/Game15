using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game15
{
    public partial class FormGame15 : Form
    {
        private Game _game;
        private List<Button> buttonsOnForm = new List<Button>();
        public FormGame15()
        {
            InitializeComponent();
            InitializeBattonsArray();
            _game = new Game(4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt32(((Button)sender).Tag);
            _game.Shift(position);
            Refresh();
            if (_game.ChekToWin())
            {
                MessageBox.Show("Ура! Победа!");
                GameStart();
            }
           
        }

  
        private void FormGame15_Load(object sender, EventArgs e)
        {
            GameStart();
        }

        private void menuStart_Click(object sender, EventArgs e)
        {
            GameStart();
        }


        private void GameStart()
        {
            _game.Start();
            for (int i = 0; i < 100; i++)
                _game.ShiftRandom();
            Refresh();
        }

        private void Refresh()
        {

            for (int position = 0; position < 16; position++)
            {
                int nr = _game.GetNumber(position);
                buttonsOnForm[position].Text = nr.ToString();
                buttonsOnForm[position].Visible = (nr > 0);
            }
        }

        private void InitializeBattonsArray()
        {

            buttonsOnForm.Add(button0);
            buttonsOnForm.Add(button1);
            buttonsOnForm.Add(button2);
            buttonsOnForm.Add(button3);
            buttonsOnForm.Add(button4);
            buttonsOnForm.Add(button5);
            buttonsOnForm.Add(button6);
            buttonsOnForm.Add(button7);
            buttonsOnForm.Add(button8);
            buttonsOnForm.Add(button9);
            buttonsOnForm.Add(button10);
            buttonsOnForm.Add(button11);
            buttonsOnForm.Add(button12);
            buttonsOnForm.Add(button13);
            buttonsOnForm.Add(button14);
            buttonsOnForm.Add(button15);
        }


    }
}
