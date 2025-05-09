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
    /// AlipayOpenFileUploadModel
    /// </summary>
    [DataContract(Name = "AlipayOpenFileUploadModel")]
    public partial class AlipayOpenFileUploadModel : IEquatable<AlipayOpenFileUploadModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenFileUploadModel" /> class.
        /// </summary>
        /// <param name="bizCode">素材使用场景，请关联其他开放平台接口联合使用。如果素材用于内容发布，请必传入content_creation.</param>
        /// <param name="extraParameters">extraParameters.</param>
        /// <param name="md5">文件的md5值，如果不传则不校验md5.</param>
        public AlipayOpenFileUploadModel(string bizCode = default(string), FileUploadExtraParam extraParameters = default(FileUploadExtraParam), string md5 = default(string))
        {
            this.BizCode = bizCode;
            this.ExtraParameters = extraParameters;
            this.Md5 = md5;
        }

        /// <summary>
        /// 素材使用场景，请关联其他开放平台接口联合使用。如果素材用于内容发布，请必传入content_creation
        /// </summary>
        /// <value>素材使用场景，请关联其他开放平台接口联合使用。如果素材用于内容发布，请必传入content_creation</value>
        [DataMember(Name = "biz_code", EmitDefaultValue = false)]
        public string BizCode { get; set; }

        /// <summary>
        /// Gets or Sets ExtraParameters
        /// </summary>
        [DataMember(Name = "extra_parameters", EmitDefaultValue = false)]
        public FileUploadExtraParam ExtraParameters { get; set; }

        /// <summary>
        /// 文件的md5值，如果不传则不校验md5
        /// </summary>
        /// <value>文件的md5值，如果不传则不校验md5</value>
        [DataMember(Name = "md5", EmitDefaultValue = false)]
        public string Md5 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenFileUploadModel {\n");
            sb.Append("  BizCode: ").Append(BizCode).Append("\n");
            sb.Append("  ExtraParameters: ").Append(ExtraParameters).Append("\n");
            sb.Append("  Md5: ").Append(Md5).Append("\n");
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
            return this.Equals(input as AlipayOpenFileUploadModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenFileUploadModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenFileUploadModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenFileUploadModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizCode == input.BizCode ||
                    (this.BizCode != null &&
                    this.BizCode.Equals(input.BizCode))
                ) && 
                (
                    this.ExtraParameters == input.ExtraParameters ||
                    (this.ExtraParameters != null &&
                    this.ExtraParameters.Equals(input.ExtraParameters))
                ) && 
                (
                    this.Md5 == input.Md5 ||
                    (this.Md5 != null &&
                    this.Md5.Equals(input.Md5))
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
                if (this.BizCode != null)
                {
                    hashCode = (hashCode * 59) + this.BizCode.GetHashCode();
                }
                if (this.ExtraParameters != null)
                {
                    hashCode = (hashCode * 59) + this.ExtraParameters.GetHashCode();
                }
                if (this.Md5 != null)
                {
                    hashCode = (hashCode * 59) + this.Md5.GetHashCode();
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
