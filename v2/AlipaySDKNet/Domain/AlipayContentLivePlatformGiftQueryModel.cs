using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLivePlatformGiftQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLivePlatformGiftQueryModel : AopObject
    {
        /// <summary>
        /// 鉴权token
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 主播生活号ID
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }
    }
}
