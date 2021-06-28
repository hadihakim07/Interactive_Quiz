using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Interactive_Quiz_Abdul_Hakimzadah
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private Quiz _quiz = new Quiz();


        public MainPage()
        {
            this.InitializeComponent();
        }

        private void BtnQuit_Click(object sender, RoutedEventArgs e)
        {
            CloseApp();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_A1_Click(object sender, RoutedEventArgs e)
        {
            //Quiz.CheckUserAnswer();
        }

        private void Btn_A2_Click(object sender, RoutedEventArgs e)
        {
            //Quiz.CheckUserAnswer();
        }

        private void Btn_A3_Click(object sender, RoutedEventArgs e)
        {
           //Quiz.CheckUserAnswer();
        }

        private void Btn_A4_Click(object sender, RoutedEventArgs e)
        {
            //Quiz.CheckUserAnswer();
        }


        private void QuizDisplay()
        {
            //quizTitleTxt.Text = Quiz.Title
        }

        public void CloseApp()
        {
            Application.Current.Exit();
        }
    }
}
