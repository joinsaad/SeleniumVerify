using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UnitTestProject;


namespace WebDriverElementFinder
{
    public partial class Form1 : Form
    {
        SeleniumTests tests = null;
        public Form1()
        {
            tests = new SeleniumTests();
            InitializeComponent();
        }

        private void btnOpenBrowser_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtURL.Text.Length <= 0)
                {
                    MessageBox.Show("Please enter URL");
                    return;
                }
                else if (!Uri.IsWellFormedUriString(txtURL.Text, UriKind.Absolute))
                {
                    MessageBox.Show("Please enter a valid URL");
                    return;

                }

                btnHighlight.Enabled = true;
                btnOpenBrowser.Enabled = false;
                btnQuitBrowser.Enabled = true;

                tests.TestMethod1(txtURL.Text);

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

                
            }



        }

        private void btnHighlight_Click(object sender, EventArgs e)
        {

            if (!ValidateParents())
                return;

            string count = tests.HighlightElement(cmbBySelector.SelectedItem.ToString(),txtLocator.Text);
            lblElementCount.Text = count;
            int icount = 0;

            icount = ShowResult(count, icount);

            if (icount <= 0) return;
            string webDriverCode = string.Format("var WebElement = driver.FindElements(By.{0}(\"{1}\"));",
                                                 cmbBySelector.SelectedItem.ToString(), txtLocator.Text);
            txtResult.Text = webDriverCode;

            string testScriptCode = string.Format("driver.FindElement(By.{0}(\"{1}\"));",
                                                 cmbBySelector.SelectedItem.ToString(), txtLocator.Text);

            textBox1.Text = testScriptCode;


            // string webDriverCode = string.Format("")

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnHighlight.Enabled = false;
            btnOpenBrowser.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void btn_HighlightChild_Click(object sender, EventArgs e)
        {
            if (!ValidateParents())
                return;

            if (!ValidateChildrenInputs())
                return;

            


            string count = tests.HighlightChildElement(cmbBySelector.SelectedItem.ToString(), txtLocator.Text,txtIndex.Text,cmbBySelectorChild.SelectedItem.ToString(),txtLocatorChild.Text);
            lblElementCount.Text = count;
            int icount = 0;

            icount = ShowResult(count, icount);

            if (icount <= 0) return;
            StringBuilder sb = new StringBuilder();
            
            string webDriverCodeParent = string.Format("var ParentWebElement = driver.FindElements(By.{0}(\"{1}\"))[{2}];", cmbBySelector.SelectedItem.ToString(), txtLocator.Text,txtIndex.Text);
            string webDriverCodeChild = string.Format("var ChildWebElement = ParentWebElement.FindElements(By.{0}(\"{1}\"));", cmbBySelectorChild.SelectedItem.ToString(), txtLocatorChild.Text);

            sb.AppendLine(webDriverCodeParent);
            sb.AppendLine(webDriverCodeChild);
            txtResult.Text = sb.ToString();

            string testScriptCode = string.Format("driver.FindElements(By.{0}(\"{1}\"))[{2}].FindElement(By.{3}(\"{4}\"));", cmbBySelector.SelectedItem.ToString(), txtLocator.Text, txtIndex.Text,cmbBySelectorChild.SelectedItem.ToString(), txtLocatorChild.Text);

            textBox1.Text = testScriptCode;

        }

        private bool ValidateParents()
        {
            if (cmbBySelector.SelectedItem == null)
            {
                MessageBox.Show("Please select a By condition");
                return false;
            }

            if (txtLocator.Text.Length <= 0)
            {
                MessageBox.Show("Please Enter the locator string"); return false;


            }

            return true;
        }


        private bool ValidateChildrenInputs()
        {
            if (cmbBySelectorChild.SelectedItem == null)
            {
                MessageBox.Show("Please select a Child By condition");
                return false;
            }

            if (txtLocatorChild.Text.Length <= 0)
            {
                MessageBox.Show("Please Enter the Child locator string"); return false;


            }
            if (txtIndex.Text.Length <= 0)
            {
                MessageBox.Show("Please Enter Index");
                return false;
            }

            int indextocheck = 0;
            if (!int.TryParse(txtIndex.Text, out indextocheck))
            {
                MessageBox.Show("Please enter only numeric values in index");
                return false;
            }

            return true;

        }

        private int ShowResult(string count, int icount)
        {
            if (int.TryParse(count, out icount))
            {
                if (icount != 0)
                {
                    lblResult.Text = "Element(s) successfully found";
                    lblElementCount.ForeColor = Color.Green;
                }
                else
                {
                    lblResult.Text = "No Element(s) found";

                    lblElementCount.ForeColor = Color.Red;

                }
            }
            else
            {
                lblElementCount.Text = ".";
                lblResult.Text = count;
            }
            return icount;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            txtResult.SelectAll();
            txtResult.Copy();
        }

        private void btnQuitBrowser_Click(object sender, EventArgs e)
        {
            btnOpenBrowser.Enabled = true;
            btnQuitBrowser.Enabled = false;
            btnHighlight.Enabled = false;

            tests.QuitDriver();



        }

        private void btn_RemoveHighlight_Click(object sender, EventArgs e)
        {
            
            if (!ValidateParents())
                return;

            string count = tests.RemoveHighlightElement(cmbBySelector.SelectedItem.ToString(), txtLocator.Text);

           
        

        }

        //Dictionary<string, Type> importedTypes = new Dictionary<string, Type>()
        //{
        //    // OpenQA.Selenium:
        //    {"By", typeof(OpenQA.Selenium.By)},
        //    {"Keys", typeof(OpenQA.Selenium.Keys)},

        //    // OpenQA.Selenium.Interactions:
        //    {"Actions", typeof(OpenQA.Selenium.Interactions.Actions)},
        //    {"TouchActions", typeof(OpenQA.Selenium.Interactions.TouchActions)},
        //};


        //private void ImportTypes(JScriptEngine engine)
        //{
        //    foreach (KeyValuePair<string, Type> pair in importedTypes)
        //    {
        //        engine.AddHostType(pair.Key, pair.Value);
        //    }
        //}

        //IWebDriver driver;

       


        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        private void btn_executeCode_Click(object sender, EventArgs e)
        {
            try
            {
                txtLogs.Text =  tests.ExecuteScript(textBox1.Text);
            }

            catch(Exception ex)
            {
                txtLogs.Text = ex.Message;
            }
        }
    }
}
