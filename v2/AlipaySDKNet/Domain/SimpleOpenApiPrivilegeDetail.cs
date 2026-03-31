using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SimpleOpenApiPrivilegeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SimpleOpenApiPrivilegeDetail : AopObject
    {
        /// <summary>
        /// 一般用于商品素材展示
        /// </summary>
        [XmlElement("display_content")]
        public string DisplayContent { get; set; }

        /// <summary>
        /// 用于描述商品信息
        /// </summary>
        [XmlElement("privilege_alias_name")]
        public string PrivilegeAliasName { get; set; }

        /// <summary>
        /// 特权核心商品id标识，不可为空
        /// </summary>
        [XmlElement("privilege_id")]
        public string PrivilegeId { get; set; }

        /// <summary>
        /// 描述商品标题或名称
        /// </summary>
        [XmlElement("privilege_name")]
        public string PrivilegeName { get; set; }
    }
}
