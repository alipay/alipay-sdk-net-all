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
    /// AlipayBossFncUserinvoiceinfoQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayBossFncUserinvoiceinfoQueryResponseModel")]
    public partial class AlipayBossFncUserinvoiceinfoQueryResponseModel : IEquatable<AlipayBossFncUserinvoiceinfoQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayBossFncUserinvoiceinfoQueryResponseModel" /> class.
        /// </summary>
        /// <param name="resultSet">resultSet.</param>
        public AlipayBossFncUserinvoiceinfoQueryResponseModel(UserInvoiceInfoOpenApiResponse resultSet = default(UserInvoiceInfoOpenApiResponse))
        {
            this.ResultSet = resultSet;
        }

        /// <summary>
        /// Gets or Sets ResultSet
        /// </summary>
        [DataMember(Name = "result_set", EmitDefaultValue = false)]
        public UserInvoiceInfoOpenApiResponse ResultSet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayBossFncUserinvoiceinfoQueryResponseModel {\n");
            sb.Append("  ResultSet: ").Append(ResultSet).Append("\n");
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
            return this.Equals(input as AlipayBossFncUserinvoiceinfoQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayBossFncUserinvoiceinfoQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayBossFncUserinvoiceinfoQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayBossFncUserinvoiceinfoQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ResultSet == input.ResultSet ||
                    (this.ResultSet != null &&
                    this.ResultSet.Equals(input.ResultSet))
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
                if (this.ResultSet != null)
                {
                    hashCode = (hashCode * 59) + this.ResultSet.GetHashCode();
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
