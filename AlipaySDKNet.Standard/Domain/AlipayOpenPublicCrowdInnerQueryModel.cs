using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicCrowdInnerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicCrowdInnerQueryModel : AopObject
    {
        /// <summary>
        /// 人群来源
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 人群id
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 外部人群id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }
    }
}
