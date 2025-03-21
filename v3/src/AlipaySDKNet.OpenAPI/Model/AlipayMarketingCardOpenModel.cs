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
    /// AlipayMarketingCardOpenModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCardOpenModel")]
    public partial class AlipayMarketingCardOpenModel : IEquatable<AlipayMarketingCardOpenModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardOpenModel" /> class.
        /// </summary>
        /// <param name="cardExtInfo">cardExtInfo.</param>
        /// <param name="cardTemplateId">支付宝分配的卡模板Id（卡模板创建接口返回的模板ID）.</param>
        /// <param name="cardUserInfo">cardUserInfo.</param>
        /// <param name="memberExtInfo">memberExtInfo.</param>
        /// <param name="openCardChannel">领卡渠道，用于记录外部商户端领卡来源的渠道信息，渠道值可自行定义（仅限数字、字母、下划线）   可直接标识领卡渠道，也可配合open_card_channel_id标识领卡渠道类型：  例如：  线下门店领取:20161534000000000008863（直接标识领卡渠道，门店shopId）  线下扫二维码领取:QR（标识领卡类型）;  线下活动领取:20170522000000000003609（直接标识领卡渠道，商户活动ID）.</param>
        /// <param name="openCardChannelId">领卡来源的渠道id，注意区别于open_card_channel领卡渠道；  一般使用场景：  open_card_channel用于区分渠道类型，例如取值为\&quot;SHOP\&quot;（门店），\&quot;ACTIVITY\&quot;（活动）；  则open_card_channel_id可用于区分同渠道的不同实体，对应取各门店ID或各活动的标识ID等；.</param>
        /// <param name="outSerialNo">外部商户流水号。由商户自定义，需保证商户系统中唯一。.</param>
        /// <param name="paidOuterCardInfo">paidOuterCardInfo.</param>
        public AlipayMarketingCardOpenModel(MerchantCard cardExtInfo = default(MerchantCard), string cardTemplateId = default(string), CardUserInfo cardUserInfo = default(CardUserInfo), MerchantMenber memberExtInfo = default(MerchantMenber), string openCardChannel = default(string), string openCardChannelId = default(string), string outSerialNo = default(string), PaidOuterCardExtraInfoDTO paidOuterCardInfo = default(PaidOuterCardExtraInfoDTO))
        {
            this.CardExtInfo = cardExtInfo;
            this.CardTemplateId = cardTemplateId;
            this.CardUserInfo = cardUserInfo;
            this.MemberExtInfo = memberExtInfo;
            this.OpenCardChannel = openCardChannel;
            this.OpenCardChannelId = openCardChannelId;
            this.OutSerialNo = outSerialNo;
            this.PaidOuterCardInfo = paidOuterCardInfo;
        }

        /// <summary>
        /// Gets or Sets CardExtInfo
        /// </summary>
        [DataMember(Name = "card_ext_info", EmitDefaultValue = false)]
        public MerchantCard CardExtInfo { get; set; }

        /// <summary>
        /// 支付宝分配的卡模板Id（卡模板创建接口返回的模板ID）
        /// </summary>
        /// <value>支付宝分配的卡模板Id（卡模板创建接口返回的模板ID）</value>
        [DataMember(Name = "card_template_id", EmitDefaultValue = false)]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets CardUserInfo
        /// </summary>
        [DataMember(Name = "card_user_info", EmitDefaultValue = false)]
        public CardUserInfo CardUserInfo { get; set; }

        /// <summary>
        /// Gets or Sets MemberExtInfo
        /// </summary>
        [DataMember(Name = "member_ext_info", EmitDefaultValue = false)]
        public MerchantMenber MemberExtInfo { get; set; }

        /// <summary>
        /// 领卡渠道，用于记录外部商户端领卡来源的渠道信息，渠道值可自行定义（仅限数字、字母、下划线）   可直接标识领卡渠道，也可配合open_card_channel_id标识领卡渠道类型：  例如：  线下门店领取:20161534000000000008863（直接标识领卡渠道，门店shopId）  线下扫二维码领取:QR（标识领卡类型）;  线下活动领取:20170522000000000003609（直接标识领卡渠道，商户活动ID）
        /// </summary>
        /// <value>领卡渠道，用于记录外部商户端领卡来源的渠道信息，渠道值可自行定义（仅限数字、字母、下划线）   可直接标识领卡渠道，也可配合open_card_channel_id标识领卡渠道类型：  例如：  线下门店领取:20161534000000000008863（直接标识领卡渠道，门店shopId）  线下扫二维码领取:QR（标识领卡类型）;  线下活动领取:20170522000000000003609（直接标识领卡渠道，商户活动ID）</value>
        [DataMember(Name = "open_card_channel", EmitDefaultValue = false)]
        public string OpenCardChannel { get; set; }

        /// <summary>
        /// 领卡来源的渠道id，注意区别于open_card_channel领卡渠道；  一般使用场景：  open_card_channel用于区分渠道类型，例如取值为\&quot;SHOP\&quot;（门店），\&quot;ACTIVITY\&quot;（活动）；  则open_card_channel_id可用于区分同渠道的不同实体，对应取各门店ID或各活动的标识ID等；
        /// </summary>
        /// <value>领卡来源的渠道id，注意区别于open_card_channel领卡渠道；  一般使用场景：  open_card_channel用于区分渠道类型，例如取值为\&quot;SHOP\&quot;（门店），\&quot;ACTIVITY\&quot;（活动）；  则open_card_channel_id可用于区分同渠道的不同实体，对应取各门店ID或各活动的标识ID等；</value>
        [DataMember(Name = "open_card_channel_id", EmitDefaultValue = false)]
        public string OpenCardChannelId { get; set; }

        /// <summary>
        /// 外部商户流水号。由商户自定义，需保证商户系统中唯一。
        /// </summary>
        /// <value>外部商户流水号。由商户自定义，需保证商户系统中唯一。</value>
        [DataMember(Name = "out_serial_no", EmitDefaultValue = false)]
        public string OutSerialNo { get; set; }

        /// <summary>
        /// Gets or Sets PaidOuterCardInfo
        /// </summary>
        [DataMember(Name = "paid_outer_card_info", EmitDefaultValue = false)]
        public PaidOuterCardExtraInfoDTO PaidOuterCardInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingCardOpenModel {\n");
            sb.Append("  CardExtInfo: ").Append(CardExtInfo).Append("\n");
            sb.Append("  CardTemplateId: ").Append(CardTemplateId).Append("\n");
            sb.Append("  CardUserInfo: ").Append(CardUserInfo).Append("\n");
            sb.Append("  MemberExtInfo: ").Append(MemberExtInfo).Append("\n");
            sb.Append("  OpenCardChannel: ").Append(OpenCardChannel).Append("\n");
            sb.Append("  OpenCardChannelId: ").Append(OpenCardChannelId).Append("\n");
            sb.Append("  OutSerialNo: ").Append(OutSerialNo).Append("\n");
            sb.Append("  PaidOuterCardInfo: ").Append(PaidOuterCardInfo).Append("\n");
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
            return this.Equals(input as AlipayMarketingCardOpenModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCardOpenModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCardOpenModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCardOpenModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CardExtInfo == input.CardExtInfo ||
                    (this.CardExtInfo != null &&
                    this.CardExtInfo.Equals(input.CardExtInfo))
                ) && 
                (
                    this.CardTemplateId == input.CardTemplateId ||
                    (this.CardTemplateId != null &&
                    this.CardTemplateId.Equals(input.CardTemplateId))
                ) && 
                (
                    this.CardUserInfo == input.CardUserInfo ||
                    (this.CardUserInfo != null &&
                    this.CardUserInfo.Equals(input.CardUserInfo))
                ) && 
                (
                    this.MemberExtInfo == input.MemberExtInfo ||
                    (this.MemberExtInfo != null &&
                    this.MemberExtInfo.Equals(input.MemberExtInfo))
                ) && 
                (
                    this.OpenCardChannel == input.OpenCardChannel ||
                    (this.OpenCardChannel != null &&
                    this.OpenCardChannel.Equals(input.OpenCardChannel))
                ) && 
                (
                    this.OpenCardChannelId == input.OpenCardChannelId ||
                    (this.OpenCardChannelId != null &&
                    this.OpenCardChannelId.Equals(input.OpenCardChannelId))
                ) && 
                (
                    this.OutSerialNo == input.OutSerialNo ||
                    (this.OutSerialNo != null &&
                    this.OutSerialNo.Equals(input.OutSerialNo))
                ) && 
                (
                    this.PaidOuterCardInfo == input.PaidOuterCardInfo ||
                    (this.PaidOuterCardInfo != null &&
                    this.PaidOuterCardInfo.Equals(input.PaidOuterCardInfo))
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
                if (this.CardExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.CardExtInfo.GetHashCode();
                }
                if (this.CardTemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.CardTemplateId.GetHashCode();
                }
                if (this.CardUserInfo != null)
                {
                    hashCode = (hashCode * 59) + this.CardUserInfo.GetHashCode();
                }
                if (this.MemberExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.MemberExtInfo.GetHashCode();
                }
                if (this.OpenCardChannel != null)
                {
                    hashCode = (hashCode * 59) + this.OpenCardChannel.GetHashCode();
                }
                if (this.OpenCardChannelId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenCardChannelId.GetHashCode();
                }
                if (this.OutSerialNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutSerialNo.GetHashCode();
                }
                if (this.PaidOuterCardInfo != null)
                {
                    hashCode = (hashCode * 59) + this.PaidOuterCardInfo.GetHashCode();
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
