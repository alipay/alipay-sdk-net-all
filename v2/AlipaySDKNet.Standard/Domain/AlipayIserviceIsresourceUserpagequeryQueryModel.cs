using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceUserpagequeryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceUserpagequeryQueryModel : AopObject
    {
        /// <summary>
        /// antbuserviceid
        /// </summary>
        [XmlElement("busvc_id")]
        public string BusvcId { get; set; }

        /// <summary>
        /// 旧平台用户id列表
        /// </summary>
        [XmlArray("clv_user_ids")]
        [XmlArrayItem("number")]
        public List<long> ClvUserIds { get; set; }

        /// <summary>
        /// 用工类型code
        /// </summary>
        [XmlElement("employee_type_code")]
        public string EmployeeTypeCode { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 组织节点id
        /// </summary>
        [XmlElement("org_node_id")]
        public string OrgNodeId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 是否查询关联账户信息
        /// </summary>
        [XmlElement("query_ref_account")]
        public bool QueryRefAccount { get; set; }

        /// <summary>
        /// 是否查询角色信息
        /// </summary>
        [XmlElement("query_role")]
        public bool QueryRole { get; set; }

        /// <summary>
        /// 技能组id
        /// </summary>
        [XmlElement("skill_group_id")]
        public string SkillGroupId { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
