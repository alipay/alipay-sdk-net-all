using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenValue Data Structure.
    /// </summary>
    [Serializable]
    public class OpenValue : AopObject
    {
        /// <summary>
        /// 用户OpenID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户unionid
        /// </summary>
        [XmlElement("union_id")]
        public string UnionId { get; set; }
    }
}
