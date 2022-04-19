using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthorityDetailResponse Data Structure.
    /// </summary>
    [Serializable]
    public class AuthorityDetailResponse : AopObject
    {
        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
