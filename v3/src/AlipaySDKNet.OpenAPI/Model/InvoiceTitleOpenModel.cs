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
    /// InvoiceTitleOpenModel
    /// </summary>
    [DataContract(Name = "InvoiceTitleOpenModel")]
    public partial class InvoiceTitleOpenModel : IEquatable<InvoiceTitleOpenModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceTitleOpenModel" /> class.
        /// </summary>
        /// <param name="payerAddressTel">票面上的购买方地址、电话.</param>
        /// <param name="payerBankNameAccount">票面上的购买方开户行及账户.</param>
        /// <param name="payerRegisterNo">票面上的购买方纳税人识别号.</param>
        /// <param name="titleName">票面上的购买方名称.</param>
        public InvoiceTitleOpenModel(string payerAddressTel = default(string), string payerBankNameAccount = default(string), string payerRegisterNo = default(string), string titleName = default(string))
        {
            this.PayerAddressTel = payerAddressTel;
            this.PayerBankNameAccount = payerBankNameAccount;
            this.PayerRegisterNo = payerRegisterNo;
            this.TitleName = titleName;
        }

        /// <summary>
        /// 票面上的购买方地址、电话
        /// </summary>
        /// <value>票面上的购买方地址、电话</value>
        [DataMember(Name = "payer_address_tel", EmitDefaultValue = false)]
        public string PayerAddressTel { get; set; }

        /// <summary>
        /// 票面上的购买方开户行及账户
        /// </summary>
        /// <value>票面上的购买方开户行及账户</value>
        [DataMember(Name = "payer_bank_name_account", EmitDefaultValue = false)]
        public string PayerBankNameAccount { get; set; }

        /// <summary>
        /// 票面上的购买方纳税人识别号
        /// </summary>
        /// <value>票面上的购买方纳税人识别号</value>
        [DataMember(Name = "payer_register_no", EmitDefaultValue = false)]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 票面上的购买方名称
        /// </summary>
        /// <value>票面上的购买方名称</value>
        [DataMember(Name = "title_name", EmitDefaultValue = false)]
        public string TitleName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceTitleOpenModel {\n");
            sb.Append("  PayerAddressTel: ").Append(PayerAddressTel).Append("\n");
            sb.Append("  PayerBankNameAccount: ").Append(PayerBankNameAccount).Append("\n");
            sb.Append("  PayerRegisterNo: ").Append(PayerRegisterNo).Append("\n");
            sb.Append("  TitleName: ").Append(TitleName).Append("\n");
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
            return this.Equals(input as InvoiceTitleOpenModel);
        }

        /// <summary>
        /// Returns true if InvoiceTitleOpenModel instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceTitleOpenModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceTitleOpenModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PayerAddressTel == input.PayerAddressTel ||
                    (this.PayerAddressTel != null &&
                    this.PayerAddressTel.Equals(input.PayerAddressTel))
                ) && 
                (
                    this.PayerBankNameAccount == input.PayerBankNameAccount ||
                    (this.PayerBankNameAccount != null &&
                    this.PayerBankNameAccount.Equals(input.PayerBankNameAccount))
                ) && 
                (
                    this.PayerRegisterNo == input.PayerRegisterNo ||
                    (this.PayerRegisterNo != null &&
                    this.PayerRegisterNo.Equals(input.PayerRegisterNo))
                ) && 
                (
                    this.TitleName == input.TitleName ||
                    (this.TitleName != null &&
                    this.TitleName.Equals(input.TitleName))
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
                if (this.PayerAddressTel != null)
                {
                    hashCode = (hashCode * 59) + this.PayerAddressTel.GetHashCode();
                }
                if (this.PayerBankNameAccount != null)
                {
                    hashCode = (hashCode * 59) + this.PayerBankNameAccount.GetHashCode();
                }
                if (this.PayerRegisterNo != null)
                {
                    hashCode = (hashCode * 59) + this.PayerRegisterNo.GetHashCode();
                }
                if (this.TitleName != null)
                {
                    hashCode = (hashCode * 59) + this.TitleName.GetHashCode();
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
