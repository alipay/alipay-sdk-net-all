using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Shipping Data Structure.
    /// </summary>
    [Serializable]
    public class Shipping : AopObject
    {
        /// <summary>
        /// 收货人地址
        /// </summary>
        [XmlElement("receiver_address")]
        public PaymentAddress ReceiverAddress { get; set; }

        /// <summary>
        /// test@alipay.com
        /// </summary>
        [XmlElement("receiver_email")]
        public string ReceiverEmail { get; set; }

        /// <summary>
        /// 收货人名称
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收货人手机号
        /// </summary>
        [XmlElement("receiver_phone_no")]
        public string ReceiverPhoneNo { get; set; }
    }
}
