using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceBusinessMallCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceBusinessMallCreateModel : AopObject
    {
        /// <summary>
        /// LBS距离范围，值小于等于5000
        /// </summary>
        [XmlElement("mall_distance")]
        public string MallDistance { get; set; }

        /// <summary>
        /// 商圈纬度
        /// </summary>
        [XmlElement("mall_latitude")]
        public string MallLatitude { get; set; }

        /// <summary>
        /// 商圈经度
        /// </summary>
        [XmlElement("mall_longitude")]
        public string MallLongitude { get; set; }

        /// <summary>
        /// 商圈名称
        /// </summary>
        [XmlElement("mall_name")]
        public string MallName { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
