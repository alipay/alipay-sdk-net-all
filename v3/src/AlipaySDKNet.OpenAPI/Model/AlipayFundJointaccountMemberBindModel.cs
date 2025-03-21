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
    /// AlipayFundJointaccountMemberBindModel
    /// </summary>
    [DataContract(Name = "AlipayFundJointaccountMemberBindModel")]
    public partial class AlipayFundJointaccountMemberBindModel : IEquatable<AlipayFundJointaccountMemberBindModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountMemberBindModel" /> class.
        /// </summary>
        /// <param name="accountId">账本ID.</param>
        /// <param name="accountQuota">accountQuota.</param>
        /// <param name="agreementNo">授权签约协议号.</param>
        /// <param name="agreementSignInfo">关联代扣协议签约串.</param>
        /// <param name="bizScene">业务场景，联系支付宝分配.</param>
        /// <param name="businessParams">businessParams.</param>
        /// <param name="identity">该字段为被邀请方账号ID： 当identity_type为ALIPAY_USER_ID时，需要填支付宝ID；当identity_type为ALIPAY_LOGON_ID时，需要填支付宝登录号；当identity_type为ALIPAY_OPEN_ID时，需要填支付宝openId.</param>
        /// <param name="identityType">账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID  2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 3、ALIPAY_OPEN_ID：支付宝openId.</param>
        /// <param name="identityVerifiedInfo">identityVerifiedInfo.</param>
        /// <param name="name">成员姓名，账号类型为ALIPAY_LOGON_ID时必填.</param>
        /// <param name="productCode">产品码.</param>
        public AlipayFundJointaccountMemberBindModel(string accountId = default(string), JointAccountQuotaDTO accountQuota = default(JointAccountQuotaDTO), string agreementNo = default(string), string agreementSignInfo = default(string), string bizScene = default(string), InviteMemberBusinessParamsDTO businessParams = default(InviteMemberBusinessParamsDTO), string identity = default(string), string identityType = default(string), IdentityVerifiedInfoDTO identityVerifiedInfo = default(IdentityVerifiedInfoDTO), string name = default(string), string productCode = default(string))
        {
            this.AccountId = accountId;
            this.AccountQuota = accountQuota;
            this.AgreementNo = agreementNo;
            this.AgreementSignInfo = agreementSignInfo;
            this.BizScene = bizScene;
            this.BusinessParams = businessParams;
            this.Identity = identity;
            this.IdentityType = identityType;
            this.IdentityVerifiedInfo = identityVerifiedInfo;
            this.Name = name;
            this.ProductCode = productCode;
        }

        /// <summary>
        /// 账本ID
        /// </summary>
        /// <value>账本ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or Sets AccountQuota
        /// </summary>
        [DataMember(Name = "account_quota", EmitDefaultValue = false)]
        public JointAccountQuotaDTO AccountQuota { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        /// <value>授权签约协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 关联代扣协议签约串
        /// </summary>
        /// <value>关联代扣协议签约串</value>
        [DataMember(Name = "agreement_sign_info", EmitDefaultValue = false)]
        public string AgreementSignInfo { get; set; }

        /// <summary>
        /// 业务场景，联系支付宝分配
        /// </summary>
        /// <value>业务场景，联系支付宝分配</value>
        [DataMember(Name = "biz_scene", EmitDefaultValue = false)]
        public string BizScene { get; set; }

        /// <summary>
        /// Gets or Sets BusinessParams
        /// </summary>
        [DataMember(Name = "business_params", EmitDefaultValue = false)]
        public InviteMemberBusinessParamsDTO BusinessParams { get; set; }

        /// <summary>
        /// 该字段为被邀请方账号ID： 当identity_type为ALIPAY_USER_ID时，需要填支付宝ID；当identity_type为ALIPAY_LOGON_ID时，需要填支付宝登录号；当identity_type为ALIPAY_OPEN_ID时，需要填支付宝openId
        /// </summary>
        /// <value>该字段为被邀请方账号ID： 当identity_type为ALIPAY_USER_ID时，需要填支付宝ID；当identity_type为ALIPAY_LOGON_ID时，需要填支付宝登录号；当identity_type为ALIPAY_OPEN_ID时，需要填支付宝openId</value>
        [DataMember(Name = "identity", EmitDefaultValue = false)]
        public string Identity { get; set; }

        /// <summary>
        /// 账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID  2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 3、ALIPAY_OPEN_ID：支付宝openId
        /// </summary>
        /// <value>账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID  2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 3、ALIPAY_OPEN_ID：支付宝openId</value>
        [DataMember(Name = "identity_type", EmitDefaultValue = false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// Gets or Sets IdentityVerifiedInfo
        /// </summary>
        [DataMember(Name = "identity_verified_info", EmitDefaultValue = false)]
        public IdentityVerifiedInfoDTO IdentityVerifiedInfo { get; set; }

        /// <summary>
        /// 成员姓名，账号类型为ALIPAY_LOGON_ID时必填
        /// </summary>
        /// <value>成员姓名，账号类型为ALIPAY_LOGON_ID时必填</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        /// <value>产品码</value>
        [DataMember(Name = "product_code", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundJointaccountMemberBindModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountQuota: ").Append(AccountQuota).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  AgreementSignInfo: ").Append(AgreementSignInfo).Append("\n");
            sb.Append("  BizScene: ").Append(BizScene).Append("\n");
            sb.Append("  BusinessParams: ").Append(BusinessParams).Append("\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  IdentityType: ").Append(IdentityType).Append("\n");
            sb.Append("  IdentityVerifiedInfo: ").Append(IdentityVerifiedInfo).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
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
            return this.Equals(input as AlipayFundJointaccountMemberBindModel);
        }

        /// <summary>
        /// Returns true if AlipayFundJointaccountMemberBindModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundJointaccountMemberBindModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundJointaccountMemberBindModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AccountQuota == input.AccountQuota ||
                    (this.AccountQuota != null &&
                    this.AccountQuota.Equals(input.AccountQuota))
                ) && 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.AgreementSignInfo == input.AgreementSignInfo ||
                    (this.AgreementSignInfo != null &&
                    this.AgreementSignInfo.Equals(input.AgreementSignInfo))
                ) && 
                (
                    this.BizScene == input.BizScene ||
                    (this.BizScene != null &&
                    this.BizScene.Equals(input.BizScene))
                ) && 
                (
                    this.BusinessParams == input.BusinessParams ||
                    (this.BusinessParams != null &&
                    this.BusinessParams.Equals(input.BusinessParams))
                ) && 
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
                ) && 
                (
                    this.IdentityType == input.IdentityType ||
                    (this.IdentityType != null &&
                    this.IdentityType.Equals(input.IdentityType))
                ) && 
                (
                    this.IdentityVerifiedInfo == input.IdentityVerifiedInfo ||
                    (this.IdentityVerifiedInfo != null &&
                    this.IdentityVerifiedInfo.Equals(input.IdentityVerifiedInfo))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.AccountQuota != null)
                {
                    hashCode = (hashCode * 59) + this.AccountQuota.GetHashCode();
                }
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.AgreementSignInfo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementSignInfo.GetHashCode();
                }
                if (this.BizScene != null)
                {
                    hashCode = (hashCode * 59) + this.BizScene.GetHashCode();
                }
                if (this.BusinessParams != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessParams.GetHashCode();
                }
                if (this.Identity != null)
                {
                    hashCode = (hashCode * 59) + this.Identity.GetHashCode();
                }
                if (this.IdentityType != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityType.GetHashCode();
                }
                if (this.IdentityVerifiedInfo != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityVerifiedInfo.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProductCode.GetHashCode();
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
