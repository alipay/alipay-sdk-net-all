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
    /// AlipayOpenAuthTokenAppResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAuthTokenAppResponseModel")]
    public partial class AlipayOpenAuthTokenAppResponseModel : IEquatable<AlipayOpenAuthTokenAppResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAuthTokenAppResponseModel" /> class.
        /// </summary>
        /// <param name="appAuthToken">应用授权令牌.</param>
        /// <param name="appRefreshToken">刷新令牌.</param>
        /// <param name="authAppId">授权商户的appid.</param>
        /// <param name="expiresIn">该字段已作废，应用令牌长期有效，接入方不需要消费该字段.</param>
        /// <param name="reExpiresIn">刷新令牌的有效时间（从接口调用时间作为起始时间），单位到秒.</param>
        /// <param name="tokens">批量授权换码访问令牌列表.</param>
        /// <param name="userId">授权商户的user_id.</param>
        public AlipayOpenAuthTokenAppResponseModel(string appAuthToken = default(string), string appRefreshToken = default(string), string authAppId = default(string), string expiresIn = default(string), string reExpiresIn = default(string), List<AppTokenExchangeSubElement> tokens = default(List<AppTokenExchangeSubElement>), string userId = default(string))
        {
            this.AppAuthToken = appAuthToken;
            this.AppRefreshToken = appRefreshToken;
            this.AuthAppId = authAppId;
            this.ExpiresIn = expiresIn;
            this.ReExpiresIn = reExpiresIn;
            this.Tokens = tokens;
            this.UserId = userId;
        }

        /// <summary>
        /// 应用授权令牌
        /// </summary>
        /// <value>应用授权令牌</value>
        [DataMember(Name = "app_auth_token", EmitDefaultValue = false)]
        public string AppAuthToken { get; set; }

        /// <summary>
        /// 刷新令牌
        /// </summary>
        /// <value>刷新令牌</value>
        [DataMember(Name = "app_refresh_token", EmitDefaultValue = false)]
        public string AppRefreshToken { get; set; }

        /// <summary>
        /// 授权商户的appid
        /// </summary>
        /// <value>授权商户的appid</value>
        [DataMember(Name = "auth_app_id", EmitDefaultValue = false)]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 该字段已作废，应用令牌长期有效，接入方不需要消费该字段
        /// </summary>
        /// <value>该字段已作废，应用令牌长期有效，接入方不需要消费该字段</value>
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public string ExpiresIn { get; set; }

        /// <summary>
        /// 刷新令牌的有效时间（从接口调用时间作为起始时间），单位到秒
        /// </summary>
        /// <value>刷新令牌的有效时间（从接口调用时间作为起始时间），单位到秒</value>
        [DataMember(Name = "re_expires_in", EmitDefaultValue = false)]
        public string ReExpiresIn { get; set; }

        /// <summary>
        /// 批量授权换码访问令牌列表
        /// </summary>
        /// <value>批量授权换码访问令牌列表</value>
        [DataMember(Name = "tokens", EmitDefaultValue = false)]
        public List<AppTokenExchangeSubElement> Tokens { get; set; }

        /// <summary>
        /// 授权商户的user_id
        /// </summary>
        /// <value>授权商户的user_id</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAuthTokenAppResponseModel {\n");
            sb.Append("  AppAuthToken: ").Append(AppAuthToken).Append("\n");
            sb.Append("  AppRefreshToken: ").Append(AppRefreshToken).Append("\n");
            sb.Append("  AuthAppId: ").Append(AuthAppId).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  ReExpiresIn: ").Append(ReExpiresIn).Append("\n");
            sb.Append("  Tokens: ").Append(Tokens).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as AlipayOpenAuthTokenAppResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAuthTokenAppResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAuthTokenAppResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAuthTokenAppResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppAuthToken == input.AppAuthToken ||
                    (this.AppAuthToken != null &&
                    this.AppAuthToken.Equals(input.AppAuthToken))
                ) && 
                (
                    this.AppRefreshToken == input.AppRefreshToken ||
                    (this.AppRefreshToken != null &&
                    this.AppRefreshToken.Equals(input.AppRefreshToken))
                ) && 
                (
                    this.AuthAppId == input.AuthAppId ||
                    (this.AuthAppId != null &&
                    this.AuthAppId.Equals(input.AuthAppId))
                ) && 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    (this.ExpiresIn != null &&
                    this.ExpiresIn.Equals(input.ExpiresIn))
                ) && 
                (
                    this.ReExpiresIn == input.ReExpiresIn ||
                    (this.ReExpiresIn != null &&
                    this.ReExpiresIn.Equals(input.ReExpiresIn))
                ) && 
                (
                    this.Tokens == input.Tokens ||
                    this.Tokens != null &&
                    input.Tokens != null &&
                    this.Tokens.SequenceEqual(input.Tokens)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.AppAuthToken != null)
                {
                    hashCode = (hashCode * 59) + this.AppAuthToken.GetHashCode();
                }
                if (this.AppRefreshToken != null)
                {
                    hashCode = (hashCode * 59) + this.AppRefreshToken.GetHashCode();
                }
                if (this.AuthAppId != null)
                {
                    hashCode = (hashCode * 59) + this.AuthAppId.GetHashCode();
                }
                if (this.ExpiresIn != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresIn.GetHashCode();
                }
                if (this.ReExpiresIn != null)
                {
                    hashCode = (hashCode * 59) + this.ReExpiresIn.GetHashCode();
                }
                if (this.Tokens != null)
                {
                    hashCode = (hashCode * 59) + this.Tokens.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
