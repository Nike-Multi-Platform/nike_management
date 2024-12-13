using Nike_Shop_Management.CloudService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nike_Shop_Management
{
    public partial class u_pictureBoxDetail : UserControl
    {
        public int flag = 0;
        CloudIService CloudIService;
        ServiceConfig ServiceConfig;
        public u_pictureBoxDetail()
        {
            InitializeComponent();
            btnEdit.Click += BtnEdit_Click;
        }

        public string PathThumbail { get; set; }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp",
                Title = "Chọn một hình ảnh"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                Picture.Image = Image.FromFile(openFileDialog.FileName);
                PathThumbail = Path.GetFullPath(openFileDialog.FileName);
                //CloudIService.UploadImage()
            //    ClickChanged?.Invoke(sender, EventArgs.Empty);
            }
        }

        /// <summary>
        /// hàm được dùng để load hình ảnh lên picture, đơn giản là truyền đường dẫn ảnh vào rồi cho nó hiển thị né
        /// </summary>
        /// <param name="path"></param>
        public void LoadImgFromUrl(string path)
        {
            ServiceConfig = new ServiceConfig();
            CloudIService = new CloudIService(ServiceConfig.CloudinaryCloudName, ServiceConfig.CloudinaryApiKey, ServiceConfig.CloudinaryApiSecret);
            Picture.ImageLocation = CloudIService.GetImageUrlByPublicId(path);

            Picture.ErrorImage = (Image)Properties.Resources._default;

        }
        /// <summary>
        ///  hàm up ảnh lên cloudinary
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string UploadImage(string path)
        {
            ServiceConfig = new ServiceConfig();
            CloudIService = new CloudIService(ServiceConfig.CloudinaryCloudName, ServiceConfig.CloudinaryApiKey, ServiceConfig.CloudinaryApiSecret);
            return CloudIService.UploadImage(path);
        }

        public event EventHandler DeleteClicked;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            flag = 1;
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
