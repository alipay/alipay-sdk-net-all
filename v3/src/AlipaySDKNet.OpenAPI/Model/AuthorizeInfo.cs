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
    /// AuthorizeInfo
    /// </summary>
    [DataContract(Name = "AuthorizeInfo")]
    public partial class AuthorizeInfo : IEquatable<AuthorizeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizeInfo" /> class.
        /// </summary>
        /// <param name="authIds">授权方身份证明(当前只支持图片类型，请调用alipay.open.mini.miniapp.brand.upload接口上传图片,可以上传多个授权方身份证明).</param>
        /// <param name="authMaterials">授权有效资质(当前只支持图片类型，请调用alipay.open.mini.miniapp.brand.upload接口上传图片，可以上传多个授权有效资质).</param>
        /// <param name="authName">被授权人名称.</param>
        /// <param name="endDate">授权有效期(结束日期).</param>
        /// <param name="startDate">授权有效期(开始日期).</param>
        public AuthorizeInfo(List<string> authIds = default(List<string>), List<string> authMaterials = default(List<string>), string authName = default(string), string endDate = default(string), string startDate = default(string))
        {
            this.AuthIds = authIds;
            this.AuthMaterials = authMaterials;
            this.AuthName = authName;
            this.EndDate = endDate;
            this.StartDate = startDate;
        }

        /// <summary>
        /// 授权方身份证明(当前只支持图片类型，请调用alipay.open.mini.miniapp.brand.upload接口上传图片,可以上传多个授权方身份证明)
        /// </summary>
        /// <value>授权方身份证明(当前只支持图片类型，请调用alipay.open.mini.miniapp.brand.upload接口上传图片,可以上传多个授权方身份证明)</value>
        [DataMember(Name = "auth_ids", EmitDefaultValue = false)]
        public List<string> AuthIds { get; set; }

        /// <summary>
        /// 授权有效资质(当前只支持图片类型，请调用alipay.open.mini.miniapp.brand.upload接口上传图片，可以上传多个授权有效资质)
        /// </summary>
        /// <value>授权有效资质(当前只支持图片类型，请调用alipay.open.mini.miniapp.brand.upload接口上传图片，可以上传多个授权有效资质)</value>
        [DataMember(Name = "auth_materials", EmitDefaultValue = false)]
        public List<string> AuthMaterials { get; set; }

        /// <summary>
        /// 被授权人名称
        /// </summary>
        /// <value>被授权人名称</value>
        [DataMember(Name = "auth_name", EmitDefaultValue = false)]
        public string AuthName { get; set; }

        /// <summary>
        /// 授权有效期(结束日期)
        /// </summary>
        /// <value>授权有效期(结束日期)</value>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// 授权有效期(开始日期)
        /// </summary>
        /// <value>授权有效期(开始日期)</value>
        [DataMember(Name = "start_date", EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorizeInfo {\n");
            sb.Append("  AuthIds: ").Append(AuthIds).Append("\n");
            sb.Append("  AuthMaterials: ").Append(AuthMaterials).Append("\n");
            sb.Append("  AuthName: ").Append(AuthName).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
            return this.Equals(input as AuthorizeInfo);
        }

        /// <summary>
        /// Returns true if AuthorizeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorizeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizeInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthIds == input.AuthIds ||
                    this.AuthIds != null &&
                    input.AuthIds != null &&
                    this.AuthIds.SequenceEqual(input.AuthIds)
                ) && 
                (
                    this.AuthMaterials == input.AuthMaterials ||
                    this.AuthMaterials != null &&
                    input.AuthMaterials != null &&
                    this.AuthMaterials.SequenceEqual(input.AuthMaterials)
                ) && 
                (
                    this.AuthName == input.AuthName ||
                    (this.AuthName != null &&
                    this.AuthName.Equals(input.AuthName))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
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
                if (this.AuthIds != null)
                {
                    hashCode = (hashCode * 59) + this.AuthIds.GetHashCode();
                }
                if (this.AuthMaterials != null)
                {
                    hashCode = (hashCode * 59) + this.AuthMaterials.GetHashCode();
                }
                if (this.AuthName != null)
                {
                    hashCode = (hashCode * 59) + this.AuthName.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
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
