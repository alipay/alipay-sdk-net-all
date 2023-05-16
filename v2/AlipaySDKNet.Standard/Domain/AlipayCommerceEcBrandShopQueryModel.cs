using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcBrandShopQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcBrandShopQueryModel : AopObject
    {
        /// <summary>
        /// 品牌id列表
        /// </summary>
        [XmlArray("brand_id_list")]
        [XmlArrayItem("string")]
        public List<string> BrandIdList { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 门店名称，支持模糊检索
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
