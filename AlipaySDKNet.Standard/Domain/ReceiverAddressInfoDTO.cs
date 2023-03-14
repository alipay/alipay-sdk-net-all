using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReceiverAddressInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiverAddressInfoDTO : AopObject
    {
        /// <summary>
        /// 收获地址
        /// </summary>
        [XmlElement("receiver_address")]
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 标准城市域码
        /// </summary>
        [XmlElement("receiver_division_code")]
        public string ReceiverDivisionCode { get; set; }

        /// <summary>
        /// 收货人手机号
        /// </summary>
        [XmlElement("receiver_mobile")]
        public string ReceiverMobile { get; set; }

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
    }
}
