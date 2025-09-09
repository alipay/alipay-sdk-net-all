using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupDeliveryBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupDeliveryBatchqueryModel : AopObject
    {
        /// <summary>
        /// 当前页,表示查询的第几页。取值单位是"页"。
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询每页最大条数，支持每页最大50条。取值单位是"条"。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
