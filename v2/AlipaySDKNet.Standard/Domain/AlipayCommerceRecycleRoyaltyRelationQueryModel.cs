using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleRoyaltyRelationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleRoyaltyRelationQueryModel : AopObject
    {
        /// <summary>
        /// 绑定的角色id列表
        /// </summary>
        [XmlArray("bind_role_ids")]
        [XmlArrayItem("string")]
        public List<string> BindRoleIds { get; set; }

        /// <summary>
        /// 绑定的角色loginid列表
        /// </summary>
        [XmlArray("bind_role_login_ids")]
        [XmlArrayItem("string")]
        public List<string> BindRoleLoginIds { get; set; }

        /// <summary>
        /// 绑定的角色id列表
        /// </summary>
        [XmlArray("bind_role_open_ids")]
        [XmlArrayItem("string")]
        public List<string> BindRoleOpenIds { get; set; }

        /// <summary>
        /// 绑定的角色类型
        /// </summary>
        [XmlElement("bind_role_type")]
        public string BindRoleType { get; set; }
    }
}
