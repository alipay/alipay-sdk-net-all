using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceUserquerybybusvcidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceUserquerybybusvcidQueryModel : AopObject
    {
        /// <summary>
        /// antbuserviceID
        /// </summary>
        [XmlElement("busvc_id")]
        public string BusvcId { get; set; }

        /// <summary>
        /// 是否查询组织架构信息
        /// </summary>
        [XmlElement("query_org_node")]
        public bool QueryOrgNode { get; set; }

        /// <summary>
        /// 是否查询角色信息
        /// </summary>
        [XmlElement("query_role")]
        public bool QueryRole { get; set; }

        /// <summary>
        /// 是否查询用户资源信息
        /// </summary>
        [XmlElement("query_user_resource")]
        public bool QueryUserResource { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
