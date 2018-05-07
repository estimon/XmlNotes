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
using System.Xml;

namespace XmlHarjutus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MFbutton_Click(object sender, RoutedEventArgs e)
        {
            XmlWriter xmlnew = XmlWriter.Create("Notes.xml");
            xmlnew.WriteStartElement("Asjad");
            xmlnew.WriteStartElement("Notes");
            xmlnew.WriteStartElement("Pealkiri");
            xmlnew.WriteString(PealBox.Text);
            xmlnew.WriteEndElement();
            xmlnew.WriteStartElement("Sisu");
            xmlnew.WriteString(SisuBox.Text);
            xmlnew.WriteEndElement();
            xmlnew.WriteEndElement();
            xmlnew.WriteEndElement();

            xmlnew.Close();

        }
    }
}
