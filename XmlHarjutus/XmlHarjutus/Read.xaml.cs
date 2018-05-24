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
using System.Windows.Shapes;
using System.IO;
using System.Xml;

namespace XmlHarjutus
{
    /// <summary>
    /// This is the read window class
    /// </summary>
    public partial class Read : Window
    {
        /// <summary>
        /// Loads up the XML document and uses the XMLReader method to read the document.
        /// </summary>
        public Read()
        {
            
            InitializeComponent();

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("Notes.xml");
            XmlTextReader reader = new XmlTextReader("Notes.xml");
            reader.MoveToContent();
            XmlNode nodes = xdoc.ReadNode(reader);
            xdoc.DocumentElement.AppendChild(nodes);
            readtxt.Text = nodes.InnerText;






        }

        private void readtxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
