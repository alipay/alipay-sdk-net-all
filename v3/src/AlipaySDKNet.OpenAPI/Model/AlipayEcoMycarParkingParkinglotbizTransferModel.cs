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
    /// AlipayEcoMycarParkingParkinglotbizTransferModel
    /// </summary>
    [DataContract(Name = "AlipayEcoMycarParkingParkinglotbizTransferModel")]
    public partial class AlipayEcoMycarParkingParkinglotbizTransferModel : IEquatable<AlipayEcoMycarParkingParkinglotbizTransferModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoMycarParkingParkinglotbizTransferModel" /> class.
        /// </summary>
        /// <param name="businessIsv">车场业务归属关系列表.</param>
        /// <param name="parkingId">车场创建返回的parking_id字段.</param>
        public AlipayEcoMycarParkingParkinglotbizTransferModel(List<BusinessItem> businessIsv = default(List<BusinessItem>), string parkingId = default(string))
        {
            this.BusinessIsv = businessIsv;
            this.ParkingId = parkingId;
        }

        /// <summary>
        /// 车场业务归属关系列表
        /// </summary>
        /// <value>车场业务归属关系列表</value>
        [DataMember(Name = "business_isv", EmitDefaultValue = false)]
        public List<BusinessItem> BusinessIsv { get; set; }

        /// <summary>
        /// 车场创建返回的parking_id字段
        /// </summary>
        /// <value>车场创建返回的parking_id字段</value>
        [DataMember(Name = "parking_id", EmitDefaultValue = false)]
        public string ParkingId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEcoMycarParkingParkinglotbizTransferModel {\n");
            sb.Append("  BusinessIsv: ").Append(BusinessIsv).Append("\n");
            sb.Append("  ParkingId: ").Append(ParkingId).Append("\n");
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
            return this.Equals(input as AlipayEcoMycarParkingParkinglotbizTransferModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoMycarParkingParkinglotbizTransferModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoMycarParkingParkinglotbizTransferModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoMycarParkingParkinglotbizTransferModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BusinessIsv == input.BusinessIsv ||
                    this.BusinessIsv != null &&
                    input.BusinessIsv != null &&
                    this.BusinessIsv.SequenceEqual(input.BusinessIsv)
                ) && 
                (
                    this.ParkingId == input.ParkingId ||
                    (this.ParkingId != null &&
                    this.ParkingId.Equals(input.ParkingId))
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
                if (this.BusinessIsv != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessIsv.GetHashCode();
                }
                if (this.ParkingId != null)
                {
                    hashCode = (hashCode * 59) + this.ParkingId.GetHashCode();
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
