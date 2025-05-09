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
    /// AlipayIserviceCcmOlsChatrecordQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmOlsChatrecordQueryResponseModel")]
    public partial class AlipayIserviceCcmOlsChatrecordQueryResponseModel : IEquatable<AlipayIserviceCcmOlsChatrecordQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmOlsChatrecordQueryResponseModel" /> class.
        /// </summary>
        /// <param name="agentId">客服id.</param>
        /// <param name="agentName">客服昵称.</param>
        /// <param name="categories">多个层级类目信息.</param>
        /// <param name="groupId">在线技能组id.</param>
        /// <param name="groupName">在线技能组名称.</param>
        /// <param name="memo">备注信息.</param>
        /// <param name="messages">聊天消息列表.</param>
        /// <param name="satisfaction">满意度。 0：非常满意 1：满意 2：一般 3：不满意 4：非常不满意.</param>
        /// <param name="status">服务记录状态。1：待处理 2：暂存 3：完结 4：废除 5：无效 6：未知.</param>
        /// <param name="talkDuration">在线服务时长，单位秒.</param>
        /// <param name="visitorProvince">访客归属地.</param>
        public AlipayIserviceCcmOlsChatrecordQueryResponseModel(string agentId = default(string), string agentName = default(string), string categories = default(string), string groupId = default(string), string groupName = default(string), string memo = default(string), List<ChatMessage> messages = default(List<ChatMessage>), string satisfaction = default(string), string status = default(string), int talkDuration = default(int), string visitorProvince = default(string))
        {
            this.AgentId = agentId;
            this.AgentName = agentName;
            this.Categories = categories;
            this.GroupId = groupId;
            this.GroupName = groupName;
            this.Memo = memo;
            this.Messages = messages;
            this.Satisfaction = satisfaction;
            this.Status = status;
            this.TalkDuration = talkDuration;
            this.VisitorProvince = visitorProvince;
        }

        /// <summary>
        /// 客服id
        /// </summary>
        /// <value>客服id</value>
        [DataMember(Name = "agent_id", EmitDefaultValue = false)]
        public string AgentId { get; set; }

        /// <summary>
        /// 客服昵称
        /// </summary>
        /// <value>客服昵称</value>
        [DataMember(Name = "agent_name", EmitDefaultValue = false)]
        public string AgentName { get; set; }

        /// <summary>
        /// 多个层级类目信息
        /// </summary>
        /// <value>多个层级类目信息</value>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public string Categories { get; set; }

        /// <summary>
        /// 在线技能组id
        /// </summary>
        /// <value>在线技能组id</value>
        [DataMember(Name = "group_id", EmitDefaultValue = false)]
        public string GroupId { get; set; }

        /// <summary>
        /// 在线技能组名称
        /// </summary>
        /// <value>在线技能组名称</value>
        [DataMember(Name = "group_name", EmitDefaultValue = false)]
        public string GroupName { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        /// <value>备注信息</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 聊天消息列表
        /// </summary>
        /// <value>聊天消息列表</value>
        [DataMember(Name = "messages", EmitDefaultValue = false)]
        public List<ChatMessage> Messages { get; set; }

        /// <summary>
        /// 满意度。 0：非常满意 1：满意 2：一般 3：不满意 4：非常不满意
        /// </summary>
        /// <value>满意度。 0：非常满意 1：满意 2：一般 3：不满意 4：非常不满意</value>
        [DataMember(Name = "satisfaction", EmitDefaultValue = false)]
        public string Satisfaction { get; set; }

        /// <summary>
        /// 服务记录状态。1：待处理 2：暂存 3：完结 4：废除 5：无效 6：未知
        /// </summary>
        /// <value>服务记录状态。1：待处理 2：暂存 3：完结 4：废除 5：无效 6：未知</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 在线服务时长，单位秒
        /// </summary>
        /// <value>在线服务时长，单位秒</value>
        [DataMember(Name = "talk_duration", EmitDefaultValue = false)]
        public int TalkDuration { get; set; }

        /// <summary>
        /// 访客归属地
        /// </summary>
        /// <value>访客归属地</value>
        [DataMember(Name = "visitor_province", EmitDefaultValue = false)]
        public string VisitorProvince { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmOlsChatrecordQueryResponseModel {\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  AgentName: ").Append(AgentName).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Satisfaction: ").Append(Satisfaction).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TalkDuration: ").Append(TalkDuration).Append("\n");
            sb.Append("  VisitorProvince: ").Append(VisitorProvince).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmOlsChatrecordQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmOlsChatrecordQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmOlsChatrecordQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmOlsChatrecordQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgentId == input.AgentId ||
                    (this.AgentId != null &&
                    this.AgentId.Equals(input.AgentId))
                ) && 
                (
                    this.AgentName == input.AgentName ||
                    (this.AgentName != null &&
                    this.AgentName.Equals(input.AgentName))
                ) && 
                (
                    this.Categories == input.Categories ||
                    (this.Categories != null &&
                    this.Categories.Equals(input.Categories))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    input.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
                ) && 
                (
                    this.Satisfaction == input.Satisfaction ||
                    (this.Satisfaction != null &&
                    this.Satisfaction.Equals(input.Satisfaction))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TalkDuration == input.TalkDuration ||
                    this.TalkDuration.Equals(input.TalkDuration)
                ) && 
                (
                    this.VisitorProvince == input.VisitorProvince ||
                    (this.VisitorProvince != null &&
                    this.VisitorProvince.Equals(input.VisitorProvince))
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
                if (this.AgentId != null)
                {
                    hashCode = (hashCode * 59) + this.AgentId.GetHashCode();
                }
                if (this.AgentName != null)
                {
                    hashCode = (hashCode * 59) + this.AgentName.GetHashCode();
                }
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
                }
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.GroupName != null)
                {
                    hashCode = (hashCode * 59) + this.GroupName.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.Messages != null)
                {
                    hashCode = (hashCode * 59) + this.Messages.GetHashCode();
                }
                if (this.Satisfaction != null)
                {
                    hashCode = (hashCode * 59) + this.Satisfaction.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TalkDuration.GetHashCode();
                if (this.VisitorProvince != null)
                {
                    hashCode = (hashCode * 59) + this.VisitorProvince.GetHashCode();
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
