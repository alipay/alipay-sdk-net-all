using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportParkingFeeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportParkingFeeQueryModel : AopObject
    {
        /// <summary>
        /// 查询的车牌号
        /// </summary>
        [XmlElement("license_plate_no")]
        public string LicensePlateNo { get; set; }

        /// <summary>
        /// 查询渠道值
        /// </summary>
        [XmlElement("request_channel")]
        public string RequestChannel { get; set; }
    }
}
