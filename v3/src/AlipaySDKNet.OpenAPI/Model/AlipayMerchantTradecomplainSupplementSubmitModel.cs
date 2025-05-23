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
    /// AlipayMerchantTradecomplainSupplementSubmitModel
    /// </summary>
    [DataContract(Name = "AlipayMerchantTradecomplainSupplementSubmitModel")]
    public partial class AlipayMerchantTradecomplainSupplementSubmitModel : IEquatable<AlipayMerchantTradecomplainSupplementSubmitModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMerchantTradecomplainSupplementSubmitModel" /> class.
        /// </summary>
        /// <param name="complainEventId">支付宝侧投诉单号.</param>
        /// <param name="supplementContent">回复内容，最多不超过200个字.</param>
        /// <param name="supplementImages">商家补充凭证时的图片id，多个逗号隔开（图片id可以通过\&quot;商户上传处理图片\&quot;接口获取）.</param>
        public AlipayMerchantTradecomplainSupplementSubmitModel(string complainEventId = default(string), string supplementContent = default(string), string supplementImages = default(string))
        {
            this.ComplainEventId = complainEventId;
            this.SupplementContent = supplementContent;
            this.SupplementImages = supplementImages;
        }

        /// <summary>
        /// 支付宝侧投诉单号
        /// </summary>
        /// <value>支付宝侧投诉单号</value>
        [DataMember(Name = "complain_event_id", EmitDefaultValue = false)]
        public string ComplainEventId { get; set; }

        /// <summary>
        /// 回复内容，最多不超过200个字
        /// </summary>
        /// <value>回复内容，最多不超过200个字</value>
        [DataMember(Name = "supplement_content", EmitDefaultValue = false)]
        public string SupplementContent { get; set; }

        /// <summary>
        /// 商家补充凭证时的图片id，多个逗号隔开（图片id可以通过\&quot;商户上传处理图片\&quot;接口获取）
        /// </summary>
        /// <value>商家补充凭证时的图片id，多个逗号隔开（图片id可以通过\&quot;商户上传处理图片\&quot;接口获取）</value>
        [DataMember(Name = "supplement_images", EmitDefaultValue = false)]
        public string SupplementImages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMerchantTradecomplainSupplementSubmitModel {\n");
            sb.Append("  ComplainEventId: ").Append(ComplainEventId).Append("\n");
            sb.Append("  SupplementContent: ").Append(SupplementContent).Append("\n");
            sb.Append("  SupplementImages: ").Append(SupplementImages).Append("\n");
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
            return this.Equals(input as AlipayMerchantTradecomplainSupplementSubmitModel);
        }

        /// <summary>
        /// Returns true if AlipayMerchantTradecomplainSupplementSubmitModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMerchantTradecomplainSupplementSubmitModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMerchantTradecomplainSupplementSubmitModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ComplainEventId == input.ComplainEventId ||
                    (this.ComplainEventId != null &&
                    this.ComplainEventId.Equals(input.ComplainEventId))
                ) && 
                (
                    this.SupplementContent == input.SupplementContent ||
                    (this.SupplementContent != null &&
                    this.SupplementContent.Equals(input.SupplementContent))
                ) && 
                (
                    this.SupplementImages == input.SupplementImages ||
                    (this.SupplementImages != null &&
                    this.SupplementImages.Equals(input.SupplementImages))
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
                if (this.ComplainEventId != null)
                {
                    hashCode = (hashCode * 59) + this.ComplainEventId.GetHashCode();
                }
                if (this.SupplementContent != null)
                {
                    hashCode = (hashCode * 59) + this.SupplementContent.GetHashCode();
                }
                if (this.SupplementImages != null)
                {
                    hashCode = (hashCode * 59) + this.SupplementImages.GetHashCode();
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
