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
    /// AlipayTradeSettleReceivablesQueryModel
    /// </summary>
    [DataContract(Name = "AlipayTradeSettleReceivablesQueryModel")]
    public partial class AlipayTradeSettleReceivablesQueryModel : IEquatable<AlipayTradeSettleReceivablesQueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeSettleReceivablesQueryModel" /> class.
        /// </summary>
        /// <param name="bizProduct">收单产品码，商家和支付宝签约的产品码.</param>
        /// <param name="extendParams">扩展参数.</param>
        /// <param name="merchantInfo">merchantInfo.</param>
        /// <param name="outRequestNo">外部请求号，32个字符以内，可包含字母、数字、下划线。.</param>
        /// <param name="queryHisDate">当trade_no不为空时，该字段不生效。 查询历史日期，格式为 yyyyMMdd ，取值范围为昨日起至往前30日内； 不传入时，查询实时待结算余额返回； 传入过去某一天日期，查询对应日期的日终待结算余额返回（注意：日常场景下，昨日日终待结算余额只可在当天 02:00 后查询，在当天 02:00 前查询返回查询错误；大促场景下昨日日终可查时间会适当延后）； 传入过去某一天非近30天内，返回参数错误。.</param>
        /// <param name="tradeNo">支付宝交易号，当该笔交易为直付通账期模式，查询该笔交易待确认结算金额时必传.</param>
        public AlipayTradeSettleReceivablesQueryModel(string bizProduct = default(string), string extendParams = default(string), SettleEntity merchantInfo = default(SettleEntity), string outRequestNo = default(string), string queryHisDate = default(string), string tradeNo = default(string))
        {
            this.BizProduct = bizProduct;
            this.ExtendParams = extendParams;
            this.MerchantInfo = merchantInfo;
            this.OutRequestNo = outRequestNo;
            this.QueryHisDate = queryHisDate;
            this.TradeNo = tradeNo;
        }

        /// <summary>
        /// 收单产品码，商家和支付宝签约的产品码
        /// </summary>
        /// <value>收单产品码，商家和支付宝签约的产品码</value>
        [DataMember(Name = "biz_product", EmitDefaultValue = false)]
        public string BizProduct { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        /// <value>扩展参数</value>
        [DataMember(Name = "extend_params", EmitDefaultValue = false)]
        public string ExtendParams { get; set; }

        /// <summary>
        /// Gets or Sets MerchantInfo
        /// </summary>
        [DataMember(Name = "merchant_info", EmitDefaultValue = false)]
        public SettleEntity MerchantInfo { get; set; }

        /// <summary>
        /// 外部请求号，32个字符以内，可包含字母、数字、下划线。
        /// </summary>
        /// <value>外部请求号，32个字符以内，可包含字母、数字、下划线。</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 当trade_no不为空时，该字段不生效。 查询历史日期，格式为 yyyyMMdd ，取值范围为昨日起至往前30日内； 不传入时，查询实时待结算余额返回； 传入过去某一天日期，查询对应日期的日终待结算余额返回（注意：日常场景下，昨日日终待结算余额只可在当天 02:00 后查询，在当天 02:00 前查询返回查询错误；大促场景下昨日日终可查时间会适当延后）； 传入过去某一天非近30天内，返回参数错误。
        /// </summary>
        /// <value>当trade_no不为空时，该字段不生效。 查询历史日期，格式为 yyyyMMdd ，取值范围为昨日起至往前30日内； 不传入时，查询实时待结算余额返回； 传入过去某一天日期，查询对应日期的日终待结算余额返回（注意：日常场景下，昨日日终待结算余额只可在当天 02:00 后查询，在当天 02:00 前查询返回查询错误；大促场景下昨日日终可查时间会适当延后）； 传入过去某一天非近30天内，返回参数错误。</value>
        [DataMember(Name = "query_his_date", EmitDefaultValue = false)]
        public string QueryHisDate { get; set; }

        /// <summary>
        /// 支付宝交易号，当该笔交易为直付通账期模式，查询该笔交易待确认结算金额时必传
        /// </summary>
        /// <value>支付宝交易号，当该笔交易为直付通账期模式，查询该笔交易待确认结算金额时必传</value>
        [DataMember(Name = "trade_no", EmitDefaultValue = false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeSettleReceivablesQueryModel {\n");
            sb.Append("  BizProduct: ").Append(BizProduct).Append("\n");
            sb.Append("  ExtendParams: ").Append(ExtendParams).Append("\n");
            sb.Append("  MerchantInfo: ").Append(MerchantInfo).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  QueryHisDate: ").Append(QueryHisDate).Append("\n");
            sb.Append("  TradeNo: ").Append(TradeNo).Append("\n");
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
            return this.Equals(input as AlipayTradeSettleReceivablesQueryModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeSettleReceivablesQueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeSettleReceivablesQueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeSettleReceivablesQueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizProduct == input.BizProduct ||
                    (this.BizProduct != null &&
                    this.BizProduct.Equals(input.BizProduct))
                ) && 
                (
                    this.ExtendParams == input.ExtendParams ||
                    (this.ExtendParams != null &&
                    this.ExtendParams.Equals(input.ExtendParams))
                ) && 
                (
                    this.MerchantInfo == input.MerchantInfo ||
                    (this.MerchantInfo != null &&
                    this.MerchantInfo.Equals(input.MerchantInfo))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.QueryHisDate == input.QueryHisDate ||
                    (this.QueryHisDate != null &&
                    this.QueryHisDate.Equals(input.QueryHisDate))
                ) && 
                (
                    this.TradeNo == input.TradeNo ||
                    (this.TradeNo != null &&
                    this.TradeNo.Equals(input.TradeNo))
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
                if (this.BizProduct != null)
                {
                    hashCode = (hashCode * 59) + this.BizProduct.GetHashCode();
                }
                if (this.ExtendParams != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendParams.GetHashCode();
                }
                if (this.MerchantInfo != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantInfo.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.QueryHisDate != null)
                {
                    hashCode = (hashCode * 59) + this.QueryHisDate.GetHashCode();
                }
                if (this.TradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.TradeNo.GetHashCode();
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
