using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerPncQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerPncQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的openId。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 车档案ID
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }

        /// <summary>
        /// 车架号ID
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
    }
}
