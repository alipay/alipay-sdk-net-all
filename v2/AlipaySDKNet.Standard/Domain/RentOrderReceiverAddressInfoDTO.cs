using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentOrderReceiverAddressInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentOrderReceiverAddressInfoDTO : AopObject
    {
        /// <summary>
        /// 收货地址信息
        /// </summary>
        [XmlElement("detailed_address")]
        public string DetailedAddress { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收货人手机号
        /// </summary>
        [XmlElement("tel_number")]
        public string TelNumber { get; set; }
    }
}
