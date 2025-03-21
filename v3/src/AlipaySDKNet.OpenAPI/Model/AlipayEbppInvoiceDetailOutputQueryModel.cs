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
    /// AlipayEbppInvoiceDetailOutputQueryModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceDetailOutputQueryModel")]
    public partial class AlipayEbppInvoiceDetailOutputQueryModel : IEquatable<AlipayEbppInvoiceDetailOutputQueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceDetailOutputQueryModel" /> class.
        /// </summary>
        /// <param name="invoiceCode">发票代码 长度限制（10-12位），全电票则为空.</param>
        /// <param name="invoiceNo">发票号码 长度限制（8-20位）.</param>
        /// <param name="openId">支付宝用户 id.</param>
        /// <param name="scene">获取发票明细应用场景。固定为 INVOICE_EXPENSE  表示发票报销。.</param>
        /// <param name="skipExpenseProgressSync">是否跳过发票报销状态同步；当为true时，跳过报销状态同步校验。默认为false，需要先做报销状态同步.</param>
        /// <param name="userId">发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。.</param>
        public AlipayEbppInvoiceDetailOutputQueryModel(string invoiceCode = default(string), string invoiceNo = default(string), string openId = default(string), string scene = default(string), bool skipExpenseProgressSync = default(bool), string userId = default(string))
        {
            this.InvoiceCode = invoiceCode;
            this.InvoiceNo = invoiceNo;
            this.OpenId = openId;
            this.Scene = scene;
            this.SkipExpenseProgressSync = skipExpenseProgressSync;
            this.UserId = userId;
        }

        /// <summary>
        /// 发票代码 长度限制（10-12位），全电票则为空
        /// </summary>
        /// <value>发票代码 长度限制（10-12位），全电票则为空</value>
        [DataMember(Name = "invoice_code", EmitDefaultValue = false)]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码 长度限制（8-20位）
        /// </summary>
        /// <value>发票号码 长度限制（8-20位）</value>
        [DataMember(Name = "invoice_no", EmitDefaultValue = false)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 支付宝用户 id
        /// </summary>
        /// <value>支付宝用户 id</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 获取发票明细应用场景。固定为 INVOICE_EXPENSE  表示发票报销。
        /// </summary>
        /// <value>获取发票明细应用场景。固定为 INVOICE_EXPENSE  表示发票报销。</value>
        [DataMember(Name = "scene", EmitDefaultValue = false)]
        public string Scene { get; set; }

        /// <summary>
        /// 是否跳过发票报销状态同步；当为true时，跳过报销状态同步校验。默认为false，需要先做报销状态同步
        /// </summary>
        /// <value>是否跳过发票报销状态同步；当为true时，跳过报销状态同步校验。默认为false，需要先做报销状态同步</value>
        [DataMember(Name = "skip_expense_progress_sync", EmitDefaultValue = true)]
        public bool SkipExpenseProgressSync { get; set; }

        /// <summary>
        /// 发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        /// <value>发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceDetailOutputQueryModel {\n");
            sb.Append("  InvoiceCode: ").Append(InvoiceCode).Append("\n");
            sb.Append("  InvoiceNo: ").Append(InvoiceNo).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  Scene: ").Append(Scene).Append("\n");
            sb.Append("  SkipExpenseProgressSync: ").Append(SkipExpenseProgressSync).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceDetailOutputQueryModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceDetailOutputQueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceDetailOutputQueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceDetailOutputQueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InvoiceCode == input.InvoiceCode ||
                    (this.InvoiceCode != null &&
                    this.InvoiceCode.Equals(input.InvoiceCode))
                ) && 
                (
                    this.InvoiceNo == input.InvoiceNo ||
                    (this.InvoiceNo != null &&
                    this.InvoiceNo.Equals(input.InvoiceNo))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.Scene == input.Scene ||
                    (this.Scene != null &&
                    this.Scene.Equals(input.Scene))
                ) && 
                (
                    this.SkipExpenseProgressSync == input.SkipExpenseProgressSync ||
                    this.SkipExpenseProgressSync.Equals(input.SkipExpenseProgressSync)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.InvoiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceCode.GetHashCode();
                }
                if (this.InvoiceNo != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceNo.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.Scene != null)
                {
                    hashCode = (hashCode * 59) + this.Scene.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SkipExpenseProgressSync.GetHashCode();
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
