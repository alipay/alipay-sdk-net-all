using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityChargeproductModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityChargeproductModifyModel : AopObject
    {
        /// <summary>
        /// 小区编码
        /// </summary>
        [XmlElement("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 维护结束时间
        /// </summary>
        [XmlElement("maintaining_end")]
        public string MaintainingEnd { get; set; }

        /// <summary>
        /// 维护开始时间
        /// </summary>
        [XmlElement("maintaining_start")]
        public string MaintainingStart { get; set; }
    }
}
