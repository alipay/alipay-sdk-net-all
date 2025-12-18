using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMultimediaTestCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMultimediaTestCreateModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
