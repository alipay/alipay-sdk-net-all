using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JAPaymentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class JAPaymentInfo : AopObject
    {
        /// <summary>
        /// 用户是否可支付
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
