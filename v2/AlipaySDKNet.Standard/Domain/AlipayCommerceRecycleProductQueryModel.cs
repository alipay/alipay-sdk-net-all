using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleProductQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleProductQueryModel : AopObject
    {
        /// <summary>
        /// 品牌code,可从品牌查询接口获取
        /// </summary>
        [XmlElement("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 回收产品类目code
        /// </summary>
        [XmlElement("product_category_code")]
        public string ProductCategoryCode { get; set; }

        /// <summary>
        /// 产品code，传入则指定code查询商品
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }
    }
}
