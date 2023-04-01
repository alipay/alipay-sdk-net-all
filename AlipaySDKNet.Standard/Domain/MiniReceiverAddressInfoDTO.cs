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
        /// 收货地址
        /// </summary>
        [XmlElement("detailed_address")]
        public string DetailedAddress { get; set; }

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
