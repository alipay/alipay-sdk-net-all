using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemStoreDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemStoreDTO : AopObject
    {
        /// <summary>
        /// 门店品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 门店类目信息 英文分隔符,隔开 ； 示例：美食,火锅,川菜/重庆火锅
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("store_address")]
        public string StoreAddress { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 门店LOGO
        /// </summary>
        [XmlElement("store_logo")]
        public string StoreLogo { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }
    }
}
