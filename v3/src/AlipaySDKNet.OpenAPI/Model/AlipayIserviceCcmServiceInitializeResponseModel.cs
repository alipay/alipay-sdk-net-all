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
    /// AlipayIserviceCcmServiceInitializeResponseModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmServiceInitializeResponseModel")]
    public partial class AlipayIserviceCcmServiceInitializeResponseModel : IEquatable<AlipayIserviceCcmServiceInitializeResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmServiceInitializeResponseModel" /> class.
        /// </summary>
        /// <param name="spiIds">spi在ccm中的唯一标识，与biz_code一一对应.</param>
        public AlipayIserviceCcmServiceInitializeResponseModel(List<SpiResult> spiIds = default(List<SpiResult>))
        {
            this.SpiIds = spiIds;
        }

        /// <summary>
        /// spi在ccm中的唯一标识，与biz_code一一对应
        /// </summary>
        /// <value>spi在ccm中的唯一标识，与biz_code一一对应</value>
        [DataMember(Name = "spi_ids", EmitDefaultValue = false)]
        public List<SpiResult> SpiIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmServiceInitializeResponseModel {\n");
            sb.Append("  SpiIds: ").Append(SpiIds).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmServiceInitializeResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmServiceInitializeResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmServiceInitializeResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmServiceInitializeResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SpiIds == input.SpiIds ||
                    this.SpiIds != null &&
                    input.SpiIds != null &&
                    this.SpiIds.SequenceEqual(input.SpiIds)
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
                if (this.SpiIds != null)
                {
                    hashCode = (hashCode * 59) + this.SpiIds.GetHashCode();
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
