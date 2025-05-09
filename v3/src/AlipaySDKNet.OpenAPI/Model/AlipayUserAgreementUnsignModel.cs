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
    /// AlipayUserAgreementUnsignModel
    /// </summary>
    [DataContract(Name = "AlipayUserAgreementUnsignModel")]
    public partial class AlipayUserAgreementUnsignModel : IEquatable<AlipayUserAgreementUnsignModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserAgreementUnsignModel" /> class.
        /// </summary>
        /// <param name="agreementNo">支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ），如果传了该参数，其他参数会被忽略 。 本参数与 external_agreement_no 不可同时为空。.</param>
        /// <param name="alipayLogonId">用户的支付宝登录账号，支持邮箱或手机号码格式。本参数与alipay_user_id 不可同时为空，若都填写，则以alipay_user_id 为准。.</param>
        /// <param name="alipayOpenId">用户的支付宝账号对应的支付宝唯一用户号， 本参数与alipay_logon_id 不可同时为空，若都填写，则以本参数为准，优先级高于alipay_logon_id。.</param>
        /// <param name="alipayUserId">用户的支付宝账号对应的支付宝唯一用户号，以2088 开头的 16 位纯数字 组成;  本参数与alipay_logon_id 不可同时为空，若都填写，则以本参数为准，优先级高于alipay_logon_id。.</param>
        /// <param name="extendParams">扩展参数.</param>
        /// <param name="externalAgreementNo">代扣协议中标示用户的唯一签约号(确保在商户系统中 唯一)。 格式规则:支持大写小写字母和数字，最长 32 位。 注意：若调用 alipay.user.agreement.page.sign(支付宝个人协议页面签约接口) 签约时传入 external_agreement_no 则该值必填且需与签约接口传入值相同。.</param>
        /// <param name="notifyUrl">通知地址.</param>
        /// <param name="operateType">注意：仅异步解约需传入，其余情况无需传递本参数。.</param>
        /// <param name="personalProductCode">协议产品码，商户和支付宝签约时确定，不同业务场景对应不同的签约产品码。.</param>
        /// <param name="signScene">签约协议场景，该值需要与系统/页面签约接口调用时传入的值保持一 致。如：周期扣款场景，需与调用 alipay.user.agreement.page.sign(支付宝个人协议页面签约接口) 签约时的 sign_scene 相同。 当传入商户签约号 external_agreement_no时，场景不能为空或默认值 DEFAULT|DEFAULT。 .</param>
        /// <param name="thirdPartyType">签约第三方主体类型。对于三方协议，表示当前用户和哪一类的第三方主体进行签约。.</param>
        public AlipayUserAgreementUnsignModel(string agreementNo = default(string), string alipayLogonId = default(string), string alipayOpenId = default(string), string alipayUserId = default(string), string extendParams = default(string), string externalAgreementNo = default(string), string notifyUrl = default(string), string operateType = default(string), string personalProductCode = default(string), string signScene = default(string), string thirdPartyType = default(string))
        {
            this.AgreementNo = agreementNo;
            this.AlipayLogonId = alipayLogonId;
            this.AlipayOpenId = alipayOpenId;
            this.AlipayUserId = alipayUserId;
            this.ExtendParams = extendParams;
            this.ExternalAgreementNo = externalAgreementNo;
            this.NotifyUrl = notifyUrl;
            this.OperateType = operateType;
            this.PersonalProductCode = personalProductCode;
            this.SignScene = signScene;
            this.ThirdPartyType = thirdPartyType;
        }

        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ），如果传了该参数，其他参数会被忽略 。 本参数与 external_agreement_no 不可同时为空。
        /// </summary>
        /// <value>支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ），如果传了该参数，其他参数会被忽略 。 本参数与 external_agreement_no 不可同时为空。</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 用户的支付宝登录账号，支持邮箱或手机号码格式。本参数与alipay_user_id 不可同时为空，若都填写，则以alipay_user_id 为准。
        /// </summary>
        /// <value>用户的支付宝登录账号，支持邮箱或手机号码格式。本参数与alipay_user_id 不可同时为空，若都填写，则以alipay_user_id 为准。</value>
        [DataMember(Name = "alipay_logon_id", EmitDefaultValue = false)]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 用户的支付宝账号对应的支付宝唯一用户号， 本参数与alipay_logon_id 不可同时为空，若都填写，则以本参数为准，优先级高于alipay_logon_id。
        /// </summary>
        /// <value>用户的支付宝账号对应的支付宝唯一用户号， 本参数与alipay_logon_id 不可同时为空，若都填写，则以本参数为准，优先级高于alipay_logon_id。</value>
        [DataMember(Name = "alipay_open_id", EmitDefaultValue = false)]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 用户的支付宝账号对应的支付宝唯一用户号，以2088 开头的 16 位纯数字 组成;  本参数与alipay_logon_id 不可同时为空，若都填写，则以本参数为准，优先级高于alipay_logon_id。
        /// </summary>
        /// <value>用户的支付宝账号对应的支付宝唯一用户号，以2088 开头的 16 位纯数字 组成;  本参数与alipay_logon_id 不可同时为空，若都填写，则以本参数为准，优先级高于alipay_logon_id。</value>
        [DataMember(Name = "alipay_user_id", EmitDefaultValue = false)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        /// <value>扩展参数</value>
        [DataMember(Name = "extend_params", EmitDefaultValue = false)]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 代扣协议中标示用户的唯一签约号(确保在商户系统中 唯一)。 格式规则:支持大写小写字母和数字，最长 32 位。 注意：若调用 alipay.user.agreement.page.sign(支付宝个人协议页面签约接口) 签约时传入 external_agreement_no 则该值必填且需与签约接口传入值相同。
        /// </summary>
        /// <value>代扣协议中标示用户的唯一签约号(确保在商户系统中 唯一)。 格式规则:支持大写小写字母和数字，最长 32 位。 注意：若调用 alipay.user.agreement.page.sign(支付宝个人协议页面签约接口) 签约时传入 external_agreement_no 则该值必填且需与签约接口传入值相同。</value>
        [DataMember(Name = "external_agreement_no", EmitDefaultValue = false)]
        public string ExternalAgreementNo { get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        /// <value>通知地址</value>
        [DataMember(Name = "notify_url", EmitDefaultValue = false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 注意：仅异步解约需传入，其余情况无需传递本参数。
        /// </summary>
        /// <value>注意：仅异步解约需传入，其余情况无需传递本参数。</value>
        [DataMember(Name = "operate_type", EmitDefaultValue = false)]
        public string OperateType { get; set; }

        /// <summary>
        /// 协议产品码，商户和支付宝签约时确定，不同业务场景对应不同的签约产品码。
        /// </summary>
        /// <value>协议产品码，商户和支付宝签约时确定，不同业务场景对应不同的签约产品码。</value>
        [DataMember(Name = "personal_product_code", EmitDefaultValue = false)]
        public string PersonalProductCode { get; set; }

        /// <summary>
        /// 签约协议场景，该值需要与系统/页面签约接口调用时传入的值保持一 致。如：周期扣款场景，需与调用 alipay.user.agreement.page.sign(支付宝个人协议页面签约接口) 签约时的 sign_scene 相同。 当传入商户签约号 external_agreement_no时，场景不能为空或默认值 DEFAULT|DEFAULT。 
        /// </summary>
        /// <value>签约协议场景，该值需要与系统/页面签约接口调用时传入的值保持一 致。如：周期扣款场景，需与调用 alipay.user.agreement.page.sign(支付宝个人协议页面签约接口) 签约时的 sign_scene 相同。 当传入商户签约号 external_agreement_no时，场景不能为空或默认值 DEFAULT|DEFAULT。 </value>
        [DataMember(Name = "sign_scene", EmitDefaultValue = false)]
        public string SignScene { get; set; }

        /// <summary>
        /// 签约第三方主体类型。对于三方协议，表示当前用户和哪一类的第三方主体进行签约。
        /// </summary>
        /// <value>签约第三方主体类型。对于三方协议，表示当前用户和哪一类的第三方主体进行签约。</value>
        [DataMember(Name = "third_party_type", EmitDefaultValue = false)]
        public string ThirdPartyType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayUserAgreementUnsignModel {\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  AlipayLogonId: ").Append(AlipayLogonId).Append("\n");
            sb.Append("  AlipayOpenId: ").Append(AlipayOpenId).Append("\n");
            sb.Append("  AlipayUserId: ").Append(AlipayUserId).Append("\n");
            sb.Append("  ExtendParams: ").Append(ExtendParams).Append("\n");
            sb.Append("  ExternalAgreementNo: ").Append(ExternalAgreementNo).Append("\n");
            sb.Append("  NotifyUrl: ").Append(NotifyUrl).Append("\n");
            sb.Append("  OperateType: ").Append(OperateType).Append("\n");
            sb.Append("  PersonalProductCode: ").Append(PersonalProductCode).Append("\n");
            sb.Append("  SignScene: ").Append(SignScene).Append("\n");
            sb.Append("  ThirdPartyType: ").Append(ThirdPartyType).Append("\n");
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
            return this.Equals(input as AlipayUserAgreementUnsignModel);
        }

        /// <summary>
        /// Returns true if AlipayUserAgreementUnsignModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayUserAgreementUnsignModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayUserAgreementUnsignModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.AlipayLogonId == input.AlipayLogonId ||
                    (this.AlipayLogonId != null &&
                    this.AlipayLogonId.Equals(input.AlipayLogonId))
                ) && 
                (
                    this.AlipayOpenId == input.AlipayOpenId ||
                    (this.AlipayOpenId != null &&
                    this.AlipayOpenId.Equals(input.AlipayOpenId))
                ) && 
                (
                    this.AlipayUserId == input.AlipayUserId ||
                    (this.AlipayUserId != null &&
                    this.AlipayUserId.Equals(input.AlipayUserId))
                ) && 
                (
                    this.ExtendParams == input.ExtendParams ||
                    (this.ExtendParams != null &&
                    this.ExtendParams.Equals(input.ExtendParams))
                ) && 
                (
                    this.ExternalAgreementNo == input.ExternalAgreementNo ||
                    (this.ExternalAgreementNo != null &&
                    this.ExternalAgreementNo.Equals(input.ExternalAgreementNo))
                ) && 
                (
                    this.NotifyUrl == input.NotifyUrl ||
                    (this.NotifyUrl != null &&
                    this.NotifyUrl.Equals(input.NotifyUrl))
                ) && 
                (
                    this.OperateType == input.OperateType ||
                    (this.OperateType != null &&
                    this.OperateType.Equals(input.OperateType))
                ) && 
                (
                    this.PersonalProductCode == input.PersonalProductCode ||
                    (this.PersonalProductCode != null &&
                    this.PersonalProductCode.Equals(input.PersonalProductCode))
                ) && 
                (
                    this.SignScene == input.SignScene ||
                    (this.SignScene != null &&
                    this.SignScene.Equals(input.SignScene))
                ) && 
                (
                    this.ThirdPartyType == input.ThirdPartyType ||
                    (this.ThirdPartyType != null &&
                    this.ThirdPartyType.Equals(input.ThirdPartyType))
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
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.AlipayLogonId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayLogonId.GetHashCode();
                }
                if (this.AlipayOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayOpenId.GetHashCode();
                }
                if (this.AlipayUserId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayUserId.GetHashCode();
                }
                if (this.ExtendParams != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendParams.GetHashCode();
                }
                if (this.ExternalAgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalAgreementNo.GetHashCode();
                }
                if (this.NotifyUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NotifyUrl.GetHashCode();
                }
                if (this.OperateType != null)
                {
                    hashCode = (hashCode * 59) + this.OperateType.GetHashCode();
                }
                if (this.PersonalProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.PersonalProductCode.GetHashCode();
                }
                if (this.SignScene != null)
                {
                    hashCode = (hashCode * 59) + this.SignScene.GetHashCode();
                }
                if (this.ThirdPartyType != null)
                {
                    hashCode = (hashCode * 59) + this.ThirdPartyType.GetHashCode();
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
