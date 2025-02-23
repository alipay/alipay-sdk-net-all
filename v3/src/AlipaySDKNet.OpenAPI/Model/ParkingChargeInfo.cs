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
    /// ParkingChargeInfo
    /// </summary>
    [DataContract(Name = "ParkingChargeInfo")]
    public partial class ParkingChargeInfo : IEquatable<ParkingChargeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParkingChargeInfo" /> class.
        /// </summary>
        /// <param name="chargeFee">计费金额；单位元；.</param>
        /// <param name="chargeNode">START_CHARGING：开始计费 FEE_INCREASE：费用增加 TO_TOP：日封顶.</param>
        /// <param name="chargeTime">开始计费或者费用增加的时间；传东八区时间；.</param>
        public ParkingChargeInfo(string chargeFee = default(string), string chargeNode = default(string), string chargeTime = default(string))
        {
            this.ChargeFee = chargeFee;
            this.ChargeNode = chargeNode;
            this.ChargeTime = chargeTime;
        }

        /// <summary>
        /// 计费金额；单位元；
        /// </summary>
        /// <value>计费金额；单位元；</value>
        [DataMember(Name = "charge_fee", EmitDefaultValue = false)]
        public string ChargeFee { get; set; }

        /// <summary>
        /// START_CHARGING：开始计费 FEE_INCREASE：费用增加 TO_TOP：日封顶
        /// </summary>
        /// <value>START_CHARGING：开始计费 FEE_INCREASE：费用增加 TO_TOP：日封顶</value>
        [DataMember(Name = "charge_node", EmitDefaultValue = false)]
        public string ChargeNode { get; set; }

        /// <summary>
        /// 开始计费或者费用增加的时间；传东八区时间；
        /// </summary>
        /// <value>开始计费或者费用增加的时间；传东八区时间；</value>
        [DataMember(Name = "charge_time", EmitDefaultValue = false)]
        public string ChargeTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ParkingChargeInfo {\n");
            sb.Append("  ChargeFee: ").Append(ChargeFee).Append("\n");
            sb.Append("  ChargeNode: ").Append(ChargeNode).Append("\n");
            sb.Append("  ChargeTime: ").Append(ChargeTime).Append("\n");
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
            return this.Equals(input as ParkingChargeInfo);
        }

        /// <summary>
        /// Returns true if ParkingChargeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ParkingChargeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParkingChargeInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ChargeFee == input.ChargeFee ||
                    (this.ChargeFee != null &&
                    this.ChargeFee.Equals(input.ChargeFee))
                ) && 
                (
                    this.ChargeNode == input.ChargeNode ||
                    (this.ChargeNode != null &&
                    this.ChargeNode.Equals(input.ChargeNode))
                ) && 
                (
                    this.ChargeTime == input.ChargeTime ||
                    (this.ChargeTime != null &&
                    this.ChargeTime.Equals(input.ChargeTime))
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
                if (this.ChargeFee != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeFee.GetHashCode();
                }
                if (this.ChargeNode != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeNode.GetHashCode();
                }
                if (this.ChargeTime != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeTime.GetHashCode();
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
