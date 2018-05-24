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
using System.Xml.Linq;

namespace XmlHarjutus
{
    /// <summary>
    /// This is the mainwindows class
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// It contains all texboxes and buttons. Also shows and adds the save slots.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            märkmedcmb.Items.Add("Slot 1");
            märkmedcmb.Items.Add("Slot 2");
            märkmedcmb.Items.Add("Slot 3");
            märkmedcmb.Items.Add("Slot 4");
            märkmedcmb.Items.Add("Slot 5");

        }
        /// <summary>
        /// Loads up the xml document and then saves the notes to the specifified save slot. And then cleares the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MFbutton_Click(object sender, RoutedEventArgs e)
        {

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("Notes.xml");
            XmlNode Notes = xdoc.CreateElement("Notes");
            
            if (märkmedcmb.SelectedItem == "Slot 1")

            {

                XmlNode pealkiri1 = xdoc.CreateElement("Pealkiri1");
                pealkiri1.InnerText = PealBox.Text;
                Notes.AppendChild(pealkiri1);

                XmlNode sisu1 = xdoc.CreateElement("Sisu1");
                sisu1.InnerText = SisuBox.Text;
                Notes.AppendChild(sisu1);
                xdoc.DocumentElement.AppendChild(Notes);
                xdoc.Save("Notes.xml");
   
            }

            else if (märkmedcmb.SelectedItem == "Slot 2")
            {
                XmlNode pealkiri2 = xdoc.CreateElement("Pealkiri2");
                pealkiri2.InnerText = PealBox.Text;
                Notes.AppendChild(pealkiri2);

                XmlNode sisu2 = xdoc.CreateElement("Sisu2");
                sisu2.InnerText = SisuBox.Text;
                Notes.AppendChild(sisu2);
                xdoc.DocumentElement.AppendChild(Notes);
                xdoc.Save("Notes.xml");
            }

            else if (märkmedcmb.SelectedItem == "Slot 3")
            {  
                XmlNode pealkiri3 = xdoc.CreateElement("Pealkiri3");
                pealkiri3.InnerText = PealBox.Text;
                Notes.AppendChild(pealkiri3);

                XmlNode sisu3 = xdoc.CreateElement("Sisu3");
                sisu3.InnerText = SisuBox.Text;
                Notes.AppendChild(sisu3);
                xdoc.DocumentElement.AppendChild(Notes);
                xdoc.Save("Notes.xml");
            }

            else if (märkmedcmb.SelectedItem == "Slot 4")
            { 
                XmlNode pealkiri4 = xdoc.CreateElement("Pealkiri4");
                pealkiri4.InnerText = PealBox.Text;
                Notes.AppendChild(pealkiri4);

                XmlNode sisu4 = xdoc.CreateElement("Sisu4");
                sisu4.InnerText = SisuBox.Text;
                Notes.AppendChild(sisu4);
                xdoc.DocumentElement.AppendChild(Notes);
                xdoc.Save("Notes.xml");
            }

            else if (märkmedcmb.SelectedItem == "Slot 5")
            {
                XmlNode pealkiri5 = xdoc.CreateElement("Pealkiri5");
                pealkiri5.InnerText = PealBox.Text;
                Notes.AppendChild(pealkiri5);

                XmlNode sisu5 = xdoc.CreateElement("Sisu5");
                sisu5.InnerText = SisuBox.Text;
                Notes.AppendChild(sisu5);
                xdoc.DocumentElement.AppendChild(Notes);
                xdoc.Save("Notes.xml");
            }


            PealBox.Clear();
            SisuBox.Clear();






          
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

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// Clears the xml file and adds some elements so the program could work normaly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ss_Click(object sender, RoutedEventArgs e)
        {
            XmlWriter xmlnew = XmlWriter.Create("Notes.xml");
            xmlnew.WriteStartElement("Asjad");
            xmlnew.WriteEndElement();
            xmlnew.Close();

        }

        /// <summary>
        /// Opens up the Read window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Read read = new Read();
            read.Show();
        }
    }
}
