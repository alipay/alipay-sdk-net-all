using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AddressInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class AddressInfoVO : AopObject
    {
        /// <summary>
        /// 详细收货地址信息
        /// </summary>
        [XmlElement("detailed_address")]
        public string DetailedAddress { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收件人手机号码
        /// </summary>
        [XmlElement("tel_number")]
        public string TelNumber { get; set; }
    }
}
