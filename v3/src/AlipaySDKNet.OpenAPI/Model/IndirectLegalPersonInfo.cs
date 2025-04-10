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
    /// IndirectLegalPersonInfo
    /// </summary>
    [DataContract(Name = "IndirectLegalPersonInfo")]
    public partial class IndirectLegalPersonInfo : IEquatable<IndirectLegalPersonInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndirectLegalPersonInfo" /> class.
        /// </summary>
        /// <param name="authLetterImg">授权函照片（使用图片上传接口），当证件持有人类型为 经办人时，必须上传。其他情况，无需上传.</param>
        /// <param name="cardBackImg">法人/经营者证件反面照（使用图片上传接口的image_id）。当证件类型为身份证时，此字段必传；当证件类型为非身份证时，此字段非必传。.</param>
        /// <param name="cardFrontImg">法人/经营者证件正面照（使用图片上传接口返回的image_id）.</param>
        /// <param name="cardNo">证件号码.</param>
        /// <param name="cardType">证件类型，枚举值：中国大陆居民-身份证(RESIDENT)、其他国家或地区居民-护照(PASSPORT)、中国港澳居民-来往内地通行证(PASSPORT_HK_MO)、中国台湾居民-来往大陆通行证(PASSPORT_TWN)、港澳居民居住证（RESIDENCE_PERMIT_HM）、台湾居民居住证（RESIDENCE_PERMIT_TW）、外国人永久居住证（PERMANENT_RESIDENCE_FOREIGNER）。个体户/企业/事业单位/社会组织：可选择任一证件类型，政府机关、小微商户仅支持身份证类型。.</param>
        /// <param name="effectTime">证件生效时间.</param>
        /// <param name="expireTime">证件过期时间.</param>
        /// <param name="isBenefitPerson">经营者/法人是否为受益人.</param>
        /// <param name="legalType">证件持有人类型： - 法人  LEGAL_PERSON - 经办人  AGENT_PERSON 主体类型为政府机关、事业单位时选传： （1）若上传的是法人证件，则不需要上传该字段。 （2）若因特殊情况，无法提供法人证件时，可上传经办人。 主体类型为企业、个体户、社会组织、小微商户时，默认为经营者/法人，不需要上传该字段。.</param>
        /// <param name="personName">法人姓名.</param>
        public IndirectLegalPersonInfo(string authLetterImg = default(string), string cardBackImg = default(string), string cardFrontImg = default(string), string cardNo = default(string), string cardType = default(string), string effectTime = default(string), string expireTime = default(string), bool isBenefitPerson = default(bool), string legalType = default(string), string personName = default(string))
        {
            this.AuthLetterImg = authLetterImg;
            this.CardBackImg = cardBackImg;
            this.CardFrontImg = cardFrontImg;
            this.CardNo = cardNo;
            this.CardType = cardType;
            this.EffectTime = effectTime;
            this.ExpireTime = expireTime;
            this.IsBenefitPerson = isBenefitPerson;
            this.LegalType = legalType;
            this.PersonName = personName;
        }

        /// <summary>
        /// 授权函照片（使用图片上传接口），当证件持有人类型为 经办人时，必须上传。其他情况，无需上传
        /// </summary>
        /// <value>授权函照片（使用图片上传接口），当证件持有人类型为 经办人时，必须上传。其他情况，无需上传</value>
        [DataMember(Name = "auth_letter_img", EmitDefaultValue = false)]
        public string AuthLetterImg { get; set; }

        /// <summary>
        /// 法人/经营者证件反面照（使用图片上传接口的image_id）。当证件类型为身份证时，此字段必传；当证件类型为非身份证时，此字段非必传。
        /// </summary>
        /// <value>法人/经营者证件反面照（使用图片上传接口的image_id）。当证件类型为身份证时，此字段必传；当证件类型为非身份证时，此字段非必传。</value>
        [DataMember(Name = "card_back_img", EmitDefaultValue = false)]
        public string CardBackImg { get; set; }

        /// <summary>
        /// 法人/经营者证件正面照（使用图片上传接口返回的image_id）
        /// </summary>
        /// <value>法人/经营者证件正面照（使用图片上传接口返回的image_id）</value>
        [DataMember(Name = "card_front_img", EmitDefaultValue = false)]
        public string CardFrontImg { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        /// <value>证件号码</value>
        [DataMember(Name = "card_no", EmitDefaultValue = false)]
        public string CardNo { get; set; }

        /// <summary>
        /// 证件类型，枚举值：中国大陆居民-身份证(RESIDENT)、其他国家或地区居民-护照(PASSPORT)、中国港澳居民-来往内地通行证(PASSPORT_HK_MO)、中国台湾居民-来往大陆通行证(PASSPORT_TWN)、港澳居民居住证（RESIDENCE_PERMIT_HM）、台湾居民居住证（RESIDENCE_PERMIT_TW）、外国人永久居住证（PERMANENT_RESIDENCE_FOREIGNER）。个体户/企业/事业单位/社会组织：可选择任一证件类型，政府机关、小微商户仅支持身份证类型。
        /// </summary>
        /// <value>证件类型，枚举值：中国大陆居民-身份证(RESIDENT)、其他国家或地区居民-护照(PASSPORT)、中国港澳居民-来往内地通行证(PASSPORT_HK_MO)、中国台湾居民-来往大陆通行证(PASSPORT_TWN)、港澳居民居住证（RESIDENCE_PERMIT_HM）、台湾居民居住证（RESIDENCE_PERMIT_TW）、外国人永久居住证（PERMANENT_RESIDENCE_FOREIGNER）。个体户/企业/事业单位/社会组织：可选择任一证件类型，政府机关、小微商户仅支持身份证类型。</value>
        [DataMember(Name = "card_type", EmitDefaultValue = false)]
        public string CardType { get; set; }

        /// <summary>
        /// 证件生效时间
        /// </summary>
        /// <value>证件生效时间</value>
        [DataMember(Name = "effect_time", EmitDefaultValue = false)]
        public string EffectTime { get; set; }

        /// <summary>
        /// 证件过期时间
        /// </summary>
        /// <value>证件过期时间</value>
        [DataMember(Name = "expire_time", EmitDefaultValue = false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 经营者/法人是否为受益人
        /// </summary>
        /// <value>经营者/法人是否为受益人</value>
        [DataMember(Name = "is_benefit_person", EmitDefaultValue = true)]
        public bool IsBenefitPerson { get; set; }

        /// <summary>
        /// 证件持有人类型： - 法人  LEGAL_PERSON - 经办人  AGENT_PERSON 主体类型为政府机关、事业单位时选传： （1）若上传的是法人证件，则不需要上传该字段。 （2）若因特殊情况，无法提供法人证件时，可上传经办人。 主体类型为企业、个体户、社会组织、小微商户时，默认为经营者/法人，不需要上传该字段。
        /// </summary>
        /// <value>证件持有人类型： - 法人  LEGAL_PERSON - 经办人  AGENT_PERSON 主体类型为政府机关、事业单位时选传： （1）若上传的是法人证件，则不需要上传该字段。 （2）若因特殊情况，无法提供法人证件时，可上传经办人。 主体类型为企业、个体户、社会组织、小微商户时，默认为经营者/法人，不需要上传该字段。</value>
        [DataMember(Name = "legal_type", EmitDefaultValue = false)]
        public string LegalType { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        /// <value>法人姓名</value>
        [DataMember(Name = "person_name", EmitDefaultValue = false)]
        public string PersonName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IndirectLegalPersonInfo {\n");
            sb.Append("  AuthLetterImg: ").Append(AuthLetterImg).Append("\n");
            sb.Append("  CardBackImg: ").Append(CardBackImg).Append("\n");
            sb.Append("  CardFrontImg: ").Append(CardFrontImg).Append("\n");
            sb.Append("  CardNo: ").Append(CardNo).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  EffectTime: ").Append(EffectTime).Append("\n");
            sb.Append("  ExpireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  IsBenefitPerson: ").Append(IsBenefitPerson).Append("\n");
            sb.Append("  LegalType: ").Append(LegalType).Append("\n");
            sb.Append("  PersonName: ").Append(PersonName).Append("\n");
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
            return this.Equals(input as IndirectLegalPersonInfo);
        }

        /// <summary>
        /// Returns true if IndirectLegalPersonInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of IndirectLegalPersonInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndirectLegalPersonInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthLetterImg == input.AuthLetterImg ||
                    (this.AuthLetterImg != null &&
                    this.AuthLetterImg.Equals(input.AuthLetterImg))
                ) && 
                (
                    this.CardBackImg == input.CardBackImg ||
                    (this.CardBackImg != null &&
                    this.CardBackImg.Equals(input.CardBackImg))
                ) && 
                (
                    this.CardFrontImg == input.CardFrontImg ||
                    (this.CardFrontImg != null &&
                    this.CardFrontImg.Equals(input.CardFrontImg))
                ) && 
                (
                    this.CardNo == input.CardNo ||
                    (this.CardNo != null &&
                    this.CardNo.Equals(input.CardNo))
                ) && 
                (
                    this.CardType == input.CardType ||
                    (this.CardType != null &&
                    this.CardType.Equals(input.CardType))
                ) && 
                (
                    this.EffectTime == input.EffectTime ||
                    (this.EffectTime != null &&
                    this.EffectTime.Equals(input.EffectTime))
                ) && 
                (
                    this.ExpireTime == input.ExpireTime ||
                    (this.ExpireTime != null &&
                    this.ExpireTime.Equals(input.ExpireTime))
                ) && 
                (
                    this.IsBenefitPerson == input.IsBenefitPerson ||
                    this.IsBenefitPerson.Equals(input.IsBenefitPerson)
                ) && 
                (
                    this.LegalType == input.LegalType ||
                    (this.LegalType != null &&
                    this.LegalType.Equals(input.LegalType))
                ) && 
                (
                    this.PersonName == input.PersonName ||
                    (this.PersonName != null &&
                    this.PersonName.Equals(input.PersonName))
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
                if (this.AuthLetterImg != null)
                {
                    hashCode = (hashCode * 59) + this.AuthLetterImg.GetHashCode();
                }
                if (this.CardBackImg != null)
                {
                    hashCode = (hashCode * 59) + this.CardBackImg.GetHashCode();
                }
                if (this.CardFrontImg != null)
                {
                    hashCode = (hashCode * 59) + this.CardFrontImg.GetHashCode();
                }
                if (this.CardNo != null)
                {
                    hashCode = (hashCode * 59) + this.CardNo.GetHashCode();
                }
                if (this.CardType != null)
                {
                    hashCode = (hashCode * 59) + this.CardType.GetHashCode();
                }
                if (this.EffectTime != null)
                {
                    hashCode = (hashCode * 59) + this.EffectTime.GetHashCode();
                }
                if (this.ExpireTime != null)
                {
                    hashCode = (hashCode * 59) + this.ExpireTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsBenefitPerson.GetHashCode();
                if (this.LegalType != null)
                {
                    hashCode = (hashCode * 59) + this.LegalType.GetHashCode();
                }
                if (this.PersonName != null)
                {
                    hashCode = (hashCode * 59) + this.PersonName.GetHashCode();
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
