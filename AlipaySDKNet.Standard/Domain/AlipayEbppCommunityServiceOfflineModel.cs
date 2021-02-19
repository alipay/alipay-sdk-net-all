using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityServiceOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityServiceOfflineModel : AopObject
    {
        /// <summary>
        /// 小区短名
        /// </summary>
        [XmlElement("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// THIRD_PARTY_COMMUNITY_JIAOFEI:物业缴费 CENTRAL_SCAN_CODE_PASS:中心化扫码通行 THIRD_PARTY_SCAN_CODE_PASS:三方扫码通行
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }
    }
}
