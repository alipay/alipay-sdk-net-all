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
    /// AlipayOpenSpIsvSignauthQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSpIsvSignauthQueryResponseModel")]
    public partial class AlipayOpenSpIsvSignauthQueryResponseModel : IEquatable<AlipayOpenSpIsvSignauthQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSpIsvSignauthQueryResponseModel" /> class.
        /// </summary>
        /// <param name="orderId">签约授权一体化订单ID.</param>
        /// <param name="status">签约授权一体化订单状态 INIT:初始化 UNCONFIRM:待确认 FAILURE:失败 FINISH:成功.</param>
        /// <param name="taskInfos">签约授权一体化订单子任务单信息.</param>
        public AlipayOpenSpIsvSignauthQueryResponseModel(string orderId = default(string), string status = default(string), List<SubTaskInfo> taskInfos = default(List<SubTaskInfo>))
        {
            this.OrderId = orderId;
            this.Status = status;
            this.TaskInfos = taskInfos;
        }

        /// <summary>
        /// 签约授权一体化订单ID
        /// </summary>
        /// <value>签约授权一体化订单ID</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// 签约授权一体化订单状态 INIT:初始化 UNCONFIRM:待确认 FAILURE:失败 FINISH:成功
        /// </summary>
        /// <value>签约授权一体化订单状态 INIT:初始化 UNCONFIRM:待确认 FAILURE:失败 FINISH:成功</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 签约授权一体化订单子任务单信息
        /// </summary>
        /// <value>签约授权一体化订单子任务单信息</value>
        [DataMember(Name = "task_infos", EmitDefaultValue = false)]
        public List<SubTaskInfo> TaskInfos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSpIsvSignauthQueryResponseModel {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TaskInfos: ").Append(TaskInfos).Append("\n");
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
            return this.Equals(input as AlipayOpenSpIsvSignauthQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSpIsvSignauthQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSpIsvSignauthQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSpIsvSignauthQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TaskInfos == input.TaskInfos ||
                    this.TaskInfos != null &&
                    input.TaskInfos != null &&
                    this.TaskInfos.SequenceEqual(input.TaskInfos)
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
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.TaskInfos != null)
                {
                    hashCode = (hashCode * 59) + this.TaskInfos.GetHashCode();
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
