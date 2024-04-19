using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmAgentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmAgentQueryModel : AopObject
    {
        /// <summary>
        /// 热线接入方式
        /// </summary>
        [XmlElement("answering_mode")]
        public string AnsweringMode { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 在线扩展技能组id
        /// </summary>
        [XmlArray("chat_ext_group_ids")]
        [XmlArrayItem("string")]
        public List<string> ChatExtGroupIds { get; set; }

        /// <summary>
        /// 在线技能组id
        /// </summary>
        [XmlArray("chat_group_ids")]
        [XmlArrayItem("string")]
        public List<string> ChatGroupIds { get; set; }

        /// <summary>
        /// 在线服务等级
        /// </summary>
        [XmlArray("chat_level_ids")]
        [XmlArrayItem("string")]
        public List<string> ChatLevelIds { get; set; }

        /// <summary>
        /// 客服邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 热线扩展技能组id
        /// </summary>
        [XmlArray("hotline_group_ids")]
        [XmlArrayItem("string")]
        public List<string> HotlineGroupIds { get; set; }

        /// <summary>
        /// 查询结果的页码，起始值为 1，默认值为 1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询时设置的每页记录数，最大值 100 行，默认为 10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 客服姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 客服角色id
        /// </summary>
        [XmlArray("role_ids")]
        [XmlArrayItem("string")]
        public List<string> RoleIds { get; set; }
    }
}
