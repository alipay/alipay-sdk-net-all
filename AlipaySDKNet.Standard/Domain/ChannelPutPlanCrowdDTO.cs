using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChannelPutPlanCrowdDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ChannelPutPlanCrowdDTO : AopObject
    {
        /// <summary>
        /// 外部人群码
        /// </summary>
        [XmlElement("ext_crowd_key")]
        public string ExtCrowdKey { get; set; }

        /// <summary>
        /// 人群 id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 人群名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
