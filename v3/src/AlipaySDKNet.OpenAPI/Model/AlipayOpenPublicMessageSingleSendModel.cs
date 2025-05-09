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
    /// AlipayOpenPublicMessageSingleSendModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicMessageSingleSendModel")]
    public partial class AlipayOpenPublicMessageSingleSendModel : IEquatable<AlipayOpenPublicMessageSingleSendModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMessageSingleSendModel" /> class.
        /// </summary>
        /// <param name="template">template.</param>
        /// <param name="toOpenId">支付宝openId，用于支付宝用户在当前应用下的用户标识。.</param>
        /// <param name="toUserId">消息接收用户的支付宝用户id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。.</param>
        public AlipayOpenPublicMessageSingleSendModel(Template template = default(Template), string toOpenId = default(string), string toUserId = default(string))
        {
            this.Template = template;
            this.ToOpenId = toOpenId;
            this.ToUserId = toUserId;
        }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name = "template", EmitDefaultValue = false)]
        public Template Template { get; set; }

        /// <summary>
        /// 支付宝openId，用于支付宝用户在当前应用下的用户标识。
        /// </summary>
        /// <value>支付宝openId，用于支付宝用户在当前应用下的用户标识。</value>
        [DataMember(Name = "to_open_id", EmitDefaultValue = false)]
        public string ToOpenId { get; set; }

        /// <summary>
        /// 消息接收用户的支付宝用户id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        /// <value>消息接收用户的支付宝用户id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。</value>
        [DataMember(Name = "to_user_id", EmitDefaultValue = false)]
        public string ToUserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicMessageSingleSendModel {\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  ToOpenId: ").Append(ToOpenId).Append("\n");
            sb.Append("  ToUserId: ").Append(ToUserId).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicMessageSingleSendModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicMessageSingleSendModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicMessageSingleSendModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicMessageSingleSendModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.ToOpenId == input.ToOpenId ||
                    (this.ToOpenId != null &&
                    this.ToOpenId.Equals(input.ToOpenId))
                ) && 
                (
                    this.ToUserId == input.ToUserId ||
                    (this.ToUserId != null &&
                    this.ToUserId.Equals(input.ToUserId))
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
                if (this.Template != null)
                {
                    hashCode = (hashCode * 59) + this.Template.GetHashCode();
                }
                if (this.ToOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.ToOpenId.GetHashCode();
                }
                if (this.ToUserId != null)
                {
                    hashCode = (hashCode * 59) + this.ToUserId.GetHashCode();
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
