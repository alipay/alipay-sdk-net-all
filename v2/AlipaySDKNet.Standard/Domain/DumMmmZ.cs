using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DumMmmZ Data Structure.
    /// </summary>
    [Serializable]
    public class DumMmmZ : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("field_a")]
        public string FieldA { get; set; }

        /// <summary>
        /// gdfhsdfghsdfgh
        /// </summary>
        [XmlElement("field_b")]
        public string FieldB { get; set; }

        /// <summary>
        /// 11111
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 11111
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
