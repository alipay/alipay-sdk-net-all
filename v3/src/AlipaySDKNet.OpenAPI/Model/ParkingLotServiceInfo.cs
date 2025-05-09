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
    /// ParkingLotServiceInfo
    /// </summary>
    [DataContract(Name = "ParkingLotServiceInfo")]
    public partial class ParkingLotServiceInfo : IEquatable<ParkingLotServiceInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParkingLotServiceInfo" /> class.
        /// </summary>
        /// <param name="serviceName">在线缴费服务名称.</param>
        /// <param name="serviceType">停车场可提供的服务类型 发票服务：INVOICE_SERVICE 优惠套餐: DISCOUNT_PACKAGE 预约停车: RESERVED_PARKING.</param>
        /// <param name="serviceUrl">商户提供服务对应的跳转链接.</param>
        public ParkingLotServiceInfo(string serviceName = default(string), string serviceType = default(string), string serviceUrl = default(string))
        {
            this.ServiceName = serviceName;
            this.ServiceType = serviceType;
            this.ServiceUrl = serviceUrl;
        }

        /// <summary>
        /// 在线缴费服务名称
        /// </summary>
        /// <value>在线缴费服务名称</value>
        [DataMember(Name = "service_name", EmitDefaultValue = false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 停车场可提供的服务类型 发票服务：INVOICE_SERVICE 优惠套餐: DISCOUNT_PACKAGE 预约停车: RESERVED_PARKING
        /// </summary>
        /// <value>停车场可提供的服务类型 发票服务：INVOICE_SERVICE 优惠套餐: DISCOUNT_PACKAGE 预约停车: RESERVED_PARKING</value>
        [DataMember(Name = "service_type", EmitDefaultValue = false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// 商户提供服务对应的跳转链接
        /// </summary>
        /// <value>商户提供服务对应的跳转链接</value>
        [DataMember(Name = "service_url", EmitDefaultValue = false)]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ParkingLotServiceInfo {\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  ServiceUrl: ").Append(ServiceUrl).Append("\n");
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
            return this.Equals(input as ParkingLotServiceInfo);
        }

        /// <summary>
        /// Returns true if ParkingLotServiceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ParkingLotServiceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParkingLotServiceInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    (this.ServiceType != null &&
                    this.ServiceType.Equals(input.ServiceType))
                ) && 
                (
                    this.ServiceUrl == input.ServiceUrl ||
                    (this.ServiceUrl != null &&
                    this.ServiceUrl.Equals(input.ServiceUrl))
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
                if (this.ServiceName != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceName.GetHashCode();
                }
                if (this.ServiceType != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceType.GetHashCode();
                }
                if (this.ServiceUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceUrl.GetHashCode();
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
