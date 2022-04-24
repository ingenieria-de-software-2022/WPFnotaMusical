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
            selectInstrument.Items.Add("piano");
            selectInstrument.Items.Add("bajo");
            selectInstrument.Text = "piano";
            scale = 5;
        }

        private void doButton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota = new SoundPlayer();
            if (selectInstrument.Text == "piano") nota.SoundLocation = (@"pianoDo.wav");
            if (selectInstrument.Text == "bajo") nota.SoundLocation = (@"bajoDo.wav");
            nota.Load();
            nota.Play();
            note = 1;
            frecuency = CalculateFrecuency(note, scale);
            listBoxLog.Items.Clear();
            listBoxLog.Items.Add($"Nota\tEscala\tFrecuencia");
            listBoxLog.Items.Add($"{note}\t{scale}\t{frecuency}");
        }
                private void doSButton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota = new SoundPlayer();
            if (selectInstrument.Text == "piano") nota.SoundLocation = (@"pianoDoS.wav");
            if (selectInstrument.Text == "bajo") nota.SoundLocation = (@"bajoDoS.wav");
            nota.Load();
            nota.Play();
            note = 2;
            frecuency = CalculateFrecuency(note, scale);
            listBoxLog.Items.Clear();
            listBoxLog.Items.Add($"Nota\tEscala\tFrecuencia");
            listBoxLog.Items.Add($"{note}\t{scale}\t{frecuency}");
        }

        private void reButton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota = new SoundPlayer();
            if (selectInstrument.Text == "piano") nota.SoundLocation = (@"pianoRe.wav");
            if (selectInstrument.Text == "bajo") nota.SoundLocation = (@"bajoRe.wav");
            nota.Load();
            nota.Play();
            note = 3;
            frecuency = CalculateFrecuency(note, scale);
            listBoxLog.Items.Clear();
            listBoxLog.Items.Add($"Nota\tEscala\tFrecuencia");
            listBoxLog.Items.Add($"{note}\t{scale}\t{frecuency}");
        }

        private void reSButton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota = new SoundPlayer();
            if (selectInstrument.Text == "piano") nota.SoundLocation = (@"pianoReS.wav");
            if (selectInstrument.Text == "bajo") nota.SoundLocation = (@"bajoReS.wav");
            nota.Load();
            nota.Play();
            note = 4;
            frecuency = CalculateFrecuency(note, scale);
            listBoxLog.Items.Clear();
            listBoxLog.Items.Add($"Nota\tEscala\tFrecuencia");
            listBoxLog.Items.Add($"{note}\t{scale}\t{frecuency}");
        }

        private void miButton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota = new SoundPlayer();
            if (selectInstrument.Text == "piano") nota.SoundLocation = (@"pianoMi.wav");
            if (selectInstrument.Text == "bajo") nota.SoundLocation = (@"bajoMi.wav");
            nota.Load();
            nota.Play();
            note = 5;
            frecuency = CalculateFrecuency(note, scale);
            listBoxLog.Items.Clear();
            listBoxLog.Items.Add($"Nota\tEscala\tFrecuencia");
            listBoxLog.Items.Add($"{note}\t{scale}\t{frecuency}");
        }

        private void faButton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota = new SoundPlayer();
            if (selectInstrument.Text == "piano") nota.SoundLocation = (@"pianoFa.wav");
            if (selectInstrument.Text == "bajo") nota.SoundLocation = (@"bajoFa.wav");
            nota.Load();
            nota.Play();
            note = 6;
            frecuency = CalculateFrecuency(note, scale);
            listBoxLog.Items.Clear();
            listBoxLog.Items.Add($"Nota\tEscala\tFrecuencia");
            listBoxLog.Items.Add($"{note}\t{scale}\t{frecuency}");
        }

        private void faSButton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota = new SoundPlayer();
            if (selectInstrument.Text == "piano") nota.SoundLocation = (@"pianoFaS.wav");
            if (selectInstrument.Text == "bajo") nota.SoundLocation = (@"bajoFaS.wav");
            nota.Load();
            nota.Play();
            note = 7;
            frecuency = CalculateFrecuency(note, scale);
            listBoxLog.Items.Clear();
            listBoxLog.Items.Add($"Nota\tEscala\tFrecuencia");
            listBoxLog.Items.Add($"{note}\t{scale}\t{frecuency}");
        }

        private void solButton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota = new SoundPlayer();
            if (selectInstrument.Text == "piano") nota.SoundLocation = (@"pianoSol.wav");
            if (selectInstrument.Text == "bajo") nota.SoundLocation = (@"bajoSol.wav");
            nota.Load();
            nota.Play();
            note = 8;
            frecuency = CalculateFrecuency(note, scale);
            listBoxLog.Items.Clear();
            listBoxLog.Items.Add($"Nota\tEscala\tFrecuencia");
            listBoxLog.Items.Add($"{note}\t{scale}\t{frecuency}");
        }

        private void solSButton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota = new SoundPlayer();
            if (selectInstrument.Text == "piano") nota.SoundLocation = (@"pianoSolS.wav");
            if (selectInstrument.Text == "bajo") nota.SoundLocation = (@"bajoSolS.wav");
            nota.Load();
            nota.Play();
            note = 9;
            frecuency = CalculateFrecuency(note, scale);
            listBoxLog.Items.Clear();
            listBoxLog.Items.Add($"Nota\tEscala\tFrecuencia");
            listBoxLog.Items.Add($"{note}\t{scale}\t{frecuency}");
        }

        private void laButton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota = new SoundPlayer();
            if (selectInstrument.Text == "piano") nota.SoundLocation = (@"pianoLa.wav");
            if (selectInstrument.Text == "bajo") nota.SoundLocation = (@"bajoLa.wav");
            nota.Load();
            nota.Play();
            note = 10;
            frecuency = CalculateFrecuency(note, scale);
            listBoxLog.Items.Clear();
            listBoxLog.Items.Add($"Nota\tEscala\tFrecuencia");
            listBoxLog.Items.Add($"{note}\t{scale}\t{frecuency}");
        }

        private void laSButton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota = new SoundPlayer();
            if (selectInstrument.Text == "piano") nota.SoundLocation = (@"pianoLaS.wav");
            if (selectInstrument.Text == "bajo") nota.SoundLocation = (@"bajoLaS.wav");
            nota.Load();
            nota.Play();
            note = 11;
            frecuency = CalculateFrecuency(note, scale);
            listBoxLog.Items.Clear();
            listBoxLog.Items.Add($"Nota\tEscala\tFrecuencia");
            listBoxLog.Items.Add($"{note}\t{scale}\t{frecuency}");
        }

        private void siButton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota = new SoundPlayer();
            if (selectInstrument.Text == "piano") nota.SoundLocation = (@"pianoSi.wav");
            if (selectInstrument.Text == "bajo") nota.SoundLocation = (@"bajoSi.wav");
            nota.Load();
            nota.Play();
            note = 12;
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
