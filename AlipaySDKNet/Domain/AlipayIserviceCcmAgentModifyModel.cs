using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmAgentModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmAgentModifyModel : AopObject
    {
        /// <summary>
        /// 热线接入方式，取值0，1，2
        /// </summary>
        [XmlElement("answering_mode")]
        public string AnsweringMode { get; set; }

        /// <summary>
        /// 部门id列表
        /// </summary>
        [XmlArray("ccs_instance_ids")]
        [XmlArrayItem("string")]
        public List<string> CcsInstanceIds { get; set; }

        /// <summary>
        /// 在线技能组设置，技能组部门间隔离，此设置应与ccs_instance_ids对应
        /// </summary>
        [XmlArray("chat_configs")]
        [XmlArrayItem("agent_chat_info")]
        public List<AgentChatInfo> ChatConfigs { get; set; }

        /// <summary>
        /// 客服邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 热线技能组设置，技能组部门间隔离，此设置应与ccs_instance_ids对应
        /// </summary>
        [XmlArray("hotline_configs")]
        [XmlArrayItem("agent_hotline_info")]
        public List<AgentHotlineInfo> HotlineConfigs { get; set; }

        /// <summary>
        /// 客服id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 客服手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 客服昵称
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 客服姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 客服角色id列表
        /// </summary>
        [XmlArray("role_ids")]
        [XmlArrayItem("role_id")]
        public List<RoleId> RoleIds { get; set; }

        /// <summary>
        /// 操作人客服id
        /// </summary>
        [XmlElement("updater_id")]
        public string UpdaterId { get; set; }
    }
}
