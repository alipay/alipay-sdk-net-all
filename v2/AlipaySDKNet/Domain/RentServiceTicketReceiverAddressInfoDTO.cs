using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentServiceTicketReceiverAddressInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentServiceTicketReceiverAddressInfoDTO : AopObject
    {
        /// <summary>
        /// 地址市区
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 收货地址信息
        /// </summary>
        [XmlElement("detailed_address")]
        public string DetailedAddress { get; set; }

        /// <summary>
        /// 地址区县
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 地址省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

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
