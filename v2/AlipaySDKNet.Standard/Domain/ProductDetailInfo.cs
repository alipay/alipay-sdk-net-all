using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ProductDetailInfo : AopObject
    {
        /// <summary>
        /// 产品一级类目id
        /// </summary>
        [XmlElement("category_lv_1_code")]
        public string CategoryLv1Code { get; set; }

        /// <summary>
        /// 产品一级类目名称
        /// </summary>
        [XmlElement("category_lv_1_name")]
        public string CategoryLv1Name { get; set; }

        /// <summary>
        /// 产品二级类目id
        /// </summary>
        [XmlElement("category_lv_2_code")]
        public string CategoryLv2Code { get; set; }

        /// <summary>
        /// 产品二级类目名称
        /// </summary>
        [XmlElement("category_lv_2_name")]
        public string CategoryLv2Name { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        [XmlElement("category_lv_3_code")]
        public string CategoryLv3Code { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("category_lv_3_name")]
        public string CategoryLv3Name { get; set; }

        /// <summary>
        /// 平台id
        /// </summary>
        [XmlElement("platform_id")]
        public string PlatformId { get; set; }

        /// <summary>
        /// 商品链接名称
        /// </summary>
        [XmlElement("product_title")]
        public string ProductTitle { get; set; }
    }
}
