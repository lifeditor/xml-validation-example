using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace XmlCheck
{
    public partial class formCheck : Form
    {
        public formCheck()
        {
            InitializeComponent();
        }

        private void buttonCheckClick(object sender, EventArgs e)
        {
            XmlValidator v = new XmlValidator(tbXmlFile.Text, tbXsdFile.Text);
            v.Validate();

            string error = v.ErrorMessage;

            MessageBox.Show(this, (error.Length > 0) ? error : "Успеx: xml-файл соответствует xsd-файлу");

        }

        private void buttonOpenXmlFileClick(object sender, EventArgs e)
        {
            tbXmlFile.Text = GetFileName();
        }

        public string GetFileName()
        {
            return (openFileDialog.ShowDialog() == DialogResult.OK) ? openFileDialog.FileName: String.Empty;
        }

        private void buttonOpenXsdFileClick(object sender, EventArgs e)
        {
            tbXsdFile.Text = GetFileName();
        }
    }

    public class XmlValidator
    {
        string xmlFileName;
        string xsdFileName;

        public XmlValidator(string xmlFileName, string xsdFileName)
        {
            this.xmlFileName = xmlFileName;
            this.xsdFileName = xsdFileName;
            eMessage = String.Empty;
        }

        static string eMessage = string.Empty;
        public string ErrorMessage
        {
            get { return eMessage; }
        }

        public static void ValidationHandler(object sender, ValidationEventArgs args)
        {
            eMessage += args.Message + "\r\n";
        }

        public void Validate()
        {
            try
            {
                XmlTextReader schemaReader = new XmlTextReader(xsdFileName);
                XmlSchemaCollection schema = new XmlSchemaCollection();
                schema.Add(null, schemaReader);

                XmlTextReader xmlReader = new XmlTextReader(xmlFileName);
                XmlValidatingReader vReader = new XmlValidatingReader(xmlReader);
                vReader.Schemas.Add(schema);
                vReader.ValidationType = ValidationType.Schema;
                vReader.ValidationEventHandler +=
                    new ValidationEventHandler(ValidationHandler);

                while (vReader.Read());
                vReader.Close();
            }
            catch (Exception e)
            {
                eMessage += e.Message + "\r\n";
            }
        }
    }
}
