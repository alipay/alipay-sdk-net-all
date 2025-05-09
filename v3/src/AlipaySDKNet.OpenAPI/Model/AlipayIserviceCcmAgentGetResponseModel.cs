/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2025-02-19
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AlipaySDKNet.OpenAPI.Client.OpenAPIDateConverter;

namespace AlipaySDKNet.OpenAPI.Model
{
    /// <summary>
    /// AlipayIserviceCcmAgentGetResponseModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmAgentGetResponseModel")]
    public partial class AlipayIserviceCcmAgentGetResponseModel : IEquatable<AlipayIserviceCcmAgentGetResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmAgentGetResponseModel" /> class.
        /// </summary>
        /// <param name="answeringMode">热线接入方式： 0：话机 1：电脑耳机；2：webrtc.</param>
        /// <param name="avatar">头像的oss file key.</param>
        /// <param name="ccsInstanceIds">客服关联的数据权限id列表.</param>
        /// <param name="chatConfig">客服在线信息.</param>
        /// <param name="createTime">创建时间，采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z.</param>
        /// <param name="creatorId">创建人id.</param>
        /// <param name="dingtalkUserId">钉钉user_id.</param>
        /// <param name="email">邮箱.</param>
        /// <param name="externalId">外部系统用户id,比如：金融云的用户id.</param>
        /// <param name="hotlineConfig">客服热线信息.</param>
        /// <param name="id">客服id.</param>
        /// <param name="jobNumber">工号.</param>
        /// <param name="lastLoginTime">客服上次登录时间 采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;.</param>
        /// <param name="mobile">手机号.</param>
        /// <param name="nickName">客服昵称.</param>
        /// <param name="profile">个人简介.</param>
        /// <param name="realName">客服姓名.</param>
        /// <param name="roleIds">角色id列表.</param>
        /// <param name="status">客服状态：NORMAL，DELETE.</param>
        /// <param name="type">用户类型：NORMAL（普通客服），ADMIN（超级管理员，不能被删除）.</param>
        /// <param name="updateTime">最后修改时间，采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;.</param>
        /// <param name="updaterId">最后修改人id.</param>
        public AlipayIserviceCcmAgentGetResponseModel(string answeringMode = default(string), string avatar = default(string), List<string> ccsInstanceIds = default(List<string>), List<AgentChatInfo> chatConfig = default(List<AgentChatInfo>), string createTime = default(string), string creatorId = default(string), string dingtalkUserId = default(string), string email = default(string), string externalId = default(string), List<AgentHotlineInfo> hotlineConfig = default(List<AgentHotlineInfo>), string id = default(string), string jobNumber = default(string), string lastLoginTime = default(string), string mobile = default(string), string nickName = default(string), string profile = default(string), string realName = default(string), List<RoleId> roleIds = default(List<RoleId>), string status = default(string), string type = default(string), string updateTime = default(string), string updaterId = default(string))
        {
            this.AnsweringMode = answeringMode;
            this.Avatar = avatar;
            this.CcsInstanceIds = ccsInstanceIds;
            this.ChatConfig = chatConfig;
            this.CreateTime = createTime;
            this.CreatorId = creatorId;
            this.DingtalkUserId = dingtalkUserId;
            this.Email = email;
            this.ExternalId = externalId;
            this.HotlineConfig = hotlineConfig;
            this.Id = id;
            this.JobNumber = jobNumber;
            this.LastLoginTime = lastLoginTime;
            this.Mobile = mobile;
            this.NickName = nickName;
            this.Profile = profile;
            this.RealName = realName;
            this.RoleIds = roleIds;
            this.Status = status;
            this.Type = type;
            this.UpdateTime = updateTime;
            this.UpdaterId = updaterId;
        }

        /// <summary>
        /// 热线接入方式： 0：话机 1：电脑耳机；2：webrtc
        /// </summary>
        /// <value>热线接入方式： 0：话机 1：电脑耳机；2：webrtc</value>
        [DataMember(Name = "answering_mode", EmitDefaultValue = false)]
        public string AnsweringMode { get; set; }

        /// <summary>
        /// 头像的oss file key
        /// </summary>
        /// <value>头像的oss file key</value>
        [DataMember(Name = "avatar", EmitDefaultValue = false)]
        public string Avatar { get; set; }

