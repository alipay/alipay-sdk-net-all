using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppUnishopItemlistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppUnishopItemlistQueryModel : AopObject
    {
        /// <summary>
        /// 团购门店id
        /// </summary>
        [XmlElement("a_shop_id")]
        public string AShopId { get; set; }

        /// <summary>
        /// 分批查询的页码，必填
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页的数据量大小，单位条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
