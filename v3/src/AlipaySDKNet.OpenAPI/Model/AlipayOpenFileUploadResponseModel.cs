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
    /// AlipayOpenFileUploadResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenFileUploadResponseModel")]
    public partial class AlipayOpenFileUploadResponseModel : IEquatable<AlipayOpenFileUploadResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenFileUploadResponseModel" /> class.
        /// </summary>
        /// <param name="externId">视频资源id，同步外部渠道后，外部渠道返回的id。目前支持同步优酷场景，返回优酷视频id，用于支付宝客户端播放视频使用.</param>
        /// <param name="fileId">文件id，用于提供后后续业务调用使用.</param>
        public AlipayOpenFileUploadResponseModel(string externId = default(string), string fileId = default(string))
        {
            this.ExternId = externId;
            this.FileId = fileId;
        }

        /// <summary>
        /// 视频资源id，同步外部渠道后，外部渠道返回的id。目前支持同步优酷场景，返回优酷视频id，用于支付宝客户端播放视频使用
        /// </summary>
        /// <value>视频资源id，同步外部渠道后，外部渠道返回的id。目前支持同步优酷场景，返回优酷视频id，用于支付宝客户端播放视频使用</value>
        [DataMember(Name = "extern_id", EmitDefaultValue = false)]
        public string ExternId { get; set; }

        /// <summary>
        /// 文件id，用于提供后后续业务调用使用
        /// </summary>
        /// <value>文件id，用于提供后后续业务调用使用</value>
        [DataMember(Name = "file_id", EmitDefaultValue = false)]
        public string FileId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenFileUploadResponseModel {\n");
            sb.Append("  ExternId: ").Append(ExternId).Append("\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
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
            return this.Equals(input as AlipayOpenFileUploadResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenFileUploadResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenFileUploadResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenFileUploadResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExternId == input.ExternId ||
                    (this.ExternId != null &&
                    this.ExternId.Equals(input.ExternId))
                ) && 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
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
                if (this.ExternId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternId.GetHashCode();
                }
                if (this.FileId != null)
                {
                    hashCode = (hashCode * 59) + this.FileId.GetHashCode();
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
