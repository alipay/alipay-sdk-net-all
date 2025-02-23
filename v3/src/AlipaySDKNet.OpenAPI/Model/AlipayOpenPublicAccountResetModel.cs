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
    /// AlipayOpenPublicAccountResetModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicAccountResetModel")]
    public partial class AlipayOpenPublicAccountResetModel : IEquatable<AlipayOpenPublicAccountResetModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicAccountResetModel" /> class.
        /// </summary>
        /// <param name="agreementId">需要重置的协议号，商户会员在支付宝生活号账号中的唯一标识。.</param>
        /// <param name="bindAccountNo">绑定帐号，建议在开发者的系统中保持唯一性.</param>
        /// <param name="displayName">商户期望在生活号首页看到的关于该用户的显示信息，最长10个字符。 .</param>
        /// <param name="fromUserId">要绑定的商户会员对应的支付宝唯一标识，2088开头长度为16位的字符串。 .</param>
        /// <param name="openId">支付宝用户的唯一标识.</param>
        /// <param name="realName">要绑定的商户会员的真实姓名，最长10个汉字.</param>
        /// <param name="remark">备注信息，开发者可以通过该字段纪录其他的额外信息.</param>
        public AlipayOpenPublicAccountResetModel(string agreementId = default(string), string bindAccountNo = default(string), string displayName = default(string), string fromUserId = default(string), string openId = default(string), string realName = default(string), string remark = default(string))
        {
            this.AgreementId = agreementId;
            this.BindAccountNo = bindAccountNo;
            this.DisplayName = displayName;
            this.FromUserId = fromUserId;
            this.OpenId = openId;
            this.RealName = realName;
            this.Remark = remark;
        }

        /// <summary>
        /// 需要重置的协议号，商户会员在支付宝生活号账号中的唯一标识。
        /// </summary>
        /// <value>需要重置的协议号，商户会员在支付宝生活号账号中的唯一标识。</value>
        [DataMember(Name = "agreement_id", EmitDefaultValue = false)]
        public string AgreementId { get; set; }

        /// <summary>
        /// 绑定帐号，建议在开发者的系统中保持唯一性
        /// </summary>
        /// <value>绑定帐号，建议在开发者的系统中保持唯一性</value>
        [DataMember(Name = "bind_account_no", EmitDefaultValue = false)]
        public string BindAccountNo { get; set; }

        /// <summary>
        /// 商户期望在生活号首页看到的关于该用户的显示信息，最长10个字符。 
        /// </summary>
        /// <value>商户期望在生活号首页看到的关于该用户的显示信息，最长10个字符。 </value>
        [DataMember(Name = "display_name", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 要绑定的商户会员对应的支付宝唯一标识，2088开头长度为16位的字符串。 
        /// </summary>
        /// <value>要绑定的商户会员对应的支付宝唯一标识，2088开头长度为16位的字符串。 </value>
        [DataMember(Name = "from_user_id", EmitDefaultValue = false)]
        public string FromUserId { get; set; }

        /// <summary>
        /// 支付宝用户的唯一标识
        /// </summary>
        /// <value>支付宝用户的唯一标识</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 要绑定的商户会员的真实姓名，最长10个汉字
        /// </summary>
        /// <value>要绑定的商户会员的真实姓名，最长10个汉字</value>
        [DataMember(Name = "real_name", EmitDefaultValue = false)]
        public string RealName { get; set; }

        /// <summary>
        /// 备注信息，开发者可以通过该字段纪录其他的额外信息
        /// </summary>
        /// <value>备注信息，开发者可以通过该字段纪录其他的额外信息</value>
        [DataMember(Name = "remark", EmitDefaultValue = false)]
        public string Remark { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicAccountResetModel {\n");
            sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
            sb.Append("  BindAccountNo: ").Append(BindAccountNo).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FromUserId: ").Append(FromUserId).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  RealName: ").Append(RealName).Append("\n");
            sb.Append("  Remark: ").Append(Remark).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicAccountResetModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicAccountResetModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicAccountResetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicAccountResetModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementId == input.AgreementId ||
                    (this.AgreementId != null &&
                    this.AgreementId.Equals(input.AgreementId))
                ) && 
                (
                    this.BindAccountNo == input.BindAccountNo ||
                    (this.BindAccountNo != null &&
                    this.BindAccountNo.Equals(input.BindAccountNo))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.FromUserId == input.FromUserId ||
                    (this.FromUserId != null &&
                    this.FromUserId.Equals(input.FromUserId))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.RealName == input.RealName ||
                    (this.RealName != null &&
                    this.RealName.Equals(input.RealName))
                ) && 
                (
                    this.Remark == input.Remark ||
                    (this.Remark != null &&
                    this.Remark.Equals(input.Remark))
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
                if (this.AgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementId.GetHashCode();
                }
                if (this.BindAccountNo != null)
                {
                    hashCode = (hashCode * 59) + this.BindAccountNo.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.FromUserId != null)
                {
                    hashCode = (hashCode * 59) + this.FromUserId.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.RealName != null)
                {
                    hashCode = (hashCode * 59) + this.RealName.GetHashCode();
                }
                if (this.Remark != null)
                {
                    hashCode = (hashCode * 59) + this.Remark.GetHashCode();
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
