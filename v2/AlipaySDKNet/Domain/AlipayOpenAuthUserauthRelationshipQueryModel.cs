using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAuthUserauthRelationshipQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthUserauthRelationshipQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID，蚂蚁统一会员ID，如果已完成openid改造，则此值必传
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 查询授权关系所关联的scope，半角逗号分隔的列表，且不允许有重复值
        /// </summary>
        [XmlElement("scopes")]
        public string Scopes { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，如果未开启openid改造，则此值必传
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
