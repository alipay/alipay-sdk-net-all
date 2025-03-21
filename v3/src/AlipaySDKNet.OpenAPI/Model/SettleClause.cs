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
    /// SettleClause
    /// </summary>
    [DataContract(Name = "SettleClause")]
    public partial class SettleClause : IEquatable<SettleClause>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettleClause" /> class.
        /// </summary>
        /// <param name="amount">结算金额，单位为元.</param>
        /// <param name="currency">结算币种，支持人民币：CNY.</param>
        /// <param name="settleAccountEntity">结算账号所属于的结算主体类型。 secondMerchant 二级商户的结算账号 store 门店的结算账号 如果不填，默认为settleEntityType对应的类型.</param>
        /// <param name="settleAccountId">结算账户id。  当结算账户id类型是cardSerialNo时，本参数为用户在支付宝绑定的卡编号；当结算账户id类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号；当结算账户id类型是loginName时，本参数为用户的支付宝登录号; 当 settle_account_type 为defaultSettle时，本参数必须为空.</param>
        /// <param name="settleAccountIdType">结算账户id类型。当 settle_account_type 为 defaultSettle 时，本参数必须为空。  当settle_account_type 为bankCard时，本参数为cardSerialNo，表示结算账户id是银行卡编号; 当settle_account_type 为alipayBalance时，本参数为userId或者loginName，其中userId表示结算账户id是支付宝唯一用户号，loginName表示结算账户id是支付宝登录号。.</param>
        /// <param name="settleAccountType">结算账户类型。  bankCard: 结算账户为银行卡； alipayBalance: 结算账户为支付宝余额户； defaultSettle: 按默认结算规则结算.</param>
        /// <param name="settleEntityBizType">已结算资产.</param>
        /// <param name="settleEntityId">结算主体账号。 当结算主体类型为SecondMerchant，传二级商户ID(smid)；结算主体类型为Store时，传门店ID.</param>
        /// <param name="settleEntityType">结算主体类型。 SecondMerchant：结算主体为二级商户 Store：结算主体为门店.</param>
        /// <param name="subMerchant">subMerchant.</param>
        public SettleClause(string amount = default(string), string currency = default(string), string settleAccountEntity = default(string), string settleAccountId = default(string), string settleAccountIdType = default(string), string settleAccountType = default(string), string settleEntityBizType = default(string), string settleEntityId = default(string), string settleEntityType = default(string), SubMerchant subMerchant = default(SubMerchant))
        {
            this.Amount = amount;
            this.Currency = currency;
            this.SettleAccountEntity = settleAccountEntity;
            this.SettleAccountId = settleAccountId;
            this.SettleAccountIdType = settleAccountIdType;
            this.SettleAccountType = settleAccountType;
            this.SettleEntityBizType = settleEntityBizType;
            this.SettleEntityId = settleEntityId;
            this.SettleEntityType = settleEntityType;
            this.SubMerchant = subMerchant;
        }

        /// <summary>
        /// 结算金额，单位为元
        /// </summary>
        /// <value>结算金额，单位为元</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 结算币种，支持人民币：CNY
        /// </summary>
        /// <value>结算币种，支持人民币：CNY</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// 结算账号所属于的结算主体类型。 secondMerchant 二级商户的结算账号 store 门店的结算账号 如果不填，默认为settleEntityType对应的类型
        /// </summary>
        /// <value>结算账号所属于的结算主体类型。 secondMerchant 二级商户的结算账号 store 门店的结算账号 如果不填，默认为settleEntityType对应的类型</value>
        [DataMember(Name = "settle_account_entity", EmitDefaultValue = false)]
        public string SettleAccountEntity { get; set; }

        /// <summary>
        /// 结算账户id。  当结算账户id类型是cardSerialNo时，本参数为用户在支付宝绑定的卡编号；当结算账户id类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号；当结算账户id类型是loginName时，本参数为用户的支付宝登录号; 当 settle_account_type 为defaultSettle时，本参数必须为空
        /// </summary>
        /// <value>结算账户id。  当结算账户id类型是cardSerialNo时，本参数为用户在支付宝绑定的卡编号；当结算账户id类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号；当结算账户id类型是loginName时，本参数为用户的支付宝登录号; 当 settle_account_type 为defaultSettle时，本参数必须为空</value>
        [DataMember(Name = "settle_account_id", EmitDefaultValue = false)]
        public string SettleAccountId { get; set; }

        /// <summary>
        /// 结算账户id类型。当 settle_account_type 为 defaultSettle 时，本参数必须为空。  当settle_account_type 为bankCard时，本参数为cardSerialNo，表示结算账户id是银行卡编号; 当settle_account_type 为alipayBalance时，本参数为userId或者loginName，其中userId表示结算账户id是支付宝唯一用户号，loginName表示结算账户id是支付宝登录号。
        /// </summary>
        /// <value>结算账户id类型。当 settle_account_type 为 defaultSettle 时，本参数必须为空。  当settle_account_type 为bankCard时，本参数为cardSerialNo，表示结算账户id是银行卡编号; 当settle_account_type 为alipayBalance时，本参数为userId或者loginName，其中userId表示结算账户id是支付宝唯一用户号，loginName表示结算账户id是支付宝登录号。</value>
        [DataMember(Name = "settle_account_id_type", EmitDefaultValue = false)]
        public string SettleAccountIdType { get; set; }

        /// <summary>
        /// 结算账户类型。  bankCard: 结算账户为银行卡； alipayBalance: 结算账户为支付宝余额户； defaultSettle: 按默认结算规则结算
        /// </summary>
        /// <value>结算账户类型。  bankCard: 结算账户为银行卡； alipayBalance: 结算账户为支付宝余额户； defaultSettle: 按默认结算规则结算</value>
        [DataMember(Name = "settle_account_type", EmitDefaultValue = false)]
        public string SettleAccountType { get; set; }

        /// <summary>
        /// 已结算资产
        /// </summary>
        /// <value>已结算资产</value>
        [DataMember(Name = "settle_entity_biz_type", EmitDefaultValue = false)]
        public string SettleEntityBizType { get; set; }

        /// <summary>
        /// 结算主体账号。 当结算主体类型为SecondMerchant，传二级商户ID(smid)；结算主体类型为Store时，传门店ID
        /// </summary>
        /// <value>结算主体账号。 当结算主体类型为SecondMerchant，传二级商户ID(smid)；结算主体类型为Store时，传门店ID</value>
        [DataMember(Name = "settle_entity_id", EmitDefaultValue = false)]
        public string SettleEntityId { get; set; }

        /// <summary>
        /// 结算主体类型。 SecondMerchant：结算主体为二级商户 Store：结算主体为门店
        /// </summary>
        /// <value>结算主体类型。 SecondMerchant：结算主体为二级商户 Store：结算主体为门店</value>
        [DataMember(Name = "settle_entity_type", EmitDefaultValue = false)]
        public string SettleEntityType { get; set; }

        /// <summary>
        /// Gets or Sets SubMerchant
        /// </summary>
        [DataMember(Name = "sub_merchant", EmitDefaultValue = false)]
        public SubMerchant SubMerchant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SettleClause {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  SettleAccountEntity: ").Append(SettleAccountEntity).Append("\n");
            sb.Append("  SettleAccountId: ").Append(SettleAccountId).Append("\n");
            sb.Append("  SettleAccountIdType: ").Append(SettleAccountIdType).Append("\n");
            sb.Append("  SettleAccountType: ").Append(SettleAccountType).Append("\n");
            sb.Append("  SettleEntityBizType: ").Append(SettleEntityBizType).Append("\n");
            sb.Append("  SettleEntityId: ").Append(SettleEntityId).Append("\n");
            sb.Append("  SettleEntityType: ").Append(SettleEntityType).Append("\n");
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
            return this.Equals(input as SettleClause);
        }

        /// <summary>
        /// Returns true if SettleClause instances are equal
        /// </summary>
        /// <param name="input">Instance of SettleClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettleClause input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.SettleAccountEntity == input.SettleAccountEntity ||
                    (this.SettleAccountEntity != null &&
                    this.SettleAccountEntity.Equals(input.SettleAccountEntity))
                ) && 
                (
                    this.SettleAccountId == input.SettleAccountId ||
                    (this.SettleAccountId != null &&
                    this.SettleAccountId.Equals(input.SettleAccountId))
                ) && 
                (
                    this.SettleAccountIdType == input.SettleAccountIdType ||
                    (this.SettleAccountIdType != null &&
                    this.SettleAccountIdType.Equals(input.SettleAccountIdType))
                ) && 
                (
                    this.SettleAccountType == input.SettleAccountType ||
                    (this.SettleAccountType != null &&
                    this.SettleAccountType.Equals(input.SettleAccountType))
                ) && 
                (
                    this.SettleEntityBizType == input.SettleEntityBizType ||
                    (this.SettleEntityBizType != null &&
                    this.SettleEntityBizType.Equals(input.SettleEntityBizType))
                ) && 
                (
                    this.SettleEntityId == input.SettleEntityId ||
                    (this.SettleEntityId != null &&
                    this.SettleEntityId.Equals(input.SettleEntityId))
                ) && 
                (
                    this.SettleEntityType == input.SettleEntityType ||
                    (this.SettleEntityType != null &&
                    this.SettleEntityType.Equals(input.SettleEntityType))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.SettleAccountEntity != null)
                {
                    hashCode = (hashCode * 59) + this.SettleAccountEntity.GetHashCode();
                }
                if (this.SettleAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.SettleAccountId.GetHashCode();
                }
                if (this.SettleAccountIdType != null)
                {
                    hashCode = (hashCode * 59) + this.SettleAccountIdType.GetHashCode();
                }
                if (this.SettleAccountType != null)
                {
                    hashCode = (hashCode * 59) + this.SettleAccountType.GetHashCode();
                }
                if (this.SettleEntityBizType != null)
                {
                    hashCode = (hashCode * 59) + this.SettleEntityBizType.GetHashCode();
                }
                if (this.SettleEntityId != null)
                {
                    hashCode = (hashCode * 59) + this.SettleEntityId.GetHashCode();
                }
                if (this.SettleEntityType != null)
                {
                    hashCode = (hashCode * 59) + this.SettleEntityType.GetHashCode();
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
