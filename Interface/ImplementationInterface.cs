using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Interface
{
    public class ImplementationInterface
    {
        public static void main() 
        {
            PrintOut printOut = new PrintOut();
            printOut.Print();
        }
    }

    interface Club 
    {
        string Name { get; set; }
        string Founder { get; set; }
        double Saham { get; set; }
        string print();
    }

    interface Player 
    {
        string FullName { get; set; }
        string NomorPunggung { get; set; }
        int Height { get; set; }
        string print();
    }

    class FootBall : Club, Player 
    {
        private string name;
        private string fullName;
        private string founder;
        private double saham;
        private string nomorPunggung;
        private int height;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string FullName
        {
            set { fullName = value; }
            get { return fullName; }
        }
        public string Founder 
        {
            set {  founder = value; }
            get { return founder; }
        }
        public double Saham 
        {
            set {  saham = value; }
            get { return saham; }
        }
        public string NomorPunggung  
        {
            set {  nomorPunggung = value; }
            get { return nomorPunggung; }
        }
        public int Height
        {
            set {  height = value; }
            get { return height; }
        }

        string Club.print() 
        {
            return $"Nama club : {this.Name} " +
                   $"\nFounder club : {this.Founder} " +
                   $"\nJumlah Saham : {this.Saham}";
        }
        string Player.print() 
        {
            return $"Player Name : {this.FullName} " +
                   $"\nNomor Punggung : {this.NomorPunggung}" +
                   $"\nTinggi Badan : {this.Height}";
        }
    }

    class PrintOut
    {
        public void Print() 
        {
            Club club = new FootBall();
            Player player = new FootBall();

            club.Name = "FC Barcelona";
            club.Founder = "Jose Mario Bartemou";
            club.Saham = 2000000000;

            player.FullName = "Lionel Messi";
            player.Height = 187;
            player.NomorPunggung = "10";

            Console.WriteLine(club.print());
            Console.WriteLine(player.print());
        }
    }
}
