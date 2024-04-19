using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncOutputinvoiceApplyModifyResponse.
    /// </summary>
    public class AlipayBossFncOutputinvoiceApplyModifyResponse : AopResponse
    {
        /// <summary>
        /// 开票申请的id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
