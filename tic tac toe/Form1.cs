using System.Windows.Forms;

namespace tic_tac_toe
{


    public partial class Form1 : Form
    {
        string JugadorX = "";
        char[,] tablero = {{ '_', '_', '_' },
                     { '_', '_', '_' },
                     { '_', '_', '_' }};
        bool isplaying = false;
        int empate = 0;

        static char player = 'x', opponent = 'o';



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
            if (txtuserazul.Text == "")
            {
                MessageBox.Show("el nombre no debe estar vacio ");
                return;
            }
            else
            {
                JugadorX = txtuserazul.Text;
                PlayGame();
            }


        }

        private void PlayGame()
        {
            isplaying = true;
            lbluserazul.Text = txtuserazul.Text;

            groupBox1.Text = "Marcador";

            btnlimpiar.Visible = true;

            btnreiniciar.Visible = true;
            btniniciar.Visible = false;
            txtuserazul.Visible = false;
            MessageBox.Show("EMPIEZA el " + JugadorX);
            OnOffBtn(true);
        }




        static Boolean isMovesLeft(char[,] board)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (board[i, j] == '_')
                        return true;
            return false;
        }


        static int evaluate(char[,] b)
        {
            // Checking for Rows for X or O victory. 
            for (int row = 0; row < 3; row++)
            {
                if (b[row, 0] == b[row, 1] &&
                    b[row, 1] == b[row, 2])
                {
                    if (b[row, 0] == player)
                        return +10;
                    else if (b[row, 0] == opponent)
                        return -10;
                }
            }

            // Checking for Columns for X or O victory. 
            for (int col = 0; col < 3; col++)
            {
                if (b[0, col] == b[1, col] &&
                    b[1, col] == b[2, col])
                {
                    if (b[0, col] == player)
                        return +10;

                    else if (b[0, col] == opponent)
                        return -10;
                }
            }

            // Checking for Diagonals for X or O victory. 
            if (b[0, 0] == b[1, 1] && b[1, 1] == b[2, 2])
            {
                if (b[0, 0] == player)
                    return +10;
                else if (b[0, 0] == opponent)
                    return -10;
            }

            if (b[0, 2] == b[1, 1] && b[1, 1] == b[2, 0])
            {
                if (b[0, 2] == player)
                    return +10;
                else if (b[0, 2] == opponent)
                    return -10;
            }

            // Else if none of them have won then return 0 
            return 0;
        }


        static int minimax(char[,] board,
                    int depth, Boolean isMax)
        {
            int score = evaluate(board);

            // If Maximizer has won the game  
            // return his/her evaluated score 
            if (score == 10)
                return score;

            // If Minimizer has won the game  
            // return his/her evaluated score 
            if (score == -10)
                return score;

            // If there are no more moves and  
            // no winner then it is a tie 
            if (isMovesLeft(board) == false)
                return 0;

            // If this maximizer's move 
            if (isMax)
            {
                int best = -1000;

                // Traverse all cells 
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        // Check if cell is empty 
                        if (board[i, j] == '_')
                        {
                            // Make the move 
                            board[i, j] = player;

                            // Call minimax recursively and choose 
                            // the maximum value 
                            best = Math.Max(best, minimax(board,
                                            depth + 1, !isMax));

                            // Undo the move 
                            board[i, j] = '_';
                        }
                    }
                }
                return best;
            }

            // If this minimizer's move 
            else
            {
                int best = 1000;

                // Traverse all cells 
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        // Check if cell is empty 
                        if (board[i, j] == '_')
                        {
                            // Make the move 
                            board[i, j] = opponent;

                            // Call minimax recursively and choose 
                            // the minimum value 
                            best = Math.Min(best, minimax(board,
                                            depth + 1, !isMax));

                            // Undo the move 
                            board[i, j] = '_';
                        }
                    }
                }
                return best;
            }
        }

        static Move findBestMove(char[,] board)
        {
            int bestVal = -1000;
            Move bestMove = new Move();
            bestMove.row = -1;
            bestMove.col = -1;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == '_')
                    {
                        board[i, j] = player;


                        int moveVal = minimax(board, 0, false);

                        board[i, j] = '_';


                        if (moveVal > bestVal)
                        {
                            bestMove.row = i;
                            bestMove.col = j;
                            bestVal = moveVal;
                        }
                    }
                }
            }



            return bestMove;
        }


        private void marcar(int row, int column, char caract)
        {
            tablero[row, column] = caract;
            ganador();
            TurnoCPU();
            ganador();



        }
        private void ganador()
        {

            if (!isplaying)
            {
                return;
            }


            //check horizontal
            for (int i = 0; i < 3; i++)
            {
                if (tablero[i, 0] == 'x' && tablero[i, 1] == 'x' && tablero[i, 2] == 'x')
                {
                    MessageBox.Show("ganador x");
                    isplaying = false;
                }
                else if (tablero[i, 0] == 'o' && tablero[i, 1] == 'o' && tablero[i, 2] == 'o')
                {
                    MessageBox.Show("ganador o");
                    isplaying = false;
                }
            }

            //check vertical
            for (int j = 0; j < 3; j++)
            {
                if (tablero[0, j] == 'x' && tablero[1, j] == 'x' && tablero[2, j] == 'x')
                {
                    MessageBox.Show("ganador x");
                    isplaying = false;
                }
                else if (tablero[0, j] == 'o' && tablero[1, j] == 'o' && tablero[2, j] == 'o')
                {
                    MessageBox.Show("ganador o");
                    isplaying = false;
                }
            }

            //check diagonal
            if (tablero[0, 0] == 'x' && tablero[1, 1] == 'x' && tablero[2, 2] == 'x')
            {
                MessageBox.Show("ganador x");
                isplaying = false;
            }
            else if (tablero[0, 0] == 'o' && tablero[1, 1] == 'o' && tablero[2, 2] == 'o')
            {
                MessageBox.Show("ganador o");
                isplaying = false;
            }
            else if (tablero[0, 2] == 'x' && tablero[1, 1] == 'x' && tablero[2, 0] == 'x')
            {
                MessageBox.Show("ganador x");
                isplaying = false;
            }
            else if (tablero[0, 2] == 'o' && tablero[1, 1] == 'o' && tablero[2, 0] == 'o')
            {
                MessageBox.Show("ganador o");
                isplaying = false;
            }



            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tablero[i, j] != '_')
                    {
                        empate++;
                    }
                }
            }

            if (empate == 9)
            {
                MessageBox.Show("empate");
                isplaying = false;
            }
        }

        private void TurnoCPU()
        {
            if (isplaying)
            {
                Move bestMove = findBestMove(tablero);
                tablero[bestMove.row, bestMove.col] = 'o';
                if (bestMove.row == 0 && bestMove.col == 0)
                {
                    a1.Text = "o";
                    a1.Enabled = false;
                }
                else if (bestMove.row == 0 && bestMove.col == 1)
                {
                    a2.Text = "o";
                    a2.Enabled = false;
                }
                else if (bestMove.row == 0 && bestMove.col == 2)
                {
                    a3.Text = "o";
                    a3.Enabled = false;
                }
                else if (bestMove.row == 1 && bestMove.col == 0)
                {
                    b1.Text = "o";
                    b1.Enabled = false;
                }
                else if (bestMove.row == 1 && bestMove.col == 1)
                {
                    b2.Text = "o";
                    b2.Enabled = false;
                }
                else if (bestMove.row == 1 && bestMove.col == 2)
                {
                    b3.Text = "o";
                    b3.Enabled = false;
                }
                else if (bestMove.row == 2 && bestMove.col == 0)
                {
                    c1.Text = "o";
                    c1.Enabled = false;
                }
                else if (bestMove.row == 2 && bestMove.col == 1)
                {
                    c2.Text = "o";
                    c2.Enabled = false;
                }
                else if (bestMove.row == 2 && bestMove.col == 2)
                {
                    c3.Text = "o";
                    c3.Enabled = false;
                }
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

            //limpiar tablero
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tablero[i, j] = '_';
                }
            }

        }

        private void a1_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                a1.Text = "x";
                a1.Enabled = false;
                marcar(0, 0, 'x');



            }


        }

        private void xazul_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void a2_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                a2.Text = "x";
                a2.Enabled = false;
                marcar(0, 1, 'x');


            }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                a3.Text = "x";
                a3.Enabled = false;
                marcar(0, 2, 'x');

            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                b1.Text = "x";
                b1.Enabled = false;
                marcar(1, 0, 'x');

            }

        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                b2.Text = "x";
                b2.Enabled = false;
                marcar(1, 1, 'x');


            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                b3.Text = "x";
                b3.Enabled = false;
                marcar(1, 2, 'x');


            }
        }

        private void c1_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                c1.Text = "x";
                c1.Enabled = false;
                marcar(2, 0, 'x');

            }
        }

        private void c2_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                c2.Text = "x";
                c2.Enabled = false;

                marcar(2, 1, 'x');

            }
        }

        private void c3_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                c3.Text = "x";
                c3.Enabled = false;

                marcar(2, 2, 'x');


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

            txtuserazul.Visible = true;
            JugadorX = "";




            lbluserazul.Text = "";
            lbluserrojo.Text = "";


            OnOffBtn(true);

            groupBox1.Text = "introduzca los nombres del os jugadores";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbluserrojo_Click(object sender, EventArgs e)
        {

        }

        private void lbluserazul_Click(object sender, EventArgs e)
        {

        }
    }
    class Move
    {
        public int row, col;
    };

}
