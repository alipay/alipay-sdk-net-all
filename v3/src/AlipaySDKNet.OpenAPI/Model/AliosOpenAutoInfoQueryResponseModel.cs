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
    /// AliosOpenAutoInfoQueryResponseModel
    /// </summary>
    [DataContract(Name = "AliosOpenAutoInfoQueryResponseModel")]
    public partial class AliosOpenAutoInfoQueryResponseModel : IEquatable<AliosOpenAutoInfoQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AliosOpenAutoInfoQueryResponseModel" /> class.
        /// </summary>
        /// <param name="engineNo">发动机号.</param>
        /// <param name="licenseNo">车牌号.</param>
        /// <param name="userActivationTime">用户激活时间.</param>
        /// <param name="vehicleType">车辆类型.</param>
        /// <param name="vin">车辆识别号码.</param>
        public AliosOpenAutoInfoQueryResponseModel(string engineNo = default(string), string licenseNo = default(string), string userActivationTime = default(string), string vehicleType = default(string), string vin = default(string))
        {
            this.EngineNo = engineNo;
            this.LicenseNo = licenseNo;
            this.UserActivationTime = userActivationTime;
            this.VehicleType = vehicleType;
            this.Vin = vin;
        }

        /// <summary>
        /// 发动机号
        /// </summary>
        /// <value>发动机号</value>
        [DataMember(Name = "engine_no", EmitDefaultValue = false)]
        public string EngineNo { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        /// <value>车牌号</value>
        [DataMember(Name = "license_no", EmitDefaultValue = false)]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 用户激活时间
        /// </summary>
        /// <value>用户激活时间</value>
        [DataMember(Name = "user_activation_time", EmitDefaultValue = false)]
        public string UserActivationTime { get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        /// <value>车辆类型</value>
        [DataMember(Name = "vehicle_type", EmitDefaultValue = false)]
        public string VehicleType { get; set; }

        /// <summary>
        /// 车辆识别号码
        /// </summary>
        /// <value>车辆识别号码</value>
        [DataMember(Name = "vin", EmitDefaultValue = false)]
        public string Vin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AliosOpenAutoInfoQueryResponseModel {\n");
            sb.Append("  EngineNo: ").Append(EngineNo).Append("\n");
            sb.Append("  LicenseNo: ").Append(LicenseNo).Append("\n");
            sb.Append("  UserActivationTime: ").Append(UserActivationTime).Append("\n");
            sb.Append("  VehicleType: ").Append(VehicleType).Append("\n");
            sb.Append("  Vin: ").Append(Vin).Append("\n");
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
            return this.Equals(input as AliosOpenAutoInfoQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AliosOpenAutoInfoQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AliosOpenAutoInfoQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AliosOpenAutoInfoQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EngineNo == input.EngineNo ||
                    (this.EngineNo != null &&
                    this.EngineNo.Equals(input.EngineNo))
                ) && 
                (
                    this.LicenseNo == input.LicenseNo ||
                    (this.LicenseNo != null &&
                    this.LicenseNo.Equals(input.LicenseNo))
                ) && 
                (
                    this.UserActivationTime == input.UserActivationTime ||
                    (this.UserActivationTime != null &&
                    this.UserActivationTime.Equals(input.UserActivationTime))
                ) && 
                (
                    this.VehicleType == input.VehicleType ||
                    (this.VehicleType != null &&
                    this.VehicleType.Equals(input.VehicleType))
                ) && 
                (
                    this.Vin == input.Vin ||
                    (this.Vin != null &&
                    this.Vin.Equals(input.Vin))
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
                if (this.EngineNo != null)
                {
                    hashCode = (hashCode * 59) + this.EngineNo.GetHashCode();
                }
                if (this.LicenseNo != null)
                {
                    hashCode = (hashCode * 59) + this.LicenseNo.GetHashCode();
                }
                if (this.UserActivationTime != null)
                {
                    hashCode = (hashCode * 59) + this.UserActivationTime.GetHashCode();
                }
                if (this.VehicleType != null)
                {
                    hashCode = (hashCode * 59) + this.VehicleType.GetHashCode();
                }
                if (this.Vin != null)
                {
                    hashCode = (hashCode * 59) + this.Vin.GetHashCode();
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
