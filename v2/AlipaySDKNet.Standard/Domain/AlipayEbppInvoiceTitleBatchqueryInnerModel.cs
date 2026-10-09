using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTitleBatchqueryInnerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceTitleBatchqueryInnerModel : AopObject
    {
        /// <summary>
        /// 抬头所属支付宝用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 抬头所属支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
