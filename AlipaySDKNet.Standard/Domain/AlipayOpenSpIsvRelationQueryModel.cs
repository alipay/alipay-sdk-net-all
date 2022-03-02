using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpIsvRelationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpIsvRelationQueryModel : AopObject
    {
        /// <summary>
        /// 服务市场商品Code
        /// </summary>
        [XmlElement("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 当前页码，从1开始。默认：1
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页数量，范围(1-100)。默认：10
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
