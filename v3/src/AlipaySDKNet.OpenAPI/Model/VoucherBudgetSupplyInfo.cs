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
    /// VoucherBudgetSupplyInfo
    /// </summary>
    [DataContract(Name = "VoucherBudgetSupplyInfo")]
    public partial class VoucherBudgetSupplyInfo : IEquatable<VoucherBudgetSupplyInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherBudgetSupplyInfo" /> class.
        /// </summary>
        /// <param name="budgetType">营销资金预算类型  1、免充值：制券方无需提前充值资金，用户核销支付券时，直接从订单原价中扣除优惠减价金额，最终只将用户实际支付的金额结算给核销商户，商户实收少于订单原价。   2.预充值:  制券方需将优惠预算提前充值到支付宝指定营销账户中，用户核销支付券时，系统从该账户可用余额中扣除优惠减价部分对应的资金，连同用户实际支付的资金，一并结算给核销商户，不影响实收。.</param>
        /// <param name="voucherRechargeInfo">voucherRechargeInfo.</param>
        public VoucherBudgetSupplyInfo(string budgetType = default(string), VoucherRechargeInfo voucherRechargeInfo = default(VoucherRechargeInfo))
        {
            this.BudgetType = budgetType;
            this.VoucherRechargeInfo = voucherRechargeInfo;
        }

        /// <summary>
        /// 营销资金预算类型  1、免充值：制券方无需提前充值资金，用户核销支付券时，直接从订单原价中扣除优惠减价金额，最终只将用户实际支付的金额结算给核销商户，商户实收少于订单原价。   2.预充值:  制券方需将优惠预算提前充值到支付宝指定营销账户中，用户核销支付券时，系统从该账户可用余额中扣除优惠减价部分对应的资金，连同用户实际支付的资金，一并结算给核销商户，不影响实收。
        /// </summary>
        /// <value>营销资金预算类型  1、免充值：制券方无需提前充值资金，用户核销支付券时，直接从订单原价中扣除优惠减价金额，最终只将用户实际支付的金额结算给核销商户，商户实收少于订单原价。   2.预充值:  制券方需将优惠预算提前充值到支付宝指定营销账户中，用户核销支付券时，系统从该账户可用余额中扣除优惠减价部分对应的资金，连同用户实际支付的资金，一并结算给核销商户，不影响实收。</value>
        [DataMember(Name = "budget_type", EmitDefaultValue = false)]
        public string BudgetType { get; set; }

        /// <summary>
        /// Gets or Sets VoucherRechargeInfo
        /// </summary>
        [DataMember(Name = "voucher_recharge_info", EmitDefaultValue = false)]
        public VoucherRechargeInfo VoucherRechargeInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherBudgetSupplyInfo {\n");
            sb.Append("  BudgetType: ").Append(BudgetType).Append("\n");
            sb.Append("  VoucherRechargeInfo: ").Append(VoucherRechargeInfo).Append("\n");
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
            return this.Equals(input as VoucherBudgetSupplyInfo);
        }

        /// <summary>
        /// Returns true if VoucherBudgetSupplyInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherBudgetSupplyInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherBudgetSupplyInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BudgetType == input.BudgetType ||
                    (this.BudgetType != null &&
                    this.BudgetType.Equals(input.BudgetType))
                ) && 
                (
                    this.VoucherRechargeInfo == input.VoucherRechargeInfo ||
                    (this.VoucherRechargeInfo != null &&
                    this.VoucherRechargeInfo.Equals(input.VoucherRechargeInfo))
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
                if (this.BudgetType != null)
                {
                    hashCode = (hashCode * 59) + this.BudgetType.GetHashCode();
                }
                if (this.VoucherRechargeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherRechargeInfo.GetHashCode();
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
