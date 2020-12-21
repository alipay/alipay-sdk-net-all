using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgentVO Data Structure.
    /// </summary>
    [Serializable]
    public class AgentVO : AopObject
    {
        /// <summary>
        /// 热线接入方式
        /// </summary>
        [XmlElement("answering_mode")]
        public string AnsweringMode { get; set; }

        /// <summary>
        /// 头像的oss file key
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 客服归属的部门id列表
        /// </summary>
        [XmlArray("ccs_instance_ids")]
        [XmlArrayItem("string")]
        public List<string> CcsInstanceIds { get; set; }

        /// <summary>
        /// 在线技能组信息
        /// </summary>
        [XmlArray("chat_config")]
        [XmlArrayItem("agent_chat_info")]
        public List<AgentChatInfo> ChatConfig { get; set; }

        /// <summary>
        /// 创建时间， 标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        [XmlElement("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 钉钉user_id（绑定钉钉的用户该字段非空）
        /// </summary>
        [XmlElement("dingtalk_user_id")]
        public string DingtalkUserId { get; set; }

        /// <summary>
        /// 客服邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 外部系统用户,比如金融云的用户id、支付宝账号id
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 热线技能组信息
        /// </summary>
        [XmlArray("hotline_config")]
        [XmlArrayItem("agent_hotline_info")]
        public List<AgentHotlineInfo> HotlineConfig { get; set; }

        /// <summary>
        /// 客服唯一标识id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 客服工号
        /// </summary>
        [XmlElement("job_number")]
        public string JobNumber { get; set; }

        /// <summary>
        /// 最后登录时间,标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("last_login_time")]
        public string LastLoginTime { get; set; }

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
        /// 个人简介
        /// </summary>
        [XmlElement("profile")]
        public string Profile { get; set; }

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
        /// 状态：NORMAL，DELETE
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户类型：NORMAL（普通客服），ADMIN（超级管理员，不能被删除）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 最后修改时间， 标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 最后修改人id
        /// </summary>
        [XmlElement("updater_id")]
        public string UpdaterId { get; set; }
    }
}
