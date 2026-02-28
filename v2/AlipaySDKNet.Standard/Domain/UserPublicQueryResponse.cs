using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserPublicQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class UserPublicQueryResponse : AopObject
    {
        /// <summary>
        /// 生活号授权到期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 生活号ID
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 生活号logo图片url
        /// </summary>
        [XmlElement("public_logo")]
        public string PublicLogo { get; set; }

        /// <summary>
        /// 生活号名称
        /// </summary>
        [XmlElement("public_name")]
        public string PublicName { get; set; }
    }
}
