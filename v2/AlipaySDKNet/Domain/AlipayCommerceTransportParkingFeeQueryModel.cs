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
        /// 用户唯一身份ID
        /// </summary>
        [XmlElement("identity_id")]
        public string IdentityId { get; set; }

        /// <summary>
        /// 用户身份ID类型
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

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
