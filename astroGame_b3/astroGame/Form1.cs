using System.Windows.Forms;
using System.Text.Json;
using System;
using Microsoft.VisualBasic.ApplicationServices;

/*
 * Добавлено:
 * 
 * Исправлено:
 * загрузка спрайтов
 * 
 * Надо исправить:
 * back спрайтов
 * отображение спрайтов
 */



namespace astroGame
{
    public partial class menuWindow : Form
    {
        string gamerName = "Gamer";
        static Gamer gamer;

        public GameWindow Game;
        List<Gamer> gamerList = new List<Gamer>();

        public menuWindow()
        {
            InitializeComponent();
            WindowManager menu = new WindowManager(this, "background\\back1.jpg", playButton, exitButton);
        }

        private void menuWindow_Load(object sender, EventArgs e)
        {
            LoadGamer(gamerList);

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            StartGame();
            BackMenu();

        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INFO");
        }

        private void recordsButtons_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RECORDS");
        }

        private void garageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GARAGE");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void BackMenu()
        {
            Game.Hide();
            //this.BringToFront();
            gamerList[gamerList.Count - 1] = WindowManager.g;
            this.Show();

        }

        public void StartGame()
        {
            this.Hide();
            WindowManager.g = CheakGamer(gamerList, gamerName);
            Game = new GameWindow();
            Game.BringToFront();
            Game.ShowDialog();

        }

        private void nameGamer_TextChanged(object sender, EventArgs e)
        {
            gamerName = nameGamer.Text;
        }

        private void LoadGamer(List<Gamer> list)
        {
            var fileName = @"data.json";
            byte[] data = File.ReadAllBytes(fileName);
            if (data.Length <= 1) return;
            using JsonDocument doc = JsonDocument.Parse(data);
            JsonElement root = doc.RootElement;

            var gamers = root.EnumerateArray();

            while (gamers.MoveNext())
            {
                var gamer = gamers.Current;
                var prop = JsonSerializer.Deserialize<Gamer>(gamer);
                list.Add(new Gamer(prop.Name, prop.Ship, prop.Money, prop.Point));
            }

        }

        private Gamer CheakGamer(List<Gamer> list, string gamerName)
        {
            foreach(Gamer gamer in list)
                if (gamer.Name == gamerName) return gamer;
            list.Add(new Gamer(gamerName, "spaceship\\playerShip2_green.png", 0, 0));
            return list[list.Count - 1];
        }

        private void NewGamer(List<Gamer> list) { }

        private void menuWindow_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}