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
    /// AlipayIserviceCcmAgentCreateModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmAgentCreateModel")]
    public partial class AlipayIserviceCcmAgentCreateModel : IEquatable<AlipayIserviceCcmAgentCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmAgentCreateModel" /> class.
        /// </summary>
        /// <param name="answeringMode">热线接入方式，取值0，1，2.</param>
        /// <param name="ccsInstanceIds">部门id列表.</param>
        /// <param name="chatConfigs">在线技能组设置，技能组部门间隔离，此设置应与ccs_instance_ids对应.</param>
        /// <param name="creatorId">操作人客服id.</param>
        /// <param name="email">客服邮箱.</param>
        /// <param name="externalUserId">客服账号id，当user_channel&#x3D;ALIPAY时，external_user_id为支付宝账号id.</param>
        /// <param name="hotlineConfigs">热线技能组设置，技能组部门间隔离，此设置应与ccs_instance_ids对应.</param>
        /// <param name="jobNumber">客服工号，新增后不可变更。4位数字，不可重复.</param>
        /// <param name="mobile">客服手机号.</param>
        /// <param name="nickName">客服昵称.</param>
        /// <param name="realName">客服姓名.</param>
        /// <param name="roleIds">角色id列表.</param>
        /// <param name="userChannel">客服账号渠道 ALIPAY:支付宝账号.</param>
        public AlipayIserviceCcmAgentCreateModel(string answeringMode = default(string), List<string> ccsInstanceIds = default(List<string>), List<AgentChatInfo> chatConfigs = default(List<AgentChatInfo>), string creatorId = default(string), string email = default(string), string externalUserId = default(string), List<AgentHotlineInfo> hotlineConfigs = default(List<AgentHotlineInfo>), string jobNumber = default(string), string mobile = default(string), string nickName = default(string), string realName = default(string), List<RoleId> roleIds = default(List<RoleId>), string userChannel = default(string))
        {
            this.AnsweringMode = answeringMode;
            this.CcsInstanceIds = ccsInstanceIds;
            this.ChatConfigs = chatConfigs;
            this.CreatorId = creatorId;
            this.Email = email;
            this.ExternalUserId = externalUserId;
            this.HotlineConfigs = hotlineConfigs;
            this.JobNumber = jobNumber;
            this.Mobile = mobile;
            this.NickName = nickName;
            this.RealName = realName;
            this.RoleIds = roleIds;
            this.UserChannel = userChannel;
        }

        /// <summary>
        /// 热线接入方式，取值0，1，2
        /// </summary>
        /// <value>热线接入方式，取值0，1，2</value>
        [DataMember(Name = "answering_mode", EmitDefaultValue = false)]
        public string AnsweringMode { get; set; }

        /// <summary>
        /// 部门id列表
        /// </summary>
        /// <value>部门id列表</value>
        [DataMember(Name = "ccs_instance_ids", EmitDefaultValue = false)]
        public List<string> CcsInstanceIds { get; set; }

        /// <summary>
        /// 在线技能组设置，技能组部门间隔离，此设置应与ccs_instance_ids对应
        /// </summary>
        /// <value>在线技能组设置，技能组部门间隔离，此设置应与ccs_instance_ids对应</value>
        [DataMember(Name = "chat_configs", EmitDefaultValue = false)]
        public List<AgentChatInfo> ChatConfigs { get; set; }

        /// <summary>
        /// 操作人客服id
        /// </summary>
        /// <value>操作人客服id</value>
        [DataMember(Name = "creator_id", EmitDefaultValue = false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// 客服邮箱
        /// </summary>
        /// <value>客服邮箱</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// 客服账号id，当user_channel&#x3D;ALIPAY时，external_user_id为支付宝账号id
        /// </summary>
        /// <value>客服账号id，当user_channel&#x3D;ALIPAY时，external_user_id为支付宝账号id</value>
        [DataMember(Name = "external_user_id", EmitDefaultValue = false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// 热线技能组设置，技能组部门间隔离，此设置应与ccs_instance_ids对应
        /// </summary>
        /// <value>热线技能组设置，技能组部门间隔离，此设置应与ccs_instance_ids对应</value>
        [DataMember(Name = "hotline_configs", EmitDefaultValue = false)]
        public List<AgentHotlineInfo> HotlineConfigs { get; set; }

        /// <summary>
        /// 客服工号，新增后不可变更。4位数字，不可重复
        /// </summary>
        /// <value>客服工号，新增后不可变更。4位数字，不可重复</value>
        [DataMember(Name = "job_number", EmitDefaultValue = false)]
        public string JobNumber { get; set; }

        /// <summary>
        /// 客服手机号
        /// </summary>
        /// <value>客服手机号</value>
        [DataMember(Name = "mobile", EmitDefaultValue = false)]
        public string Mobile { get; set; }

        /// <summary>
        /// 客服昵称
        /// </summary>
        /// <value>客服昵称</value>
        [DataMember(Name = "nick_name", EmitDefaultValue = false)]
        public string NickName { get; set; }

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
        /// 客服账号渠道 ALIPAY:支付宝账号
        /// </summary>
        /// <value>客服账号渠道 ALIPAY:支付宝账号</value>
        [DataMember(Name = "user_channel", EmitDefaultValue = false)]
        public string UserChannel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmAgentCreateModel {\n");
            sb.Append("  AnsweringMode: ").Append(AnsweringMode).Append("\n");
            sb.Append("  CcsInstanceIds: ").Append(CcsInstanceIds).Append("\n");
            sb.Append("  ChatConfigs: ").Append(ChatConfigs).Append("\n");
            sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ExternalUserId: ").Append(ExternalUserId).Append("\n");
            sb.Append("  HotlineConfigs: ").Append(HotlineConfigs).Append("\n");
            sb.Append("  JobNumber: ").Append(JobNumber).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  NickName: ").Append(NickName).Append("\n");
            sb.Append("  RealName: ").Append(RealName).Append("\n");
            sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
            sb.Append("  UserChannel: ").Append(UserChannel).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmAgentCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmAgentCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmAgentCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmAgentCreateModel input)
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
                    this.CcsInstanceIds == input.CcsInstanceIds ||
                    this.CcsInstanceIds != null &&
                    input.CcsInstanceIds != null &&
                    this.CcsInstanceIds.SequenceEqual(input.CcsInstanceIds)
                ) && 
                (
                    this.ChatConfigs == input.ChatConfigs ||
                    this.ChatConfigs != null &&
                    input.ChatConfigs != null &&
                    this.ChatConfigs.SequenceEqual(input.ChatConfigs)
                ) && 
                (
                    this.CreatorId == input.CreatorId ||
                    (this.CreatorId != null &&
                    this.CreatorId.Equals(input.CreatorId))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.ExternalUserId == input.ExternalUserId ||
                    (this.ExternalUserId != null &&
                    this.ExternalUserId.Equals(input.ExternalUserId))
                ) && 
                (
                    this.HotlineConfigs == input.HotlineConfigs ||
                    this.HotlineConfigs != null &&
                    input.HotlineConfigs != null &&
                    this.HotlineConfigs.SequenceEqual(input.HotlineConfigs)
                ) && 
                (
                    this.JobNumber == input.JobNumber ||
                    (this.JobNumber != null &&
                    this.JobNumber.Equals(input.JobNumber))
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
                    this.UserChannel == input.UserChannel ||
                    (this.UserChannel != null &&
                    this.UserChannel.Equals(input.UserChannel))
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
                if (this.CcsInstanceIds != null)
                {
                    hashCode = (hashCode * 59) + this.CcsInstanceIds.GetHashCode();
                }
                if (this.ChatConfigs != null)
                {
                    hashCode = (hashCode * 59) + this.ChatConfigs.GetHashCode();
                }
                if (this.CreatorId != null)
                {
                    hashCode = (hashCode * 59) + this.CreatorId.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.ExternalUserId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalUserId.GetHashCode();
                }
                if (this.HotlineConfigs != null)
                {
                    hashCode = (hashCode * 59) + this.HotlineConfigs.GetHashCode();
                }
                if (this.JobNumber != null)
                {
                    hashCode = (hashCode * 59) + this.JobNumber.GetHashCode();
                }
                if (this.Mobile != null)
                {
                    hashCode = (hashCode * 59) + this.Mobile.GetHashCode();
                }
                if (this.NickName != null)
                {
                    hashCode = (hashCode * 59) + this.NickName.GetHashCode();
                }
                if (this.RealName != null)
                {
                    hashCode = (hashCode * 59) + this.RealName.GetHashCode();
                }
                if (this.RoleIds != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIds.GetHashCode();
                }
                if (this.UserChannel != null)
                {
                    hashCode = (hashCode * 59) + this.UserChannel.GetHashCode();
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
