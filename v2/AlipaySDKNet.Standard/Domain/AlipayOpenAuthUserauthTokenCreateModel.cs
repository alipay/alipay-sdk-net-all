using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAuthUserauthTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthUserauthTokenCreateModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 生成token所关联的scope，半角逗号分隔的列表
        /// </summary>
        [XmlElement("scopes")]
        public string Scopes { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
