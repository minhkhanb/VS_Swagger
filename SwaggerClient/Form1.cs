using libTools;
using SvcRest;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwaggerClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAllValues_Click(object sender, EventArgs e)
        {
            SvcRestClient client = new SvcRestClient(new Uri("http://localhost/swagger/"), new AnonymousCredential());
            var result = client.Values.Get();

            foreach (var x in result)
            {
                MessageBox.Show(x);
            }

        }

        private void cmdValue_Click(object sender, EventArgs e)
        {
            SvcRestClient client =
                  new SvcRestClient(new Uri("http://localhost/swagger/"),
                    new AnonymousCredential());
            var result = client.Values.GetByid(1);
            MessageBox.Show(result);
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            SvcRestClient client =
                  new SvcRestClient(new Uri("http://localhost/webDemo"),
                    new AnonymousCredential());
            client.Values.PutByidvalue(1, "new value");
            MessageBox.Show("change completed");
        }
    }
}
