using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AutohomeContactStatusModel Data Structure.
    /// </summary>
    [Serializable]
    public class AutohomeContactStatusModel : AopObject
    {
        /// <summary>
        /// 0：否 1：是
        /// </summary>
        [XmlElement("has_contacted")]
        public long HasContacted { get; set; }

        /// <summary>
        /// 0：否 1：是 2：待定（用户未明确表示）
        /// </summary>
        [XmlElement("has_intent")]
        public long HasIntent { get; set; }
    }
}
