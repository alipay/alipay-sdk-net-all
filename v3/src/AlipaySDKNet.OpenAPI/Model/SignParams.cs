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
    /// SignParams
    /// </summary>
    [DataContract(Name = "SignParams")]
    public partial class SignParams : IEquatable<SignParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignParams" /> class.
        /// </summary>
        /// <param name="accessParams">accessParams.</param>
        /// <param name="allowHuazhiDegrade">是否允许花芝GO降级成原代扣（即销售方案指定的代扣产品），在花芝GO场景下才会使用该值。取值：true-允许降级，false-不允许降级。默认为true。.</param>
        /// <param name="effectTime">设置签约请求的有效时间，单位为秒。如传入600，商户发起签约请求到用户进入支付宝签约页面的时间差不能超过10分钟。.</param>
        /// <param name="externalAgreementNo">商户签约号，代扣协议中标示用户的唯一签约号（确保在商户系统中唯一）。 格式规则：支持大写小写字母和数字，最长32位。 商户系统按需传入，如果同一用户在同一产品码、同一签约场景下，签订了多份代扣协议，那么需要指定并传入该值。.</param>
        /// <param name="externalLogonId">用户在商户网站的登录账号，用于在签约页面展示，如果为空，则不展示.</param>
        /// <param name="periodRuleParams">periodRuleParams.</param>
        /// <param name="personalProductCode">个人签约产品码，商户和支付宝签约时确定。.</param>
        /// <param name="productCode">商家和支付宝签约的产品码。 商家扣款产品传入固定值：GENERAL_WITHHOLDING.</param>
        /// <param name="recommendSortChannelParams">商户指定优先渠道扣款参数.</param>
        /// <param name="signNotifyUrl">签约成功后商户用于接收异步通知的地址。如果不传入，签约与支付的异步通知都会发到外层notify_url参数传入的地址；如果外层也未传入，签约与支付的异步通知都会发到商户appid配置的网关地址。.</param>
        /// <param name="signScene">协议签约场景，商户和支付宝签约时确定，商户可咨询技术支持。.</param>
        /// <param name="subMerchant">subMerchant.</param>
        public SignParams(AccessParams accessParams = default(AccessParams), bool allowHuazhiDegrade = default(bool), string effectTime = default(string), string externalAgreementNo = default(string), string externalLogonId = default(string), PeriodRuleParams periodRuleParams = default(PeriodRuleParams), string personalProductCode = default(string), string productCode = default(string), List<OpenApiSpecifiedChannelParamsPojo> recommendSortChannelParams = default(List<OpenApiSpecifiedChannelParamsPojo>), string signNotifyUrl = default(string), string signScene = default(string), SignMerchantParams subMerchant = default(SignMerchantParams))
        {
            this.AccessParams = accessParams;
            this.AllowHuazhiDegrade = allowHuazhiDegrade;
            this.EffectTime = effectTime;
            this.ExternalAgreementNo = externalAgreementNo;
            this.ExternalLogonId = externalLogonId;
            this.PeriodRuleParams = periodRuleParams;
            this.PersonalProductCode = personalProductCode;
            this.ProductCode = productCode;
            this.RecommendSortChannelParams = recommendSortChannelParams;
            this.SignNotifyUrl = signNotifyUrl;
            this.SignScene = signScene;
            this.SubMerchant = subMerchant;
        }

        /// <summary>
        /// Gets or Sets AccessParams
        /// </summary>
        [DataMember(Name = "access_params", EmitDefaultValue = false)]
        public AccessParams AccessParams { get; set; }

        /// <summary>
        /// 是否允许花芝GO降级成原代扣（即销售方案指定的代扣产品），在花芝GO场景下才会使用该值。取值：true-允许降级，false-不允许降级。默认为true。
        /// </summary>
        /// <value>是否允许花芝GO降级成原代扣（即销售方案指定的代扣产品），在花芝GO场景下才会使用该值。取值：true-允许降级，false-不允许降级。默认为true。</value>
        [DataMember(Name = "allow_huazhi_degrade", EmitDefaultValue = true)]
        public bool AllowHuazhiDegrade { get; set; }

        /// <summary>
        /// 设置签约请求的有效时间，单位为秒。如传入600，商户发起签约请求到用户进入支付宝签约页面的时间差不能超过10分钟。
        /// </summary>
        /// <value>设置签约请求的有效时间，单位为秒。如传入600，商户发起签约请求到用户进入支付宝签约页面的时间差不能超过10分钟。</value>
        [DataMember(Name = "effect_time", EmitDefaultValue = false)]
        public string EffectTime { get; set; }

        /// <summary>
        /// 商户签约号，代扣协议中标示用户的唯一签约号（确保在商户系统中唯一）。 格式规则：支持大写小写字母和数字，最长32位。 商户系统按需传入，如果同一用户在同一产品码、同一签约场景下，签订了多份代扣协议，那么需要指定并传入该值。
        /// </summary>
        /// <value>商户签约号，代扣协议中标示用户的唯一签约号（确保在商户系统中唯一）。 格式规则：支持大写小写字母和数字，最长32位。 商户系统按需传入，如果同一用户在同一产品码、同一签约场景下，签订了多份代扣协议，那么需要指定并传入该值。</value>
        [DataMember(Name = "external_agreement_no", EmitDefaultValue = false)]
        public string ExternalAgreementNo { get; set; }

        /// <summary>
        /// 用户在商户网站的登录账号，用于在签约页面展示，如果为空，则不展示
        /// </summary>
        /// <value>用户在商户网站的登录账号，用于在签约页面展示，如果为空，则不展示</value>
        [DataMember(Name = "external_logon_id", EmitDefaultValue = false)]
        public string ExternalLogonId { get; set; }

        /// <summary>
        /// Gets or Sets PeriodRuleParams
        /// </summary>
        [DataMember(Name = "period_rule_params", EmitDefaultValue = false)]
        public PeriodRuleParams PeriodRuleParams { get; set; }

        /// <summary>
        /// 个人签约产品码，商户和支付宝签约时确定。
        /// </summary>
        /// <value>个人签约产品码，商户和支付宝签约时确定。</value>
        [DataMember(Name = "personal_product_code", EmitDefaultValue = false)]
        public string PersonalProductCode { get; set; }

        /// <summary>
        /// 商家和支付宝签约的产品码。 商家扣款产品传入固定值：GENERAL_WITHHOLDING
        /// </summary>
        /// <value>商家和支付宝签约的产品码。 商家扣款产品传入固定值：GENERAL_WITHHOLDING</value>
        [DataMember(Name = "product_code", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户指定优先渠道扣款参数
        /// </summary>
        /// <value>商户指定优先渠道扣款参数</value>
        [DataMember(Name = "recommend_sort_channel_params", EmitDefaultValue = false)]
        public List<OpenApiSpecifiedChannelParamsPojo> RecommendSortChannelParams { get; set; }

        /// <summary>
        /// 签约成功后商户用于接收异步通知的地址。如果不传入，签约与支付的异步通知都会发到外层notify_url参数传入的地址；如果外层也未传入，签约与支付的异步通知都会发到商户appid配置的网关地址。
        /// </summary>
        /// <value>签约成功后商户用于接收异步通知的地址。如果不传入，签约与支付的异步通知都会发到外层notify_url参数传入的地址；如果外层也未传入，签约与支付的异步通知都会发到商户appid配置的网关地址。</value>
        [DataMember(Name = "sign_notify_url", EmitDefaultValue = false)]
        public string SignNotifyUrl { get; set; }

        /// <summary>
        /// 协议签约场景，商户和支付宝签约时确定，商户可咨询技术支持。
        /// </summary>
        /// <value>协议签约场景，商户和支付宝签约时确定，商户可咨询技术支持。</value>
        [DataMember(Name = "sign_scene", EmitDefaultValue = false)]
        public string SignScene { get; set; }

        /// <summary>
        /// Gets or Sets SubMerchant
        /// </summary>
        [DataMember(Name = "sub_merchant", EmitDefaultValue = false)]
        public SignMerchantParams SubMerchant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignParams {\n");
            sb.Append("  AccessParams: ").Append(AccessParams).Append("\n");
            sb.Append("  AllowHuazhiDegrade: ").Append(AllowHuazhiDegrade).Append("\n");
            sb.Append("  EffectTime: ").Append(EffectTime).Append("\n");
            sb.Append("  ExternalAgreementNo: ").Append(ExternalAgreementNo).Append("\n");
            sb.Append("  ExternalLogonId: ").Append(ExternalLogonId).Append("\n");
            sb.Append("  PeriodRuleParams: ").Append(PeriodRuleParams).Append("\n");
            sb.Append("  PersonalProductCode: ").Append(PersonalProductCode).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  RecommendSortChannelParams: ").Append(RecommendSortChannelParams).Append("\n");
            sb.Append("  SignNotifyUrl: ").Append(SignNotifyUrl).Append("\n");
            sb.Append("  SignScene: ").Append(SignScene).Append("\n");
            sb.Append("  SubMerchant: ").Append(SubMerchant).Append("\n");
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
            return this.Equals(input as SignParams);
        }

        /// <summary>
        /// Returns true if SignParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SignParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessParams == input.AccessParams ||
                    (this.AccessParams != null &&
                    this.AccessParams.Equals(input.AccessParams))
                ) && 
                (
                    this.AllowHuazhiDegrade == input.AllowHuazhiDegrade ||
                    this.AllowHuazhiDegrade.Equals(input.AllowHuazhiDegrade)
                ) && 
                (
                    this.EffectTime == input.EffectTime ||
                    (this.EffectTime != null &&
                    this.EffectTime.Equals(input.EffectTime))
                ) && 
                (
                    this.ExternalAgreementNo == input.ExternalAgreementNo ||
                    (this.ExternalAgreementNo != null &&
                    this.ExternalAgreementNo.Equals(input.ExternalAgreementNo))
                ) && 
                (
                    this.ExternalLogonId == input.ExternalLogonId ||
                    (this.ExternalLogonId != null &&
                    this.ExternalLogonId.Equals(input.ExternalLogonId))
                ) && 
                (
                    this.PeriodRuleParams == input.PeriodRuleParams ||
                    (this.PeriodRuleParams != null &&
                    this.PeriodRuleParams.Equals(input.PeriodRuleParams))
                ) && 
                (
                    this.PersonalProductCode == input.PersonalProductCode ||
                    (this.PersonalProductCode != null &&
                    this.PersonalProductCode.Equals(input.PersonalProductCode))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.RecommendSortChannelParams == input.RecommendSortChannelParams ||
                    this.RecommendSortChannelParams != null &&
                    input.RecommendSortChannelParams != null &&
                    this.RecommendSortChannelParams.SequenceEqual(input.RecommendSortChannelParams)
                ) && 
                (
                    this.SignNotifyUrl == input.SignNotifyUrl ||
                    (this.SignNotifyUrl != null &&
                    this.SignNotifyUrl.Equals(input.SignNotifyUrl))
                ) && 
                (
                    this.SignScene == input.SignScene ||
                    (this.SignScene != null &&
                    this.SignScene.Equals(input.SignScene))
                ) && 
                (
                    this.SubMerchant == input.SubMerchant ||
                    (this.SubMerchant != null &&
                    this.SubMerchant.Equals(input.SubMerchant))
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
                if (this.AccessParams != null)
                {
                    hashCode = (hashCode * 59) + this.AccessParams.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AllowHuazhiDegrade.GetHashCode();
                if (this.EffectTime != null)
                {
                    hashCode = (hashCode * 59) + this.EffectTime.GetHashCode();
                }
                if (this.ExternalAgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalAgreementNo.GetHashCode();
                }
                if (this.ExternalLogonId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalLogonId.GetHashCode();
                }
                if (this.PeriodRuleParams != null)
                {
                    hashCode = (hashCode * 59) + this.PeriodRuleParams.GetHashCode();
                }
                if (this.PersonalProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.PersonalProductCode.GetHashCode();
                }
                if (this.ProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProductCode.GetHashCode();
                }
                if (this.RecommendSortChannelParams != null)
                {
                    hashCode = (hashCode * 59) + this.RecommendSortChannelParams.GetHashCode();
                }
                if (this.SignNotifyUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SignNotifyUrl.GetHashCode();
                }
                if (this.SignScene != null)
                {
                    hashCode = (hashCode * 59) + this.SignScene.GetHashCode();
                }
                if (this.SubMerchant != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchant.GetHashCode();
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
