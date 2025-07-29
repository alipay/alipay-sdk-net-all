using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleProductDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleProductDTO : AopObject
    {
        /// <summary>
        /// 品牌信息
        /// </summary>
        [XmlElement("product_brand_info")]
        public RecycleBrand ProductBrandInfo { get; set; }

        /// <summary>
        /// 产品code
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品logo图链接
        /// </summary>
        [XmlElement("product_logo_url")]
        public string ProductLogoUrl { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 污渍图链接
        /// </summary>
        [XmlElement("stain_pic_url")]
        public string StainPicUrl { get; set; }
    }
}
