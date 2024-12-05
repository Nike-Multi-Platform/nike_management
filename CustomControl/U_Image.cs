using CloudinaryDotNet;
using LibDTO;
using Nike_Shop_Management.CloudService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nike_Shop_Management.CustomControl
{
    public partial class U_Image : UserControl
    {
        CloudIService CloudIService;
        public U_Image()
        {
            InitializeComponent();
        }

        public void PaintData(ReturnRequestImgDTO returnRequestImg)
        {
            LoadImgFromUrl(returnRequestImg.Img_url);
        }

        public void LoadImgFromUrl(string path)
        {
            ServiceConfig ServiceConfig = new ServiceConfig();
            CloudIService = new CloudIService(ServiceConfig.CloudinaryCloudName, ServiceConfig.CloudinaryApiKey, ServiceConfig.CloudinaryApiSecret);
            img_product.ImageLocation = CloudIService.GetImageUrlByPublicId(path);
            img_product.ErrorImage = (Image)Properties.Resources._default;
        }
    }
}
