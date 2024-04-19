using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmAgentGetResponse.
    /// </summary>
    public class AlipayIserviceCcmAgentGetResponse : AopResponse
    {
        /// <summary>
        /// 热线接入方式： 0：话机 1：电脑耳机；2：webrtc
        /// </summary>
        [XmlElement("answering_mode")]
        public string AnsweringMode { get; set; }

        /// <summary>
        /// 头像的oss file key
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 客服关联的数据权限id列表
        /// </summary>
        [XmlArray("ccs_instance_ids")]
        [XmlArrayItem("string")]
        public List<string> CcsInstanceIds { get; set; }

        /// <summary>
        /// 客服在线信息
        /// </summary>
        [XmlArray("chat_config")]
        [XmlArrayItem("agent_chat_info")]
        public List<AgentChatInfo> ChatConfig { get; set; }

        /// <summary>
        /// 创建时间，采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd'T'HH:mm:ss'Z
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        [XmlElement("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 钉钉user_id
        /// </summary>
        [XmlElement("dingtalk_user_id")]
        public string DingtalkUserId { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 外部系统用户id,比如：金融云的用户id
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 客服热线信息
        /// </summary>
        [XmlArray("hotline_config")]
        [XmlArrayItem("agent_hotline_info")]
        public List<AgentHotlineInfo> HotlineConfig { get; set; }

        /// <summary>
        /// 客服id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [XmlElement("job_number")]
        public string JobNumber { get; set; }

        /// <summary>
        /// 客服上次登录时间 采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd'T'HH:mm:ss'Z'
        /// </summary>
        [XmlElement("last_login_time")]
        public string LastLoginTime { get; set; }

        /// <summary>
        /// 手机号
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
        /// 角色id列表
        /// </summary>
        [XmlArray("role_ids")]
        [XmlArrayItem("role_id")]
        public List<RoleId> RoleIds { get; set; }

        /// <summary>
        /// 客服状态：NORMAL，DELETE
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户类型：NORMAL（普通客服），ADMIN（超级管理员，不能被删除）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 最后修改时间，采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd'T'HH:mm:ss'Z'
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
