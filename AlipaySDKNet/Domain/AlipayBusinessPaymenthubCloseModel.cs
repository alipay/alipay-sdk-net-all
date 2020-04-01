using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBusinessPaymenthubCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessPaymenthubCloseModel : AopObject
    {
        /// <summary>
        /// 支付id，支付宝针对每一笔支付请求生成的唯一支付凭证
        /// </summary>
        [XmlElement("payment_id")]
        public string PaymentId { get; set; }
    }
}
