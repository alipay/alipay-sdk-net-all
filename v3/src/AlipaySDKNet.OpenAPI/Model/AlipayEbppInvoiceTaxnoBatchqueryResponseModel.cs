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
    /// AlipayEbppInvoiceTaxnoBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceTaxnoBatchqueryResponseModel")]
    public partial class AlipayEbppInvoiceTaxnoBatchqueryResponseModel : IEquatable<AlipayEbppInvoiceTaxnoBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceTaxnoBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="invoiceElementList">发票要素列表.</param>
        /// <param name="openId">支付宝用户id.</param>
        /// <param name="userId">支付宝用户id.</param>
        public AlipayEbppInvoiceTaxnoBatchqueryResponseModel(List<InvoiceElementModel> invoiceElementList = default(List<InvoiceElementModel>), string openId = default(string), string userId = default(string))
        {
            this.InvoiceElementList = invoiceElementList;
            this.OpenId = openId;
            this.UserId = userId;
        }

        /// <summary>
        /// 发票要素列表
        /// </summary>
        /// <value>发票要素列表</value>
        [DataMember(Name = "invoice_element_list", EmitDefaultValue = false)]
        public List<InvoiceElementModel> InvoiceElementList { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        /// <value>支付宝用户id</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        /// <value>支付宝用户id</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceTaxnoBatchqueryResponseModel {\n");
            sb.Append("  InvoiceElementList: ").Append(InvoiceElementList).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceTaxnoBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceTaxnoBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceTaxnoBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceTaxnoBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InvoiceElementList == input.InvoiceElementList ||
                    this.InvoiceElementList != null &&
                    input.InvoiceElementList != null &&
                    this.InvoiceElementList.SequenceEqual(input.InvoiceElementList)
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
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
                if (this.InvoiceElementList != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceElementList.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
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
