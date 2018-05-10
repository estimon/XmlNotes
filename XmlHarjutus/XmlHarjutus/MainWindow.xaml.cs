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
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("file:///C:/Users/opilane/Documents/GitHub/XmlNotes/XmlHarjutus/XmlHarjutus/bin/Debug/Notes.xml");
            XmlNode node = xdoc.SelectSingleNode("/Asjad/Notes/Pealkiri");
            Peal1Box.Text = node.InnerText;
            XmlNode node1 = xdoc.SelectSingleNode("/Asjad/Notes/Sisu");
            MärkBox.Text = node1.InnerText;



            märkmedcmb.Items.Add("Slot 1");
            märkmedcmb.Items.Add("Slot 2");
            märkmedcmb.Items.Add("Slot 3");
            märkmedcmb.Items.Add("Slot 4");
            märkmedcmb.Items.Add("Slot 5");

           
        }

        public void MFbutton_Click(object sender, RoutedEventArgs e)
        {
            if (märkmedcmb.SelectedItem == "Slot 1")
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
            
            else if (märkmedcmb.SelectedItem == "Slot 2")
            {
                XmlWriter xmlnew = XmlWriter.Create("Notes.xml");
                xmlnew.WriteStartElement("Asjad");
                xmlnew.WriteStartElement("Notes");
                xmlnew.WriteStartElement("Pealkiri1");
                xmlnew.WriteString(PealBox.Text);
                xmlnew.WriteEndElement();
                xmlnew.WriteStartElement("Sisu1");
                xmlnew.WriteString(SisuBox.Text);
                xmlnew.WriteEndElement();
                xmlnew.WriteEndElement();
                xmlnew.WriteEndElement();
                xmlnew.Close();
            }

            //XmlWriter xmlnew = XmlWriter.Create("Notes.xml");
            //xmlnew.WriteStartElement("Asjad");
            //xmlnew.WriteStartElement("Notes");
            //xmlnew.WriteStartElement("Pealkiri");
            //xmlnew.WriteString(PealBox.Text);
            //xmlnew.WriteEndElement();
            //xmlnew.WriteStartElement("Sisu");
            //xmlnew.WriteString(SisuBox.Text);
            //xmlnew.WriteEndElement();
            //xmlnew.WriteEndElement();
            //xmlnew.WriteEndElement();
            

            

            //xmlnew.Close();
            PealBox.Clear();
            SisuBox.Clear();




            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("file:///C:/Users/opilane/Documents/GitHub/XmlNotes/XmlHarjutus/XmlHarjutus/bin/Debug/Notes.xml");
            XmlNode node = xdoc.SelectSingleNode("/Asjad/Notes/Pealkiri");
            Peal1Box.Text = node.InnerText;
            XmlNode node1 = xdoc.SelectSingleNode("/Asjad/Notes/Sisu");
            MärkBox.Text = node1.InnerText;
        }

        private void SisuBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void märkmedcmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
     


        }
    }
}
