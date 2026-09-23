using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentOrderShipperAddressInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentOrderShipperAddressInfoVO : AopObject
    {
        /// <summary>
        /// 发货地址信息
        /// </summary>
        [XmlElement("detailed_shipper_address")]
        public string DetailedShipperAddress { get; set; }

        /// <summary>
        /// 发货人姓名
        /// </summary>
        [XmlElement("shipper_name")]
        public string ShipperName { get; set; }

        /// <summary>
        /// 发货人手机号
        /// </summary>
        [XmlElement("shipper_tel_number")]
        public string ShipperTelNumber { get; set; }
    }
}
