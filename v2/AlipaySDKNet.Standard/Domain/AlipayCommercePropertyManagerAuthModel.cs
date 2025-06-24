using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyManagerAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyManagerAuthModel : AopObject
    {
        /// <summary>
        /// token授权类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 项目Id
        /// </summary>
        [XmlElement("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 对接方系统项目Id
        /// </summary>
        [XmlElement("out_community_id")]
        public string OutCommunityId { get; set; }
    }
}
