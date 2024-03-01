using DiceWarsGame.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceWarsGame
{
    public partial class PlayerListForm : Form
    {
        public PlayerListForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void PlayerListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }

        private void LoadData()
        {
            dgv.DataSource = new PlayerManager().GetAll();
        }
    }
}
