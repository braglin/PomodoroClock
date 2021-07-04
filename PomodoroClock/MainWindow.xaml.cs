using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;


namespace PomodoroClock
{
    public partial class MainWindow : Window
    {
        Stopwatch sw = new Stopwatch();
        MediaPlayer beep = new MediaPlayer();
        int workInt = 25;
        int restInt = 5;
        int bigRestInt = 5;
        int cyclesInt = 2;
        int menuId = 0;
        bool menu = false;
        bool moveWindow = false;

        public MainWindow()
        {
            InitializeComponent();
            var uri = new Uri("pack://siteoforigin:,,,/Resources/beep.wav"); 
            beep.Open(uri); 
        }

        #region "Main Function"
        private void countDownStart(object sender, MouseButtonEventArgs e)
        {
            if (startLbl.Content.ToString() == "Click here to start...")
            {
                for (int i = 1; i <= cyclesInt; i++)
                {
                    sw.Restart();
                    do
                    {
                        mainBgImg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/MainBR.png"));
                        timerLbl.Content = (workInt - sw.Elapsed.Minutes).ToString();
                        startLbl.Content = "Work";
                        DoEvents();
                        if (menu)
                        {
                            break;
                        }
                    } while (sw.Elapsed.Minutes <= workInt);

                    if (menu)
                    {
                        break;
                    }

                    beep.Play();
                    if (cyclesInt >= 4 && i > 1 && i % 2 == 0)
                    {
                        sw.Restart();
                        do
                        {
                            mainBgImg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/MainBG.png"));
                            timerLbl.Content = (bigRestInt - sw.Elapsed.Minutes).ToString();
                            startLbl.Content = "Take a big rest";
                            DoEvents();
                            if (menu)
                            {
                                break;
                            }
                        } while (sw.Elapsed.Minutes <= bigRestInt);
                    }
                    else
                    {
                        sw.Restart();
                        do
                        {
                            mainBgImg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/MainBG.png"));
                            timerLbl.Content = (restInt - sw.Elapsed.Minutes).ToString();
                            startLbl.Content = "Rest";
                            DoEvents();
                            if (menu)
                            {
                                break;
                            }
                        } while (sw.Elapsed.Minutes <= restInt);
                    }
                    if (menu)
                    {
                        break;
                    }

                    beep.Play();
                }

                startLbl.Content = "Click here to start...";
                timerLbl.Content = workInt;
            }
        }
        public static void DoEvents()
        {
            var frame = new DispatcherFrame();
            Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Background,
                new DispatcherOperationCallback(
                    delegate (object f)
                    {
                        ((DispatcherFrame)f).Continue = false;
                        return null;
                    }), frame);
            Dispatcher.PushFrame(frame);
        }
        #endregion 
        #region "Menu"
        private void setMenu(object sender, MouseButtonEventArgs e)
        {
            sw.Stop();
            menu = true;
            switch (menuId)
            {
                case (0):
                    mainBgImg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/MainBR.png"));
                    startLbl.Content = "Set the work interval...";
                    timerLbl.Content = workInt;
                    break;
                case (1):
                    startLbl.Content = "Set the small rest interval...";
                    timerLbl.Content = restInt;
                    break;
                case (2):
                    startLbl.Content = "Set the big rest interval...";
                    timerLbl.Content = bigRestInt;
                    break;
                case (3):
                    startLbl.Content = "Set the cycles amount...";
                    timerLbl.Content = cyclesInt;
                    break;
                default:
                    break;
            }
            if (menuId < 4)
            {
                menuId++;
            }
            else
            {
                startLbl.Content = "New settings saved...";
                menuId = -1;
                menu = false;
                System.Threading.Thread.Sleep(500);
                startLbl.Content = "Click here to start...";
                timerLbl.Content = workInt;
            }
        }

        private void plusBtnClick(object sender, MouseButtonEventArgs e)
        {
            if (menu)
            {
                sw.Stop();
                switch (menuId)
                {
                    case (1):
                        if (workInt < 59)
                        {
                            workInt++;
                        }
                        timerLbl.Content = workInt;
                        break;
                    case (2):
                        if (restInt < 59)
                        {
                            restInt++;
                        }
                        timerLbl.Content = restInt;
                        break;
                    case (3):
                        if (bigRestInt < 59)
                        {
                            bigRestInt++;
                        }
                        timerLbl.Content = bigRestInt;
                        break;
                    case (4):
                        if (cyclesInt < 59)
                        {
                            cyclesInt++;
                        }
                        timerLbl.Content = cyclesInt;
                        break;
                    default:
                        break;
                }
            }
        }

        private void minusBtnClick(object sender, MouseButtonEventArgs e)
        {
            if (menu)
            {
                sw.Stop();
                switch (menuId)
                {
                    case (1):
                        if (workInt > 10)
                        {
                            workInt--;
                        }
                        timerLbl.Content = workInt;
                        break;
                    case (2):
                        if (restInt > 5)
                        {
                            restInt--;
                        }
                        timerLbl.Content = restInt;
                        break;
                    case (3):
                        if (bigRestInt > 5)
                        {
                            bigRestInt--;
                        }
                        timerLbl.Content = bigRestInt;
                        break;
                    case (4):
                        if (cyclesInt > 2)
                        {
                            cyclesInt--;
                        }
                        timerLbl.Content = cyclesInt;
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
        #region "Window move"
        private void windowMoveDown(object sender, MouseButtonEventArgs e)
        {
            moveWindow = true;
        }

        private void windowMove(object sender, MouseEventArgs e)
        {
            if (moveWindow)
            {
                var point = System.Windows.Forms.Control.MousePosition;
                Top = point.Y - (this.Height / 2);
                Left = point.X - (this.Width / 2);
            }
        }
        
        private void windowMoveUp(object sender, MouseButtonEventArgs e)
        {
            moveWindow = false;
        }
        #endregion
    }
}
