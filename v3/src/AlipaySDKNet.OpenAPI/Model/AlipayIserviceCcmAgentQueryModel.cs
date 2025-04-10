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
    /// AlipayIserviceCcmAgentQueryModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmAgentQueryModel")]
    public partial class AlipayIserviceCcmAgentQueryModel : IEquatable<AlipayIserviceCcmAgentQueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmAgentQueryModel" /> class.
        /// </summary>
        /// <param name="answeringMode">热线接入方式.</param>
        /// <param name="ccsInstanceId">部门id.</param>
        /// <param name="chatExtGroupIds">在线扩展技能组id.</param>
        /// <param name="chatGroupIds">在线技能组id.</param>
        /// <param name="chatLevelIds">在线服务等级.</param>
        /// <param name="email">客服邮箱.</param>
        /// <param name="hotlineGroupIds">热线扩展技能组id.</param>
        /// <param name="pageNum">查询结果的页码，起始值为 1，默认值为 1.</param>
        /// <param name="pageSize">分页查询时设置的每页记录数，最大值 100 行，默认为 10.</param>
        /// <param name="realName">客服姓名.</param>
        /// <param name="roleIds">客服角色id.</param>
        public AlipayIserviceCcmAgentQueryModel(string answeringMode = default(string), string ccsInstanceId = default(string), List<string> chatExtGroupIds = default(List<string>), List<string> chatGroupIds = default(List<string>), List<string> chatLevelIds = default(List<string>), string email = default(string), List<string> hotlineGroupIds = default(List<string>), int pageNum = default(int), int pageSize = default(int), string realName = default(string), List<string> roleIds = default(List<string>))
        {
            this.AnsweringMode = answeringMode;
            this.CcsInstanceId = ccsInstanceId;
            this.ChatExtGroupIds = chatExtGroupIds;
            this.ChatGroupIds = chatGroupIds;
            this.ChatLevelIds = chatLevelIds;
            this.Email = email;
            this.HotlineGroupIds = hotlineGroupIds;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.RealName = realName;
            this.RoleIds = roleIds;
        }

        /// <summary>
        /// 热线接入方式
        /// </summary>
        /// <value>热线接入方式</value>
        [DataMember(Name = "answering_mode", EmitDefaultValue = false)]
        public string AnsweringMode { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        /// <value>部门id</value>
        [DataMember(Name = "ccs_instance_id", EmitDefaultValue = false)]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 在线扩展技能组id
        /// </summary>
        /// <value>在线扩展技能组id</value>
        [DataMember(Name = "chat_ext_group_ids", EmitDefaultValue = false)]
        public List<string> ChatExtGroupIds { get; set; }

        /// <summary>
        /// 在线技能组id
        /// </summary>
        /// <value>在线技能组id</value>
        [DataMember(Name = "chat_group_ids", EmitDefaultValue = false)]
        public List<string> ChatGroupIds { get; set; }

        /// <summary>
        /// 在线服务等级
        /// </summary>
        /// <value>在线服务等级</value>
        [DataMember(Name = "chat_level_ids", EmitDefaultValue = false)]
        public List<string> ChatLevelIds { get; set; }

        /// <summary>
        /// 客服邮箱
        /// </summary>
        /// <value>客服邮箱</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// 热线扩展技能组id
        /// </summary>
        /// <value>热线扩展技能组id</value>
        [DataMember(Name = "hotline_group_ids", EmitDefaultValue = false)]
        public List<string> HotlineGroupIds { get; set; }

        /// <summary>
        /// 查询结果的页码，起始值为 1，默认值为 1
        /// </summary>
        /// <value>查询结果的页码，起始值为 1，默认值为 1</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 分页查询时设置的每页记录数，最大值 100 行，默认为 10
        /// </summary>
        /// <value>分页查询时设置的每页记录数，最大值 100 行，默认为 10</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 客服姓名
        /// </summary>
        /// <value>客服姓名</value>
        [DataMember(Name = "real_name", EmitDefaultValue = false)]
        public string RealName { get; set; }

        /// <summary>
        /// 客服角色id
        /// </summary>
        /// <value>客服角色id</value>
        [DataMember(Name = "role_ids", EmitDefaultValue = false)]
        public List<string> RoleIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmAgentQueryModel {\n");
            sb.Append("  AnsweringMode: ").Append(AnsweringMode).Append("\n");
            sb.Append("  CcsInstanceId: ").Append(CcsInstanceId).Append("\n");
            sb.Append("  ChatExtGroupIds: ").Append(ChatExtGroupIds).Append("\n");
            sb.Append("  ChatGroupIds: ").Append(ChatGroupIds).Append("\n");
            sb.Append("  ChatLevelIds: ").Append(ChatLevelIds).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  HotlineGroupIds: ").Append(HotlineGroupIds).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  RealName: ").Append(RealName).Append("\n");
            sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmAgentQueryModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmAgentQueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmAgentQueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmAgentQueryModel input)
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
                    this.CcsInstanceId == input.CcsInstanceId ||
                    (this.CcsInstanceId != null &&
                    this.CcsInstanceId.Equals(input.CcsInstanceId))
                ) && 
                (
                    this.ChatExtGroupIds == input.ChatExtGroupIds ||
                    this.ChatExtGroupIds != null &&
                    input.ChatExtGroupIds != null &&
                    this.ChatExtGroupIds.SequenceEqual(input.ChatExtGroupIds)
                ) && 
                (
                    this.ChatGroupIds == input.ChatGroupIds ||
                    this.ChatGroupIds != null &&
                    input.ChatGroupIds != null &&
                    this.ChatGroupIds.SequenceEqual(input.ChatGroupIds)
                ) && 
                (
                    this.ChatLevelIds == input.ChatLevelIds ||
                    this.ChatLevelIds != null &&
                    input.ChatLevelIds != null &&
                    this.ChatLevelIds.SequenceEqual(input.ChatLevelIds)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.HotlineGroupIds == input.HotlineGroupIds ||
                    this.HotlineGroupIds != null &&
                    input.HotlineGroupIds != null &&
                    this.HotlineGroupIds.SequenceEqual(input.HotlineGroupIds)
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    this.PageNum.Equals(input.PageNum)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
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
                if (this.CcsInstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.CcsInstanceId.GetHashCode();
                }
                if (this.ChatExtGroupIds != null)
                {
                    hashCode = (hashCode * 59) + this.ChatExtGroupIds.GetHashCode();
                }
                if (this.ChatGroupIds != null)
                {
                    hashCode = (hashCode * 59) + this.ChatGroupIds.GetHashCode();
                }
                if (this.ChatLevelIds != null)
                {
                    hashCode = (hashCode * 59) + this.ChatLevelIds.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.HotlineGroupIds != null)
                {
                    hashCode = (hashCode * 59) + this.HotlineGroupIds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                if (this.RealName != null)
                {
                    hashCode = (hashCode * 59) + this.RealName.GetHashCode();
                }
                if (this.RoleIds != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIds.GetHashCode();
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
