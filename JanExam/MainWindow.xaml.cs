using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JanExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); //////github link : https://github.com/ConorCollier1/JanExam.git  ///////
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //create 3 players lists
            //French players
            Player p1 = new Player("Marie", "WWDDL");
            Player p2 = new Player("Claude", "DDDLW");
            Player p3 = new Player("Antoine", "LWDLW");
            List<Player> french = new List<Player>();
            french.Add(p1);
            french.Add(p2);
            french.Add(p3);

            //Italian players
            Player p4 = new Player("Marco", "WWDLL");
            Player p5 = new Player("Giovanni", "LLLLD");
            Player p6 = new Player("Valentina", "DLWWW");
            List <Player> italian = new List<Player>();
            italian.Add(p4);
            italian.Add(p5);
            italian.Add(p6);

            //Spanish players
            Player p7 = new Player("Maria", "WWWWW");
            Player p8 = new Player("Jose", "LLLLL");
            Player p9 = new Player("Pablo", "DDDDD");
            List<Player> spanish = new List<Player>();
            spanish.Add(p7);
            spanish.Add(p8);
            spanish.Add(p9);

            //create 3 teams
            Team t1 = new Team("France", french);
            Team t2 = new Team("Italy", italian);
            Team t3 = new Team("Spain", spanish);
            List<Team> teams = new List<Team>();
            teams.Add(t1);
            teams.Add(t2);
            teams.Add(t3);

            lbx_teams.ItemsSource = teams;
        }

        private void lbx_teams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //determine what account is selected
            Team selected = lbx_teams.SelectedItem as Team;

            //check for null
            if (selected != null)
            {
                //update display
                lbx_players.ItemsSource = selected.Players;
            }
        }

        private void btn_win_Click(object sender, RoutedEventArgs e)
        {
            //determine what account is selected
            Team selected = lbx_teams.SelectedItem as Team;
            //check for null
            if (selected != null)
            {
                foreach(Player player in selected.Players)
                {
                    //read result record and split
                    char[] chars = player.ResultRecord.ToCharArray();

                    chars[0] = chars[1];
                    chars[1] = chars[2];
                    chars[2] = chars[3];
                    chars[3] = chars[4];
                    chars[4] = 'W';
                }            

                //update display
                lbx_players.ItemsSource = selected.Players;
            }
        }

        private void btn_loss_Click(object sender, RoutedEventArgs e)
        {
            //determine what account is selected
            Team selected = lbx_teams.SelectedItem as Team;
            //check for null
            if (selected != null)
            {
                foreach (Player player in selected.Players)
                {
                    //read result record and split
                    char[] chars = player.ResultRecord.ToCharArray();
                    chars[0] = chars[1];
                    chars[1] = chars[2];
                    chars[2] = chars[3];
                    chars[3] = chars[4];
                    chars[4] = 'L';
                }

                //update display
                lbx_players.ItemsSource = selected.Players;
            }
        }

        private void btn_draw_Click(object sender, RoutedEventArgs e)
        {
            //determine what account is selected
            Team selected = lbx_teams.SelectedItem as Team;
            //check for null
            if (selected != null)
            {
                foreach (Player player in selected.Players)
                {
                    //read result record and split
                    char[] chars = player.ResultRecord.ToCharArray();
                    chars[0] = chars[1];
                    chars[1] = chars[2];
                    chars[2] = chars[3];
                    chars[3] = chars[4];
                    chars[4] = 'D';
                }

                //update display
                lbx_players.ItemsSource = selected.Players;
            }
        }
    }
}