        /// <summary>
        /// 客服关联的数据权限id列表
        /// </summary>
        /// <value>客服关联的数据权限id列表</value>
        [DataMember(Name = "ccs_instance_ids", EmitDefaultValue = false)]
        public List<string> CcsInstanceIds { get; set; }

        /// <summary>
        /// 客服在线信息
        /// </summary>
        /// <value>客服在线信息</value>
        [DataMember(Name = "chat_config", EmitDefaultValue = false)]
        public List<AgentChatInfo> ChatConfig { get; set; }

        /// <summary>
        /// 创建时间，采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z
        /// </summary>
        /// <value>创建时间，采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z</value>
        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        /// <value>创建人id</value>
        [DataMember(Name = "creator_id", EmitDefaultValue = false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// 钉钉user_id
        /// </summary>
        /// <value>钉钉user_id</value>
        [DataMember(Name = "dingtalk_user_id", EmitDefaultValue = false)]
        public string DingtalkUserId { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        /// <value>邮箱</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// 外部系统用户id,比如：金融云的用户id
        /// </summary>
        /// <value>外部系统用户id,比如：金融云的用户id</value>
        [DataMember(Name = "external_id", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// 客服热线信息
        /// </summary>
        /// <value>客服热线信息</value>
        [DataMember(Name = "hotline_config", EmitDefaultValue = false)]
        public List<AgentHotlineInfo> HotlineConfig { get; set; }

        /// <summary>
        /// 客服id
        /// </summary>
        /// <value>客服id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        /// <value>工号</value>
        [DataMember(Name = "job_number", EmitDefaultValue = false)]
        public string JobNumber { get; set; }

        /// <summary>
        /// 客服上次登录时间 采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        /// </summary>
        /// <value>客服上次登录时间 采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;</value>
        [DataMember(Name = "last_login_time", EmitDefaultValue = false)]
        public string LastLoginTime { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        /// <value>手机号</value>
        [DataMember(Name = "mobile", EmitDefaultValue = false)]
        public string Mobile { get; set; }

        /// <summary>
        /// 客服昵称
        /// </summary>
        /// <value>客服昵称</value>
        [DataMember(Name = "nick_name", EmitDefaultValue = false)]
        public string NickName { get; set; }

        /// <summary>
        /// 个人简介
        /// </summary>
        /// <value>个人简介</value>
        [DataMember(Name = "profile", EmitDefaultValue = false)]
        public string Profile { get; set; }

        /// <summary>
        /// 客服姓名
        /// </summary>
        /// <value>客服姓名</value>
        [DataMember(Name = "real_name", EmitDefaultValue = false)]
        public string RealName { get; set; }

        /// <summary>
        /// 角色id列表
        /// </summary>
        /// <value>角色id列表</value>
        [DataMember(Name = "role_ids", EmitDefaultValue = false)]
        public List<RoleId> RoleIds { get; set; }

        /// <summary>
        /// 客服状态：NORMAL，DELETE
        /// </summary>
        /// <value>客服状态：NORMAL，DELETE</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 用户类型：NORMAL（普通客服），ADMIN（超级管理员，不能被删除）
        /// </summary>
        /// <value>用户类型：NORMAL（普通客服），ADMIN（超级管理员，不能被删除）</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// 最后修改时间，采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        /// </summary>
        /// <value>最后修改时间，采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;</value>
        [DataMember(Name = "update_time", EmitDefaultValue = false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 最后修改人id
        /// </summary>
        /// <value>最后修改人id</value>
        [DataMember(Name = "updater_id", EmitDefaultValue = false)]
        public string UpdaterId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmAgentGetResponseModel {\n");
            sb.Append("  AnsweringMode: ").Append(AnsweringMode).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  CcsInstanceIds: ").Append(CcsInstanceIds).Append("\n");
            sb.Append("  ChatConfig: ").Append(ChatConfig).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  DingtalkUserId: ").Append(DingtalkUserId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  HotlineConfig: ").Append(HotlineConfig).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  JobNumber: ").Append(JobNumber).Append("\n");
            sb.Append("  LastLoginTime: ").Append(LastLoginTime).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  NickName: ").Append(NickName).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  RealName: ").Append(RealName).Append("\n");
            sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  UpdaterId: ").Append(UpdaterId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlipayIserviceCcmAgentGetResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmAgentGetResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmAgentGetResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmAgentGetResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AnsweringMode == input.AnsweringMode ||
                    (this.AnsweringMode != null &&
                    this.AnsweringMode.Equals(input.AnsweringMode))
                ) && 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
                ) && 
                (
                    this.CcsInstanceIds == input.CcsInstanceIds ||
                    this.CcsInstanceIds != null &&
                    input.CcsInstanceIds != null &&
                    this.CcsInstanceIds.SequenceEqual(input.CcsInstanceIds)
                ) && 
                (
                    this.ChatConfig == input.ChatConfig ||
                    this.ChatConfig != null &&
                    input.ChatConfig != null &&
                    this.ChatConfig.SequenceEqual(input.ChatConfig)
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.CreatorId == input.CreatorId ||
                    (this.CreatorId != null &&
                    this.CreatorId.Equals(input.CreatorId))
                ) && 
                (
                    this.DingtalkUserId == input.DingtalkUserId ||
                    (this.DingtalkUserId != null &&
                    this.DingtalkUserId.Equals(input.DingtalkUserId))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.HotlineConfig == input.HotlineConfig ||
                    this.HotlineConfig != null &&
                    input.HotlineConfig != null &&
                    this.HotlineConfig.SequenceEqual(input.HotlineConfig)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.JobNumber == input.JobNumber ||
                    (this.JobNumber != null &&
                    this.JobNumber.Equals(input.JobNumber))
                ) && 
                (
                    this.LastLoginTime == input.LastLoginTime ||
                    (this.LastLoginTime != null &&
                    this.LastLoginTime.Equals(input.LastLoginTime))
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    (this.Mobile != null &&
                    this.Mobile.Equals(input.Mobile))
                ) && 
                (
                    this.NickName == input.NickName ||
                    (this.NickName != null &&
                    this.NickName.Equals(input.NickName))
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
                ) && 
                (
                    this.RealName == input.RealName ||
                    (this.RealName != null &&
                    this.RealName.Equals(input.RealName))
                ) && 
                (
                    this.RoleIds == input.RoleIds ||
                    this.RoleIds != null &&
                    input.RoleIds != null &&
                    this.RoleIds.SequenceEqual(input.RoleIds)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.UpdaterId == input.UpdaterId ||
                    (this.UpdaterId != null &&
                    this.UpdaterId.Equals(input.UpdaterId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AnsweringMode != null)
                {
                    hashCode = (hashCode * 59) + this.AnsweringMode.GetHashCode();
                }
                if (this.Avatar != null)
                {
                    hashCode = (hashCode * 59) + this.Avatar.GetHashCode();
                }
                if (this.CcsInstanceIds != null)
                {
                    hashCode = (hashCode * 59) + this.CcsInstanceIds.GetHashCode();
                }
                if (this.ChatConfig != null)
                {
                    hashCode = (hashCode * 59) + this.ChatConfig.GetHashCode();
                }
                if (this.CreateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreateTime.GetHashCode();
                }
                if (this.CreatorId != null)
                {
                    hashCode = (hashCode * 59) + this.CreatorId.GetHashCode();
                }
                if (this.DingtalkUserId != null)
                {
                    hashCode = (hashCode * 59) + this.DingtalkUserId.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalId.GetHashCode();
                }
                if (this.HotlineConfig != null)
                {
                    hashCode = (hashCode * 59) + this.HotlineConfig.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.JobNumber != null)
                {
                    hashCode = (hashCode * 59) + this.JobNumber.GetHashCode();
                }
                if (this.LastLoginTime != null)
                {
                    hashCode = (hashCode * 59) + this.LastLoginTime.GetHashCode();
                }
                if (this.Mobile != null)
                {
                    hashCode = (hashCode * 59) + this.Mobile.GetHashCode();
                }
                if (this.NickName != null)
                {
                    hashCode = (hashCode * 59) + this.NickName.GetHashCode();
                }
                if (this.Profile != null)
                {
                    hashCode = (hashCode * 59) + this.Profile.GetHashCode();
                }
                if (this.RealName != null)
                {
                    hashCode = (hashCode * 59) + this.RealName.GetHashCode();
                }
                if (this.RoleIds != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIds.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.UpdateTime != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateTime.GetHashCode();
                }
                if (this.UpdaterId != null)
                {
                    hashCode = (hashCode * 59) + this.UpdaterId.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
