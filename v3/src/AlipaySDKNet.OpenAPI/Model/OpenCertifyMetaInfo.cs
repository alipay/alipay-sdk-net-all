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
    /// OpenCertifyMetaInfo
    /// </summary>
    [DataContract(Name = "OpenCertifyMetaInfo")]
    public partial class OpenCertifyMetaInfo : IEquatable<OpenCertifyMetaInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenCertifyMetaInfo" /> class.
        /// </summary>
        /// <param name="deviceType">设备操作系统类型.</param>
        public OpenCertifyMetaInfo(string deviceType = default(string))
        {
            this.DeviceType = deviceType;
        }

        /// <summary>
        /// 设备操作系统类型
        /// </summary>
        /// <value>设备操作系统类型</value>
        [DataMember(Name = "device_type", EmitDefaultValue = false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OpenCertifyMetaInfo {\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
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
            return this.Equals(input as OpenCertifyMetaInfo);
        }

        /// <summary>
        /// Returns true if OpenCertifyMetaInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenCertifyMetaInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenCertifyMetaInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeviceType == input.DeviceType ||
                    (this.DeviceType != null &&
                    this.DeviceType.Equals(input.DeviceType))
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
                if (this.DeviceType != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceType.GetHashCode();
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
