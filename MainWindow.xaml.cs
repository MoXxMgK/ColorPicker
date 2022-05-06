using System;
using System.ComponentModel;
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
using System.Runtime.CompilerServices;
using System.Windows.Ink;

namespace ColorPicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DrawingAttributes _drawAttrs;

        public DrawingAttributes DrawAttrs
        {
            get { return _drawAttrs; }
            set { _drawAttrs = value; }
        }

        public MainWindow()
        {
            DrawAttrs = new DrawingAttributes()
            {
                Color = Color.FromRgb(255, 0, 0)
            };

            DataContext = this;

            InitializeComponent();
        }

        private void ClearCanvasButtonClick(object sender, RoutedEventArgs e)
        {
            InkCanvas.Strokes.Clear();
        }

        private void CopyHexButtonClick(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(ColorCanvas.HexadecimalString);
        }

        private void CopyRGBButtonClick(object sender, RoutedEventArgs e)
        {
            var c = ColorCanvas;
            Clipboard.SetText($"{c.R}, {c.G}, {c.B}");
        }

        private void CopyARGBButtonClick(object sender, RoutedEventArgs e)
        {
            var c = ColorCanvas;
            Clipboard.SetText($"{c.R}, {c.G}, {c.B}, {c.A}");
        }
    }
}
