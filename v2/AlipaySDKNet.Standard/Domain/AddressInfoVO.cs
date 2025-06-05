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
        /// 详细地址信息
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 地址区信息
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 地址市信息
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 详细收货地址信息
        /// </summary>
        [XmlElement("detailed_address")]
        public string DetailedAddress { get; set; }

        /// <summary>
        /// 地址省份信息
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

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
