using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniReceiverAddressInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MiniReceiverAddressInfoDTO : AopObject
    {
        /// <summary>
        /// 不包含省、市、区的详细地址
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
        /// 收货地址信息
        /// </summary>
        [XmlElement("detailed_address")]
        public string DetailedAddress { get; set; }

        /// <summary>
        /// 地址的省份信息
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 标准城市域码
        /// </summary>
        [XmlElement("receiver_division_code")]
        public string ReceiverDivisionCode { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收货邮编地址
        /// </summary>
        [XmlElement("receiver_zip")]
        public string ReceiverZip { get; set; }

        /// <summary>
        /// 收货人手机号
        /// </summary>
        [XmlElement("tel_number")]
        public string TelNumber { get; set; }
    }
}
