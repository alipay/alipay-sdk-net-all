using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcAddressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MpcAddressInfo : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address_detail")]
        public string AddressDetail { get; set; }

        /// <summary>
        /// 地址id
        /// </summary>
        [XmlElement("address_id")]
        public string AddressId { get; set; }

        /// <summary>
        /// 四级地址code
        /// </summary>
        [XmlElement("division_code")]
        public string DivisionCode { get; set; }

        /// <summary>
        /// 收货人
        /// </summary>
        [XmlElement("receiver")]
        public string Receiver { get; set; }

        /// <summary>
        /// 收货人电话
        /// </summary>
        [XmlElement("receiver_phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 五级地址code
        /// </summary>
        [XmlElement("town_division_code")]
        public string TownDivisionCode { get; set; }
    }
}
