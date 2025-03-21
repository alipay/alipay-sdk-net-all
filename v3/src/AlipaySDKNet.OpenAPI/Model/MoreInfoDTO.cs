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
    /// MoreInfoDTO
    /// </summary>
    [DataContract(Name = "MoreInfoDTO")]
    public partial class MoreInfoDTO : IEquatable<MoreInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoreInfoDTO" /> class.
        /// </summary>
        /// <param name="descs">描述，当operate_type为openNative必填.</param>
        /// <param name="_params">扩展参数，需要URL地址回带的值，JSON格式(openweb时填).</param>
        /// <param name="title">二级页面标题，只有当operate_type为openNative时有效。.</param>
        /// <param name="url">超链接(选择openweb的时候必须填写url参数内容).</param>
        public MoreInfoDTO(List<string> descs = default(List<string>), string _params = default(string), string title = default(string), string url = default(string))
        {
            this.Descs = descs;
            this.Params = _params;
            this.Title = title;
            this.Url = url;
        }

        /// <summary>
        /// 描述，当operate_type为openNative必填
        /// </summary>
        /// <value>描述，当operate_type为openNative必填</value>
        [DataMember(Name = "descs", EmitDefaultValue = false)]
        public List<string> Descs { get; set; }

        /// <summary>
        /// 扩展参数，需要URL地址回带的值，JSON格式(openweb时填)
        /// </summary>
        /// <value>扩展参数，需要URL地址回带的值，JSON格式(openweb时填)</value>
        [DataMember(Name = "params", EmitDefaultValue = false)]
        public string Params { get; set; }

        /// <summary>
        /// 二级页面标题，只有当operate_type为openNative时有效。
        /// </summary>
        /// <value>二级页面标题，只有当operate_type为openNative时有效。</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// 超链接(选择openweb的时候必须填写url参数内容)
        /// </summary>
        /// <value>超链接(选择openweb的时候必须填写url参数内容)</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MoreInfoDTO {\n");
            sb.Append("  Descs: ").Append(Descs).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as MoreInfoDTO);
        }

        /// <summary>
        /// Returns true if MoreInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MoreInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MoreInfoDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Descs == input.Descs ||
                    this.Descs != null &&
                    input.Descs != null &&
                    this.Descs.SequenceEqual(input.Descs)
                ) && 
                (
                    this.Params == input.Params ||
                    (this.Params != null &&
                    this.Params.Equals(input.Params))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Descs != null)
                {
                    hashCode = (hashCode * 59) + this.Descs.GetHashCode();
                }
                if (this.Params != null)
                {
                    hashCode = (hashCode * 59) + this.Params.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
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
