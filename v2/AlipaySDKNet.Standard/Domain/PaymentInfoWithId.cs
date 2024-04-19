using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentInfoWithId Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentInfoWithId : AopObject
    {
        /// <summary>
        /// 支付单id
        /// </summary>
        [XmlArray("payment_ids")]
        [XmlArrayItem("string")]
        public List<string> PaymentIds { get; set; }

        /// <summary>
        /// 支付资金类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
