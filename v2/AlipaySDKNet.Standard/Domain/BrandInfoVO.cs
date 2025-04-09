using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class BrandInfoVO : AopObject
    {
        /// <summary>
        /// 商品所属的品牌ID
        /// </summary>
        [XmlElement("item_brand_id")]
        public string ItemBrandId { get; set; }

        /// <summary>
        /// 商品所属的品牌名称
        /// </summary>
        [XmlElement("item_brand_name")]
        public string ItemBrandName { get; set; }
    }
}
