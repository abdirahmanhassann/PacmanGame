namespace PacmanGame
{
    public partial class Form1 : Form
    {
        public enum Directions
        {
            north = Keys.Up,
            east = Keys.Right,
            south = Keys.Down,
            west = Keys.Left
        }
        public Directions _pacmanDirection = Directions.north;
        private System.Windows.Forms.Timer _myTimer = new System.Windows.Forms.Timer();
        public int _speed = 10;
        public Form1()
        {
            InitializeComponent();
            _myTimer.Tick += new EventHandler(GameLoop);
            _myTimer.Interval = 200;
            _myTimer.Start();
        }
        private void GameLoop(object sender, EventArgs e)
        {
            if (_pacmanDirection == Directions.north)
            {
                pacman.Location = new Point(
                    pacman.Location.X,
                    pacman.Location.Y - _speed);
            }

            if (_pacmanDirection == Directions.east)
            {
                pacman.Location = new Point(
                    pacman.Location.X + _speed,
                    pacman.Location.Y);
            }

            if (_pacmanDirection == Directions.south)
            {
                pacman.Location = new Point(
                    pacman.Location.X,
                    pacman.Location.Y + _speed);
            }

            if (_pacmanDirection == Directions.west)
            {
                pacman.Location = new Point(
                    pacman.Location.X - _speed,
                    pacman.Location.Y);
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && _pacmanDirection != Directions.north)
            {
                _pacmanDirection = Directions.north;
                pacman.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\..\imgs\pacmanNorth.gif")));
            }
            if (e.KeyCode == Keys.Right && _pacmanDirection != Directions.east)
            {
                _pacmanDirection = Directions.east;
                pacman.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\..\imgs\pacmanEast.gif")));
            }
            if (e.KeyCode == Keys.Down && _pacmanDirection != Directions.south)
            {
                _pacmanDirection = Directions.south;
                pacman.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\..\imgs\pacmanSouth.gif")));

            }
            if (e.KeyCode == Keys.Left && _pacmanDirection != Directions.west)
            {
                _pacmanDirection = Directions.west;
                pacman.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\..\imgs\pacmanWest.gif")));
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
