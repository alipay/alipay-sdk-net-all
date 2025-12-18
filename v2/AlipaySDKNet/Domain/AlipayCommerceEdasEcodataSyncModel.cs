using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEdasEcodataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEdasEcodataSyncModel : AopObject
    {
        /// <summary>
        /// 数据场景代码
        /// </summary>
        [XmlElement("data_scene_code")]
        public string DataSceneCode { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("industry_id")]
        public string IndustryId { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 景区数据
        /// </summary>
        [XmlElement("location_data")]
        public LocationData LocationData { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }
    }
}
