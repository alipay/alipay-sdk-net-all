using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncCollectreceiptReceiptQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncCollectreceiptReceiptQueryModel : AopObject
    {
        /// <summary>
        /// 收款单openapi查询Order
        /// </summary>
        [XmlElement("collect_receipt_query_open_api_order")]
        public CollectReceiptQueryOpenApiOrder CollectReceiptQueryOpenApiOrder { get; set; }
    }
}
