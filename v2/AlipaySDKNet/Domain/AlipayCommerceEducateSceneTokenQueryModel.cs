using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSceneTokenQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSceneTokenQueryModel : AopObject
    {
        /// <summary>
        /// 用于查询用户详情的凭证
        /// </summary>
        [XmlElement("user_token")]
        public string UserToken { get; set; }
    }
}
