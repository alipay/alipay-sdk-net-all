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
    /// AlipayEbppInvoiceInstitutionExpenseruleCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceInstitutionExpenseruleCreateResponseModel")]
    public partial class AlipayEbppInvoiceInstitutionExpenseruleCreateResponseModel : IEquatable<AlipayEbppInvoiceInstitutionExpenseruleCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceInstitutionExpenseruleCreateResponseModel" /> class.
        /// </summary>
        /// <param name="standardId">使用规则id.</param>
        public AlipayEbppInvoiceInstitutionExpenseruleCreateResponseModel(string standardId = default(string))
        {
            this.StandardId = standardId;
        }

        /// <summary>
        /// 使用规则id
        /// </summary>
        /// <value>使用规则id</value>
        [DataMember(Name = "standard_id", EmitDefaultValue = false)]
        public string StandardId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceInstitutionExpenseruleCreateResponseModel {\n");
            sb.Append("  StandardId: ").Append(StandardId).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceInstitutionExpenseruleCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceInstitutionExpenseruleCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceInstitutionExpenseruleCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceInstitutionExpenseruleCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StandardId == input.StandardId ||
                    (this.StandardId != null &&
                    this.StandardId.Equals(input.StandardId))
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
                if (this.StandardId != null)
                {
                    hashCode = (hashCode * 59) + this.StandardId.GetHashCode();
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
