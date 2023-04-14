using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenIdValue Data Structure.
    /// </summary>
    [Serializable]
    public class OpenIdValue : AopObject
    {
        /// <summary>
        /// 用户OpenID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户UnionID
        /// </summary>
        [XmlElement("union_id")]
        public string UnionId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
