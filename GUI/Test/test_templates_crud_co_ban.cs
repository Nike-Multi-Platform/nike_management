using LibBLL;
using System.Linq;
using System.Windows.Forms;

namespace Nike_Shop_Management.GUI.Test
{
    public partial class test_templates_crud_co_ban<T> : Form where T : class
    {
        GenericService<T> _service;
        public test_templates_crud_co_ban()
        {

        }
        public test_templates_crud_co_ban(GenericService<T> service)
        {
            InitializeComponent();
            _service = service;
            LoadData();
        }

        public void LoadData()
        {
            var data = _service.GetAll();
            if (data != null)
            {
                Templates_CRUD_Co_Ban<T> templates = new Templates_CRUD_Co_Ban<T>(_service);
                templates.SetTitle(_service.Name());
                templates.SetForm(data.ToList());
                templates.Size = new System.Drawing.Size(847, 864);
                this.Controls.Add(templates);
            }
        }
    }
}
