using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrRobotGame
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Zmienna prywatna przechowująca aktualne hasło do konta użytkownika
        /// </summary>
        private string password = "admin";

        /// <summary>
        /// Zmienna przechowująca aktualny stan głodu gracza, dojście tej zmiennej do 100 oznacza przegraną
        /// </summary>
        private double hungerState = 50;

        /// <summary>
        /// Zmienna przechowująca aktualny stan umiejętności programistycznych gracza
        /// </summary>
        private double skillState = 50;

        /// <summary>
        /// Zmienna przechowująca aktualny stan zdrowia psychicznego gracza, dojście tej zmiennej do 0 oznacza przegraną
        /// </summary>
        private double sanityState = 50;

        /// <summary>
        /// Zmienna przechowująca aktualny stan senności gracza, dojście tej zmiennej do 0 oznacza przegraną
        /// </summary>
        private double sleepState = 50;

        /// <summary>
        /// Zmienna przechowująca aktualny stan majątkowy gracza
        /// </summary>
        private double ecoinState = 50;

        /// <summary>
        /// Zmienna przechowujaca aktualny stan wpływu narkotyków na gracza, dojście tego stanu do 100 oznacza przegraną
        /// </summary>
        private double drugsState = 50;

        /// <summary>
        /// Moc komputera przyspieszająca proces uczenia się hakowania
        /// </summary>
        private int pcPower = 1;

        /// <summary>
        /// Zmienna określająca to jak użytkownik jest podatny na bycie zhakowanym przez Dark Army
        /// </summary>
        private int hackVulnerable = 0;

        /// <summary>
        /// Generator liczb pseudolosowych
        /// </summary>
        Random rand = new Random();

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ta funkcja zmienia liczbę double na przyjazną dla progressBaru wartość Integer z przedziału 0 100, zamieniając wartości ujemne na 0 a wartości większe niż 100 na 100
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        double getMinMaxIntegerValue(double value)
        {
            return Math.Max(Math.Min(value,100),0);
        }

        /// <summary>
        /// Zaloguj użytkownika ustawiając wszystkie przyciski na widoczne
        /// </summary>
        void logIn()
        {
            buttonHack.Visible = true;
            buttonWipe.Visible = true;
            buttonChange.Visible = true;
            buttonUpgrade.Visible = true;
            buttonWin.Visible = true;
        }

        /// <summary>
        /// Wyloguj użytkownika ustawiając wszystkie przyciski na niewidoczne
        /// </summary>
        void logOut()
        {
            buttonHack.Visible = false;
            buttonWipe.Visible = false;
            buttonChange.Visible = false;
            buttonUpgrade.Visible = false;
            buttonWin.Visible = false;
        }

        /// <summary>
        /// Funkcja aktualizuje wszystkie progressBars na aktualne wartości, jest wywoływana co sekundę w timeCounter_Tick
        /// </summary>
        void updateStates()
        {
            // aktualizacja stanów
            skillState = getMinMaxIntegerValue(skillState);
            ecoinState = getMinMaxIntegerValue(ecoinState);
            hungerState = getMinMaxIntegerValue(hungerState);
            sanityState = getMinMaxIntegerValue(sanityState);
            sleepState = getMinMaxIntegerValue(sleepState);
            drugsState = getMinMaxIntegerValue(drugsState);
            // aktualizacja pasków
            progressBarSkill.Value = (int)skillState;
            progressBarEcoin.Value = (int)ecoinState;
            progressBarFood.Value = (int)hungerState;
            progressBarSanity.Value = (int)sanityState;
            progressBarSleep.Value = (int)sleepState;
            progressBarDrugs.Value = (int)drugsState;
        }

        /// <summary>
        /// Funkcja dająca użytkownikowi dostęp do komend komputera jeśli poda poprawne hasło
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            // wejście do dodatkowych opcji konta jeśli aktualnie tag przycisku to Set
            if ((string)buttonEnter.Tag == "Set")
            {
                // jeśli hasło poprawne to pokaż przyciski z akcjami
                if (textBoxPassword.Text == password)
                {
                    logIn();
                }
                else
                {
                    // jeśli hasło niepoprawne to ukryj przyciski z akcjami
                    logOut();
                }
            } // zmiana hasła
            else if((string)buttonEnter.Tag == "Change")
            {
                password = textBoxPassword.Text;
                buttonEnter.Tag = "Set";
                labelDialog.Text = "Enter a password: ";
                textBoxPassword.Text = "";
                hackVulnerable-=30;
                if (hackVulnerable < 0)
                    hackVulnerable = 0;
            }
        }

        /// <summary>
        /// Funkcja zmienia zachowanie przycisku buttonEnter na zmieniający hasło na nowe i wylogowuje użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, EventArgs e)
        {
            buttonEnter.Tag = "Change";
            labelDialog.Text = "Change password: ";

            // zwiekszenie bezpieczenstwa poprzez zmniejszenie ryzyka zostanie zhakowanym
            logOut();
        }

        /// <summary>
        /// Funkcja kończąca grę, po wciśnięciu przycisku buttonWin, jeśli osiągnięto wymagane umiejętności
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWin_Click(object sender, EventArgs e)
        {
            if (skillState >= 80 && (string)pictureBoxCharacter.Tag == "MRROBOT")
            {
                timerCounter.Stop();
                MessageBox.Show("Congratulations! You won!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("To do that you need to become Mr. Robot and have skill higher than 80");
            }
        }

        /// <summary>
        /// Funckja co sekundę aktualizuje wszystkie progressBars i kończy grę jeśli któraś ze śmiertelnych wartości nie spadła do krytcznego poziomu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCounter_Tick(object sender, EventArgs e)
        {

            // co sekundę aktualizacja podstawowych wartości
            hungerState += 0.2;
            sleepState -= 0.15;
            drugsState -= 0.2;
            hackVulnerable += 1;

            // jeśli użytkownik nie utrzyma bezpieczeństwa to jest 20% że zostanie zhakowany i przegra grę
            if(hackVulnerable >= 50 && rand.Next(15) == 3)
            {
                // zakończenie gry
                timerCounter.Stop();
                MessageBox.Show("You got hacked by Dark Army, you didn't stay safe enough :3");
                Application.Exit();
            }

            // Zamiana w Mr. Robota jest możliwa tylko jeśli charakter jest pod wpływem środków oraz jego zdrowie psychiczne jest w niskim stanie
            if (sanityState <= 30 && drugsState >= 50 && rand.Next(5) == 3)
            {
                // Zamiana w Mr. Robota
                pictureBoxCharacter.Image = Properties.Resources.MrRobot;
                pictureBoxCharacter.Tag = "MRROBOT";
            }

            // jeśli któraś z wartości osiągnęła krytyczny poziom, skończ grę, w przeciwnym razie zaaktualizuj progressBars
            if (hungerState <= 100 && drugsState <= 100 && sleepState >= 0 && sanityState >= 0)
            {
                updateStates();
                return;
            }
            else
            {
                // zakończenie gry
                timerCounter.Stop();
                MessageBox.Show("You died! :(");
                Application.Exit();
            }
        }

        /// <summary>
        /// Funkcja aktualizująca poszczególne stany na skutek jedzenia i wylogowujaca użytkownika z systemu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEat_Click(object sender, EventArgs e)
        {
            if(ecoinState >= 5)
            {
                ecoinState -= 5;
                hungerState -= 10;
            }
            else
            {
                MessageBox.Show("You don't have enough money!");
            }


            logOut();
            
        }

        /// <summary>
        /// Funkcja aktualizująca poszczególne stany na skutek spania i wylogowujaca użytkownika z systemu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSleep_Click(object sender, EventArgs e)
        {
            sleepState += 20;
            hungerState += 5;
            drugsState -= 10;
            sanityState += 10;

            logOut();
        }

        /// <summary>
        /// Funkcja aktualizująca poszczególne stany na skutek wizyty u psychologa i wylogowujaca użytkownika z systemu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPsychologist_Click(object sender, EventArgs e)
        {
            if (ecoinState >= 15)
            {
                sanityState += 12;
                ecoinState -= 15;
                drugsState -= 20;
            }
            else
            {
                MessageBox.Show("You don't have enough money!");
            }
            logOut();
        }

        /// <summary>
        /// Funkcja aktualizująca poszczególne stany na skutek wzięcia środków odurzjących i wylogowujaca użytkownika z systemu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrugs_Click(object sender, EventArgs e)
        {
            if (ecoinState >= 10)
            {
                sanityState -= 10;
                ecoinState -= 10;
                drugsState += 20;
                hungerState += 5;
            }
            else
            {
                MessageBox.Show("You don't have enough money!");
            }

            logOut();
        }

        /// <summary>
        /// Funkcja aktualizująca poszczególne stany na skutek pójścia do pracy i wylogowujaca użytkownika z systemu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWork_Click(object sender, EventArgs e)
        {
            sleepState -= 10;
            skillState += 1;
            ecoinState += 20;
            hungerState += 8;

            logOut();
        }

        /// <summary>
        /// Funckja zwiększająca skillState, kosztem czasu, szybkosc nauki zalezy od komputera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHack_Click(object sender, EventArgs e)
        {
            hungerState += 5;
            sanityState -= 8;
            skillState += 2 * pcPower * (1 + drugsState/100);
        }

        /// <summary>
        /// Funckja zwiększająca prędkość uczenia się hakowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpgrade_Click(object sender, EventArgs e)
        {
            if (pcPower < 5) {
                if(ecoinState >= 20)
                {
                    pcPower++;
                    ecoinState -= 20;
                }
                else
                {
                    MessageBox.Show("You don't have enough money to do that");
                }
            }
            else
            {
                MessageBox.Show("Your pc is already the most powerful you can have");
            }
         

        }

        /// <summary>
        /// Funkcja która za cenę czyści dyski twarde dzięki czemu użytkownik jest mniej podatny na bycie zhakowanym
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWipe_Click(object sender, EventArgs e)
        {
            if(ecoinState >= 20)
            {
                ecoinState -= 20;
                hackVulnerable = 0;
            }
            else
            {
                MessageBox.Show("You don't have enough money to do that");
            }

        }
    }
}
