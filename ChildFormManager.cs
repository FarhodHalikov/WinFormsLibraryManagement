using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Academy_Library
{
    //Singelton Class realisation - (creating only one object)
    public class ChildFormManager
    {
        private static ChildFormManager? instance;
        private Form currentChildForm;

        private ChildFormManager() { }

        public static ChildFormManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChildFormManager();
                }
                return instance;
            }
        }
        
        public void OpenChildForm<T>(Panel mainPanel) where T : Form, new()
        {
            CloseCurrentChildForm();

            var childForm = new T();
            childForm.TopLevel = false;
            mainPanel.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;

            childForm.BringToFront();
            childForm.Show();
            currentChildForm = childForm;
        }

        private void CloseCurrentChildForm()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }
    }


}
