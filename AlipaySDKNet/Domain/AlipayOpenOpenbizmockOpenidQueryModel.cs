using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOpenbizmockOpenidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOpenbizmockOpenidQueryModel : AopObject
    {
        /// <summary>
        /// openid复杂参数
        /// </summary>
        [XmlElement("json")]
        public OpenidComplex Json { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
