using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniTipsDeliveryBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniTipsDeliveryBatchqueryModel : AopObject
    {
        /// <summary>
        /// 每页记录条数，最小1，最大20
        /// </summary>
        [XmlElement("page_number")]
        public string PageNumber { get; set; }

        /// <summary>
        /// 查询的页数，从1开始，最大1000
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
