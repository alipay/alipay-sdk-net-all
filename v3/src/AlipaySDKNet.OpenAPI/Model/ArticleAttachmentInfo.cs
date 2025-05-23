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
    /// ArticleAttachmentInfo
    /// </summary>
    [DataContract(Name = "ArticleAttachmentInfo")]
    public partial class ArticleAttachmentInfo : IEquatable<ArticleAttachmentInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleAttachmentInfo" /> class.
        /// </summary>
        /// <param name="fileName">文章附件.</param>
        /// <param name="id">附件id.</param>
        /// <param name="key">附件完整Key.</param>
        /// <param name="url">附件的url.</param>
        public ArticleAttachmentInfo(string fileName = default(string), int id = default(int), string key = default(string), string url = default(string))
        {
            this.FileName = fileName;
            this.Id = id;
            this.Key = key;
            this.Url = url;
        }

        /// <summary>
        /// 文章附件
        /// </summary>
        /// <value>文章附件</value>
        [DataMember(Name = "file_name", EmitDefaultValue = false)]
        public string FileName { get; set; }

        /// <summary>
        /// 附件id
        /// </summary>
        /// <value>附件id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// 附件完整Key
        /// </summary>
        /// <value>附件完整Key</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// 附件的url
        /// </summary>
        /// <value>附件的url</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ArticleAttachmentInfo {\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as ArticleAttachmentInfo);
        }

        /// <summary>
        /// Returns true if ArticleAttachmentInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ArticleAttachmentInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArticleAttachmentInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.FileName != null)
                {
                    hashCode = (hashCode * 59) + this.FileName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
