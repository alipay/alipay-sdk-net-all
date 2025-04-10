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
    /// OrderVehicleInfo
    /// </summary>
    [DataContract(Name = "OrderVehicleInfo")]
    public partial class OrderVehicleInfo : IEquatable<OrderVehicleInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderVehicleInfo" /> class.
        /// </summary>
        /// <param name="licensePlateNo">交通工具牌照号，如车牌号等.</param>
        /// <param name="memo">备注信息.</param>
        /// <param name="shiftNo">班次.</param>
        public OrderVehicleInfo(string licensePlateNo = default(string), string memo = default(string), string shiftNo = default(string))
        {
            this.LicensePlateNo = licensePlateNo;
            this.Memo = memo;
            this.ShiftNo = shiftNo;
        }

        /// <summary>
        /// 交通工具牌照号，如车牌号等
        /// </summary>
        /// <value>交通工具牌照号，如车牌号等</value>
        [DataMember(Name = "license_plate_no", EmitDefaultValue = false)]
        public string LicensePlateNo { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        /// <value>备注信息</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 班次
        /// </summary>
        /// <value>班次</value>
        [DataMember(Name = "shift_no", EmitDefaultValue = false)]
        public string ShiftNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderVehicleInfo {\n");
            sb.Append("  LicensePlateNo: ").Append(LicensePlateNo).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  ShiftNo: ").Append(ShiftNo).Append("\n");
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
            return this.Equals(input as OrderVehicleInfo);
        }

        /// <summary>
        /// Returns true if OrderVehicleInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderVehicleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderVehicleInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LicensePlateNo == input.LicensePlateNo ||
                    (this.LicensePlateNo != null &&
                    this.LicensePlateNo.Equals(input.LicensePlateNo))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.ShiftNo == input.ShiftNo ||
                    (this.ShiftNo != null &&
                    this.ShiftNo.Equals(input.ShiftNo))
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
                if (this.LicensePlateNo != null)
                {
                    hashCode = (hashCode * 59) + this.LicensePlateNo.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.ShiftNo != null)
                {
                    hashCode = (hashCode * 59) + this.ShiftNo.GetHashCode();
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
