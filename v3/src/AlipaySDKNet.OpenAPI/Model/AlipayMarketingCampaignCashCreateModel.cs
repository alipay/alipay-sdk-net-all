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
    /// AlipayMarketingCampaignCashCreateModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCampaignCashCreateModel")]
    public partial class AlipayMarketingCampaignCashCreateModel : IEquatable<AlipayMarketingCampaignCashCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCampaignCashCreateModel" /> class.
        /// </summary>
        /// <param name="couponName">红包名称,商户在查询列表、详情看到的名字,同时也会显示在商户付款页面。.</param>
        /// <param name="endTime">活动结束时间,必须大于活动开始时间, 基本格式:yyyy-MM-dd HH:mm:ss,活动有效时间最长为6个月，过期后需要创建新的活动。.</param>
        /// <param name="merchantLink">商户打款后的跳转链接，从支付宝收银台打款成功后的跳转链接。不填时，打款后停留在支付宝支付成功页。商户实际跳转会自动添加crowdNo作为跳转参数。示例: http://www.yourhomepage.com?crowdNo&#x3D;XXX.</param>
        /// <param name="prizeMsg">活动文案，用户在账单、红包中看到的账单描述、红包描述。.</param>
        /// <param name="prizeType">现金红包的发放形式,。枚举支持： *fixed：固定金额。 *random：随机金额。选择随机金额时，单个红包的金额在平均金额的0.5~1.5倍之间浮动。 .</param>
        /// <param name="sendFreqency">用户在当前活动参与次数、频率限制。支持日(D)、周(W)、月(M)、终身(L)维度的限制，整个字段不填时默认值为L1（即用户终生仅能参与1次）。 注意：  1. 终身(L)限制必选且最大值为 100。  2. 日(D)、周(W)、月(M)限制可选且最多只能选择一个（即限制日领取次数就不能再限制月领取次数），频率设置必须小于等于终身(L)的次数。  3. 多个配置之间使用\&quot;|\&quot;进行分隔。如 D3|L4（表示限制用户终生只能参与4次，单日只能参与3次）。  4. 允许多次领取时，活动触发接口需要传入out_biz_no来配合。.</param>
        /// <param name="startTime">活动开始时间，必须大于活动创建的时间。入参支持如下两种形式：  1. 填入固定时间，时间格式为 yyyy-MM-dd HH:mm:ss，如 2020-12-10 22:28:30  2. 填字符串 NowTime，表示创建即生效。.</param>
        /// <param name="totalMoney">活动发放的现金总金额,最小金额1.00元,最大金额10000000.00元。每个红包的最大金额不允许超过200元,最小金额不得低于0.20元。 实际的金额限制可能会根据业务进行动态调整。.</param>
        /// <param name="totalNum">红包发放个数，最小为 1 个，最大10000000个。 说明：不同的发放形式（即prize_type）会使得发放个数含义不同：  1. 若prize_type 为 fixed（固定金额），则每个用户领取的红包金额为total_money除以total_num得到固定金额。  2. 若prize_type为 random（随机金额），则每个用户领取的红包金额为total_money除以total_num得到的平均金额值的0.5~1.5倍。由于金额是随机的，在红包金额全部被领取完时，有可能total_num有所剩余、或者大于设置值的情况。.</param>
        public AlipayMarketingCampaignCashCreateModel(string couponName = default(string), string endTime = default(string), string merchantLink = default(string), string prizeMsg = default(string), string prizeType = default(string), string sendFreqency = default(string), string startTime = default(string), string totalMoney = default(string), string totalNum = default(string))
        {
            this.CouponName = couponName;
            this.EndTime = endTime;
            this.MerchantLink = merchantLink;
            this.PrizeMsg = prizeMsg;
            this.PrizeType = prizeType;
            this.SendFreqency = sendFreqency;
            this.StartTime = startTime;
            this.TotalMoney = totalMoney;
            this.TotalNum = totalNum;
        }

        /// <summary>
        /// 红包名称,商户在查询列表、详情看到的名字,同时也会显示在商户付款页面。
        /// </summary>
        /// <value>红包名称,商户在查询列表、详情看到的名字,同时也会显示在商户付款页面。</value>
        [DataMember(Name = "coupon_name", EmitDefaultValue = false)]
        public string CouponName { get; set; }

        /// <summary>
        /// 活动结束时间,必须大于活动开始时间, 基本格式:yyyy-MM-dd HH:mm:ss,活动有效时间最长为6个月，过期后需要创建新的活动。
        /// </summary>
        /// <value>活动结束时间,必须大于活动开始时间, 基本格式:yyyy-MM-dd HH:mm:ss,活动有效时间最长为6个月，过期后需要创建新的活动。</value>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 商户打款后的跳转链接，从支付宝收银台打款成功后的跳转链接。不填时，打款后停留在支付宝支付成功页。商户实际跳转会自动添加crowdNo作为跳转参数。示例: http://www.yourhomepage.com?crowdNo&#x3D;XXX
        /// </summary>
        /// <value>商户打款后的跳转链接，从支付宝收银台打款成功后的跳转链接。不填时，打款后停留在支付宝支付成功页。商户实际跳转会自动添加crowdNo作为跳转参数。示例: http://www.yourhomepage.com?crowdNo&#x3D;XXX</value>
        [DataMember(Name = "merchant_link", EmitDefaultValue = false)]
        public string MerchantLink { get; set; }

        /// <summary>
        /// 活动文案，用户在账单、红包中看到的账单描述、红包描述。
        /// </summary>
        /// <value>活动文案，用户在账单、红包中看到的账单描述、红包描述。</value>
        [DataMember(Name = "prize_msg", EmitDefaultValue = false)]
        public string PrizeMsg { get; set; }

        /// <summary>
        /// 现金红包的发放形式,。枚举支持： *fixed：固定金额。 *random：随机金额。选择随机金额时，单个红包的金额在平均金额的0.5~1.5倍之间浮动。 
        /// </summary>
        /// <value>现金红包的发放形式,。枚举支持： *fixed：固定金额。 *random：随机金额。选择随机金额时，单个红包的金额在平均金额的0.5~1.5倍之间浮动。 </value>
        [DataMember(Name = "prize_type", EmitDefaultValue = false)]
        public string PrizeType { get; set; }

        /// <summary>
        /// 用户在当前活动参与次数、频率限制。支持日(D)、周(W)、月(M)、终身(L)维度的限制，整个字段不填时默认值为L1（即用户终生仅能参与1次）。 注意：  1. 终身(L)限制必选且最大值为 100。  2. 日(D)、周(W)、月(M)限制可选且最多只能选择一个（即限制日领取次数就不能再限制月领取次数），频率设置必须小于等于终身(L)的次数。  3. 多个配置之间使用\&quot;|\&quot;进行分隔。如 D3|L4（表示限制用户终生只能参与4次，单日只能参与3次）。  4. 允许多次领取时，活动触发接口需要传入out_biz_no来配合。
        /// </summary>
        /// <value>用户在当前活动参与次数、频率限制。支持日(D)、周(W)、月(M)、终身(L)维度的限制，整个字段不填时默认值为L1（即用户终生仅能参与1次）。 注意：  1. 终身(L)限制必选且最大值为 100。  2. 日(D)、周(W)、月(M)限制可选且最多只能选择一个（即限制日领取次数就不能再限制月领取次数），频率设置必须小于等于终身(L)的次数。  3. 多个配置之间使用\&quot;|\&quot;进行分隔。如 D3|L4（表示限制用户终生只能参与4次，单日只能参与3次）。  4. 允许多次领取时，活动触发接口需要传入out_biz_no来配合。</value>
        [DataMember(Name = "send_freqency", EmitDefaultValue = false)]
        public string SendFreqency { get; set; }

        /// <summary>
        /// 活动开始时间，必须大于活动创建的时间。入参支持如下两种形式：  1. 填入固定时间，时间格式为 yyyy-MM-dd HH:mm:ss，如 2020-12-10 22:28:30  2. 填字符串 NowTime，表示创建即生效。
        /// </summary>
        /// <value>活动开始时间，必须大于活动创建的时间。入参支持如下两种形式：  1. 填入固定时间，时间格式为 yyyy-MM-dd HH:mm:ss，如 2020-12-10 22:28:30  2. 填字符串 NowTime，表示创建即生效。</value>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动发放的现金总金额,最小金额1.00元,最大金额10000000.00元。每个红包的最大金额不允许超过200元,最小金额不得低于0.20元。 实际的金额限制可能会根据业务进行动态调整。
        /// </summary>
        /// <value>活动发放的现金总金额,最小金额1.00元,最大金额10000000.00元。每个红包的最大金额不允许超过200元,最小金额不得低于0.20元。 实际的金额限制可能会根据业务进行动态调整。</value>
        [DataMember(Name = "total_money", EmitDefaultValue = false)]
        public string TotalMoney { get; set; }

        /// <summary>
        /// 红包发放个数，最小为 1 个，最大10000000个。 说明：不同的发放形式（即prize_type）会使得发放个数含义不同：  1. 若prize_type 为 fixed（固定金额），则每个用户领取的红包金额为total_money除以total_num得到固定金额。  2. 若prize_type为 random（随机金额），则每个用户领取的红包金额为total_money除以total_num得到的平均金额值的0.5~1.5倍。由于金额是随机的，在红包金额全部被领取完时，有可能total_num有所剩余、或者大于设置值的情况。
        /// </summary>
        /// <value>红包发放个数，最小为 1 个，最大10000000个。 说明：不同的发放形式（即prize_type）会使得发放个数含义不同：  1. 若prize_type 为 fixed（固定金额），则每个用户领取的红包金额为total_money除以total_num得到固定金额。  2. 若prize_type为 random（随机金额），则每个用户领取的红包金额为total_money除以total_num得到的平均金额值的0.5~1.5倍。由于金额是随机的，在红包金额全部被领取完时，有可能total_num有所剩余、或者大于设置值的情况。</value>
        [DataMember(Name = "total_num", EmitDefaultValue = false)]
        public string TotalNum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingCampaignCashCreateModel {\n");
            sb.Append("  CouponName: ").Append(CouponName).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  MerchantLink: ").Append(MerchantLink).Append("\n");
            sb.Append("  PrizeMsg: ").Append(PrizeMsg).Append("\n");
            sb.Append("  PrizeType: ").Append(PrizeType).Append("\n");
            sb.Append("  SendFreqency: ").Append(SendFreqency).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  TotalMoney: ").Append(TotalMoney).Append("\n");
            sb.Append("  TotalNum: ").Append(TotalNum).Append("\n");
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
            return this.Equals(input as AlipayMarketingCampaignCashCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCampaignCashCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCampaignCashCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCampaignCashCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CouponName == input.CouponName ||
                    (this.CouponName != null &&
                    this.CouponName.Equals(input.CouponName))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.MerchantLink == input.MerchantLink ||
                    (this.MerchantLink != null &&
                    this.MerchantLink.Equals(input.MerchantLink))
                ) && 
                (
                    this.PrizeMsg == input.PrizeMsg ||
                    (this.PrizeMsg != null &&
                    this.PrizeMsg.Equals(input.PrizeMsg))
                ) && 
                (
                    this.PrizeType == input.PrizeType ||
                    (this.PrizeType != null &&
                    this.PrizeType.Equals(input.PrizeType))
                ) && 
                (
                    this.SendFreqency == input.SendFreqency ||
                    (this.SendFreqency != null &&
                    this.SendFreqency.Equals(input.SendFreqency))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.TotalMoney == input.TotalMoney ||
                    (this.TotalMoney != null &&
                    this.TotalMoney.Equals(input.TotalMoney))
                ) && 
                (
                    this.TotalNum == input.TotalNum ||
                    (this.TotalNum != null &&
                    this.TotalNum.Equals(input.TotalNum))
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
                if (this.CouponName != null)
                {
                    hashCode = (hashCode * 59) + this.CouponName.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.MerchantLink != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantLink.GetHashCode();
                }
                if (this.PrizeMsg != null)
                {
                    hashCode = (hashCode * 59) + this.PrizeMsg.GetHashCode();
                }
                if (this.PrizeType != null)
                {
                    hashCode = (hashCode * 59) + this.PrizeType.GetHashCode();
                }
                if (this.SendFreqency != null)
                {
                    hashCode = (hashCode * 59) + this.SendFreqency.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.TotalMoney != null)
                {
                    hashCode = (hashCode * 59) + this.TotalMoney.GetHashCode();
                }
                if (this.TotalNum != null)
                {
                    hashCode = (hashCode * 59) + this.TotalNum.GetHashCode();
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
