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
    /// ZhimaCustomerJobworthAuthenticationQueryResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaCustomerJobworthAuthenticationQueryResponseModel")]
    public partial class ZhimaCustomerJobworthAuthenticationQueryResponseModel : IEquatable<ZhimaCustomerJobworthAuthenticationQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCustomerJobworthAuthenticationQueryResponseModel" /> class.
        /// </summary>
        /// <param name="identityResult">SUCCESS代表可信，FAILED代表不可信，WAITING_VERIFY代表未知需要等待结果.</param>
        /// <param name="identityResultSkipUrl">身份认证查询结果页面的小程序链接，有芝麻提供，用户在端内可直接访问.</param>
        /// <param name="openId">蚂蚁统一会员ID.</param>
        /// <param name="tokenStatus">代表订单状态.</param>
        /// <param name="userId">蚂蚁统一会员ID.</param>
        public ZhimaCustomerJobworthAuthenticationQueryResponseModel(string identityResult = default(string), string identityResultSkipUrl = default(string), string openId = default(string), string tokenStatus = default(string), string userId = default(string))
        {
            this.IdentityResult = identityResult;
            this.IdentityResultSkipUrl = identityResultSkipUrl;
            this.OpenId = openId;
            this.TokenStatus = tokenStatus;
            this.UserId = userId;
        }

        /// <summary>
        /// SUCCESS代表可信，FAILED代表不可信，WAITING_VERIFY代表未知需要等待结果
        /// </summary>
        /// <value>SUCCESS代表可信，FAILED代表不可信，WAITING_VERIFY代表未知需要等待结果</value>
        [DataMember(Name = "identity_result", EmitDefaultValue = false)]
        public string IdentityResult { get; set; }

        /// <summary>
        /// 身份认证查询结果页面的小程序链接，有芝麻提供，用户在端内可直接访问
        /// </summary>
        /// <value>身份认证查询结果页面的小程序链接，有芝麻提供，用户在端内可直接访问</value>
        [DataMember(Name = "identity_result_skip_url", EmitDefaultValue = false)]
        public string IdentityResultSkipUrl { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        /// <value>蚂蚁统一会员ID</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 代表订单状态
        /// </summary>
        /// <value>代表订单状态</value>
        [DataMember(Name = "token_status", EmitDefaultValue = false)]
        public string TokenStatus { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        /// <value>蚂蚁统一会员ID</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaCustomerJobworthAuthenticationQueryResponseModel {\n");
            sb.Append("  IdentityResult: ").Append(IdentityResult).Append("\n");
            sb.Append("  IdentityResultSkipUrl: ").Append(IdentityResultSkipUrl).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  TokenStatus: ").Append(TokenStatus).Append("\n");
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
            return this.Equals(input as ZhimaCustomerJobworthAuthenticationQueryResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaCustomerJobworthAuthenticationQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCustomerJobworthAuthenticationQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCustomerJobworthAuthenticationQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IdentityResult == input.IdentityResult ||
                    (this.IdentityResult != null &&
                    this.IdentityResult.Equals(input.IdentityResult))
                ) && 
                (
                    this.IdentityResultSkipUrl == input.IdentityResultSkipUrl ||
                    (this.IdentityResultSkipUrl != null &&
                    this.IdentityResultSkipUrl.Equals(input.IdentityResultSkipUrl))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.TokenStatus == input.TokenStatus ||
                    (this.TokenStatus != null &&
                    this.TokenStatus.Equals(input.TokenStatus))
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
                if (this.IdentityResult != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityResult.GetHashCode();
                }
                if (this.IdentityResultSkipUrl != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityResultSkipUrl.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.TokenStatus != null)
                {
                    hashCode = (hashCode * 59) + this.TokenStatus.GetHashCode();
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
