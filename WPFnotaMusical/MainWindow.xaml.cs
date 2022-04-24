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
using System.Media;

namespace WPFnotaMusical
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double note, scale, frecuency;

        public MainWindow()
        {
            InitializeComponent();
            listBoxLog.Items.Clear();
        }

        private void doButton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota1 = new SoundPlayer();
            nota1.SoundLocation = (@"56.wav");
            nota1.Load();
            nota1.Play();
            //958
            note = 11;
            scale = 5;
            frecuency = CalculateFrecuency(note, scale);
            listBoxLog.Items.Clear();
            listBoxLog.Items.Add($"Nota\tEscala\tFrecuencia");
            listBoxLog.Items.Add($"{note}\t{scale}\t{frecuency}");
        }

        private void reButton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota3 = new SoundPlayer();
            nota3.SoundLocation = (@"80.wav");
            nota3.Load();
            nota3.Play();
            //764
            note = 8;
            scale = 5;
            frecuency = CalculateFrecuency(note, scale);
            listBoxLog.Items.Clear();
            listBoxLog.Items.Add($"Nota\tEscala\tFrecuencia");
            listBoxLog.Items.Add($"{note}\t{scale}\t{frecuency}");
        }

        private void doSButton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota2 = new SoundPlayer();
            nota2.SoundLocation = (@"60.wav");
            nota2.Load();
            nota2.Play();
            //721
            note = 7;
            scale = 5;
            frecuency = CalculateFrecuency(note, scale);
            listBoxLog.Items.Clear();
            listBoxLog.Items.Add($"Nota\tEscala\tFrecuencia");
            listBoxLog.Items.Add($"{note}\t{scale}\t{frecuency}");
        }
        public double CalculateFrecuency(double note, double scale)
        {
            return 440 * Math.Exp(((scale - 4) + ((note - 10) / 12)) * Math.Log(2));
        }

        private void signature_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
        }
    }
}
