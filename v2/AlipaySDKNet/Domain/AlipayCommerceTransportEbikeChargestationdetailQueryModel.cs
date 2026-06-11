using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEbikeChargestationdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEbikeChargestationdetailQueryModel : AopObject
    {
        /// <summary>
        /// 品牌编码
        /// </summary>
        [XmlElement("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 设备编号，设备唯一标识
        /// </summary>
        [XmlElement("device_no")]
        public string DeviceNo { get; set; }

        /// <summary>
        /// 合作方编码
        /// </summary>
        [XmlElement("partner_code")]
        public string PartnerCode { get; set; }
    }
}
