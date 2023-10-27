using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        string JugadorX = ""; 
        string JugadorO = "";
        string[,] tablero = new string[3, 3];
        string TurnoActual = "x";
        bool isplaying = false;
        int empate = 0; 
        public Form1()
        {

            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnOffBtn(false);
        }

        private void OnOffBtn(bool onoff)
        {
            a1.Enabled = onoff;
            a2.Enabled = onoff;
            a3.Enabled = onoff;
            b1.Enabled = onoff;
            b2.Enabled = onoff;
            b3.Enabled = onoff;
            c1.Enabled = onoff;
            c2.Enabled = onoff;
            c3.Enabled = onoff;
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void Ingresar()
        {
            if (txtuserazul.Text == "" && txtuserrojo.Text == "")
            {
                MessageBox.Show("el nombre no debe estar vacio ");
            }
            else
            {
                if (txtuserazul.Text == "")
                    MessageBox.Show("el nombre del jugador azul no debe estar vacio ");
            }
            {
                if (txtuserrojo.Text == "")
                    MessageBox.Show("el nombre del jugador rojo no debe estar vacio ");
            }
            if (txtuserazul.Text != "" && txtuserrojo.Text != "")
            {
                if (xazul.Checked && orojo.Checked)
                {
                    JugadorX = txtuserazul.Text;
                    JugadorO = txtuserrojo.Text;
                    oazul.Enabled = false;
                    xrojo.Enabled = false;
                    PlayGame();
                }
                if (oazul.Checked && xrojo.Checked)
                {
                    JugadorX = txtuserrojo.Text;
                    JugadorO = txtuserazul.Text;
                    xazul.Enabled = false;
                    orojo.Enabled = false;
                    PlayGame();
                }
                if (xazul.Checked && xrojo.Checked)
                {
                    MessageBox.Show("solo un jugador puede seleccionar la letra X ");
                }
                if (oazul.Checked && orojo.Checked)
                {
                    MessageBox.Show("solo un jugador puede seleccionar la letra O ");
                }

                if (xazul.Checked == false && oazul.Checked == false || xrojo.Checked == false && orojo.Checked == false)
                {
                    MessageBox.Show("solo puedes seleccionar una letra ");
                }
            }
        }

        private void PlayGame()
        {
            isplaying = true;
            lbluserazul.Text = txtuserazul.Text;
            lbluserrojo.Text = txtuserrojo.Text;

            groupBox1.Text = "Marcador";

            btnlimpiar.Visible = true;

            btnreiniciar.Visible = true;
            btniniciar.Visible = false;
            txtuserazul.Visible = false;
            txtuserrojo.Visible = false;
            MessageBox.Show("EMPIEZA el " + JugadorX);
            OnOffBtn(true);
        }



        private void marcar(int row, int column, string caract)
        {
            tablero[row, column] = caract;
            ganador();

        }
        private void ganador()
        {
            if (tablero[0, 0] == "x" && tablero[0, 1] == "x" && tablero[0, 2] == "x")
            {
                MessageBox.Show("ganador x");
                isplaying = false;
            }

            else if (tablero[1, 0] == "x" && tablero[1, 1] == "x" && tablero[1, 2] == "x")
            {
                MessageBox.Show("ganador x");
                isplaying = false;
            }
            else if (tablero[2, 0] == "x" && tablero[2, 1] == "x" && tablero[2, 2] == "x")
            {
                MessageBox.Show("ganador x");
                isplaying = false;
            }
            else if (tablero[0, 0] == "x" && tablero[1, 0] == "x" && tablero[2, 0] == "x")
            {
                MessageBox.Show("ganador x");
                isplaying = false;
            }
            else if (tablero[1, 0] == "x" && tablero[1, 1] == "x" && tablero[2, 1] == "x")
            {
                MessageBox.Show("ganador x");
                isplaying = false;
            }
            else if (tablero[2, 0] == "x" && tablero[2, 1] == "x" && tablero[2, 2] == "x")
            {
                MessageBox.Show("ganador x");
                isplaying = false;
            }
            else if (tablero[0, 0] == "x" && tablero[1, 1] == "x" && tablero[2, 2] == "x")
            {
                MessageBox.Show("ganador x");
                isplaying = false;
            }
            else if (tablero[2, 0] == "x" && tablero[1, 1] == "x" && tablero[0, 2] == "x")
            {
                MessageBox.Show("ganador x");
                isplaying = false;
            }

            //separacion de X  a O
            if (tablero[0, 0] == "o" && tablero[0, 1] == "o" && tablero[0, 2] == "o")
            {
                MessageBox.Show("ganador o" );
                isplaying = false;
            }

            else if (tablero[1, 0] == "o" && tablero[1, 1] == "o" && tablero[1, 2] == "o")
            {
                MessageBox.Show("ganador o");
                isplaying = false;
            }
            else if (tablero[2, 0] == "o" && tablero[2, 1] == "o" && tablero[2, 2] == "o")
            {
                MessageBox.Show("ganador o");
                isplaying = false;
            }
            else if (tablero[0, 0] == "o" && tablero[1, 0] == "o" && tablero[2, 0] == "o")
            {
                MessageBox.Show("ganador o");
                isplaying = false;
            }
            else if (tablero[1, 0] == "o" && tablero[1, 1] == "o" && tablero[2, 1] == "o")
            {
                MessageBox.Show("ganador o");
                isplaying = false;
            }
            else if (tablero[2, 0] == "o" && tablero[2, 1] == "o" && tablero[2, 2] == "o")
            {
                MessageBox.Show("ganador o");
                isplaying = false;
            }
            else if (tablero[0, 0] == "o" && tablero[1, 1] == "o" && tablero[2, 2] == "o")
            {
                MessageBox.Show("ganador ");
                isplaying = false;
            }
            else if (tablero[2, 0] == "o" && tablero[1, 1] == "o" && tablero[0, 2] == "o")
            {
                MessageBox.Show("ganador o");
                isplaying = false;

            }

            empate++;
            if (empate == 9) {
                MessageBox.Show("empate");
                limpiar();
                OnOffBtn(true);

                empate = 0;  
            
            }
        }
      


        private void limpiar()
        {
            
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            c1.Text = "";
            c2.Text = "";
            c3.Text = "";
             
        }

        private void a1_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                a1.Text = TurnoActual;
                a1.Enabled = false;
                marcar(0, 0, TurnoActual);

                if (TurnoActual == "x")
                {
                    TurnoActual = "o";

                }
                else
                {
                    TurnoActual = "x";
                }



            }


        }

        private void xazul_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void a2_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                a2.Text = TurnoActual;
                a2.Enabled = false;
                marcar(0, 1, TurnoActual);

                if (TurnoActual == "x")
                {
                    TurnoActual = "o";

                }
                else
                {
                    TurnoActual = "x";
                }
            }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                a3.Text = TurnoActual;
                a3.Enabled = false;
                marcar(0, 2, TurnoActual);

                if (TurnoActual == "x")
                {
                    TurnoActual = "o";

                }
                else
                {
                    TurnoActual = "x";
                }
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                b1.Text = TurnoActual;
                b1.Enabled = false;
                marcar(1, 0, TurnoActual);

                if (TurnoActual == "x")
                {
                    TurnoActual = "o";

                }
                else
                {
                    TurnoActual = "x";
                }
            }

        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                b2.Text = TurnoActual;
                b2.Enabled = false;
                marcar(1, 1, TurnoActual);

                if (TurnoActual == "x")
                {
                    TurnoActual = "o";

                }
                else
                {
                    TurnoActual = "x";
                }
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                b3.Text = TurnoActual;
                b3.Enabled = false;
                marcar(1, 2, TurnoActual);

                if (TurnoActual == "x")
                {
                    TurnoActual = "o";

                }
                else
                {
                    TurnoActual = "x";
                }
            }
        }

        private void c1_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                c1.Text = TurnoActual;
                c1.Enabled = false;
                marcar(2, 0, TurnoActual);

                if (TurnoActual == "x")
                {
                    TurnoActual = "o";

                }
                else
                {
                    TurnoActual = "x";
                }
            }
        }

        private void c2_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                c2.Text = TurnoActual;
                c2.Enabled = false;

                marcar(2, 1, TurnoActual);

                if (TurnoActual == "x")
                {
                    TurnoActual = "o";

                }
                else
                {
                    TurnoActual = "x";
                }
            }
        }

        private void c3_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                c3.Text = TurnoActual;
                c3.Enabled = false;

                marcar(2, 2, TurnoActual);

                if (TurnoActual == "x")
                {
                    TurnoActual = "o";

                }
                else
                {
                    TurnoActual = "x";
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            OnOffBtn(true);
            empate = 0;

        }

        private void btnreiniciar_Click(object sender, EventArgs e)
        {
            limpiar();
            
            btnlimpiar.Visible = false;
            btnreiniciar.Visible = false;

            btniniciar.Visible = true;

            txtuserrojo.Visible = true;
           txtuserazul.Visible = true;
            JugadorX = "";
            JugadorO = "";
            
         

            lbluserazul.Text = "";
            lbluserrojo.Text = "";

            oazul.Enabled = true;
            xrojo.Enabled = true;
            xazul.Enabled = true;
            orojo.Enabled = true;
            OnOffBtn(true); 
            xazul.Checked= false;
            oazul.Checked = false;
            xrojo.Checked = false;
            orojo.Checked = false;
          
            groupBox1.Text = "introduzca los nombres del os jugadores";
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
