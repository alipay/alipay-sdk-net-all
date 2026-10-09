using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrafficAirTicketPassengerEncryptedInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TrafficAirTicketPassengerEncryptedInfo : AopObject
    {
        /// <summary>
        /// 乘机人证件号，与证件类型cert_type对应的号码，如示例中的是身份证号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 乘机人证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 乘机人手机号码
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 对称加密过的乘机人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否本人，该乘机人是否为订单的下单人 1. true-该乘机人是订单的下单人 2. false-该乘机人不是订单的下单人
        /// </summary>
        [XmlElement("self")]
        public bool Self { get; set; }
    }
}
