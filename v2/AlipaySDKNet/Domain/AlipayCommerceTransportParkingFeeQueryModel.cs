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
        /// 车牌号，与停车事件唯一编码二选一必填
        /// </summary>
        [XmlElement("license_plate_no")]
        public string LicensePlateNo { get; set; }

        /// <summary>
        /// 查询渠道值
        /// </summary>
        [XmlElement("request_channel")]
        public string RequestChannel { get; set; }

        /// <summary>
        /// 停车事件唯一编码，与车牌号二选一必填
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }
    }
}
