using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSceneConfigQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSceneConfigQueryModel : AopObject
    {
        /// <summary>
        /// 学校内标
        /// </summary>
        [XmlElement("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// 学校外标（不可能跟内标同时为空，都传入时已内标为准）
        /// </summary>
        [XmlElement("school_std_code")]
        public string SchoolStdCode { get; set; }
    }
}
