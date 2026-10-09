using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryProjectArtifactDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryProjectArtifactDTO : AopObject
    {
        /// <summary>
        /// 制品全称
        /// </summary>
        [XmlElement("fullname")]
        public string Fullname { get; set; }

        /// <summary>
        /// 主键id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 制品来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
