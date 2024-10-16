using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TapPayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TapPayInfo : AopObject
    {
        /// <summary>
        /// 碰一下支付的支付介质类型，标识当前支付为碰一下支付
        /// </summary>
        [XmlElement("payment_medium_type")]
        public string PaymentMediumType { get; set; }
    }
}
