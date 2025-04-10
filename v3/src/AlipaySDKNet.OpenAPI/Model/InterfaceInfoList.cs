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
    /// InterfaceInfoList
    /// </summary>
    [DataContract(Name = "InterfaceInfoList")]
    public partial class InterfaceInfoList : IEquatable<InterfaceInfoList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceInfoList" /> class.
        /// </summary>
        /// <param name="interfaceName">H5传入参数固定值：alipay.eco.mycar.parking.userpage.query;  小程序传入参数固定值：alipay.eco.mycar.parking.isv.homepage;  协议状态变更通知传入参数固定值： alipay.eco.mycar.parking.agreement.notify;.</param>
        /// <param name="interfaceType">H5、小程序传入参数固定值:interface_page； 通知接口传入参数固定值:interface_service;.</param>
        /// <param name="interfaceUrl">H5 SPI接口的调用地址url，协议必须为https，对整个url字符串必须进行UrlEncode编码。编码为UTF-8;  小程序SPI接口的调用地址ur格式：小程序|小程序缴费页面地址;  协议状态变更通知SPI接口的调用地址url，同H5格式;.</param>
        public InterfaceInfoList(string interfaceName = default(string), string interfaceType = default(string), string interfaceUrl = default(string))
        {
            this.InterfaceName = interfaceName;
            this.InterfaceType = interfaceType;
            this.InterfaceUrl = interfaceUrl;
        }

        /// <summary>
        /// H5传入参数固定值：alipay.eco.mycar.parking.userpage.query;  小程序传入参数固定值：alipay.eco.mycar.parking.isv.homepage;  协议状态变更通知传入参数固定值： alipay.eco.mycar.parking.agreement.notify;
        /// </summary>
        /// <value>H5传入参数固定值：alipay.eco.mycar.parking.userpage.query;  小程序传入参数固定值：alipay.eco.mycar.parking.isv.homepage;  协议状态变更通知传入参数固定值： alipay.eco.mycar.parking.agreement.notify;</value>
        [DataMember(Name = "interface_name", EmitDefaultValue = false)]
        public string InterfaceName { get; set; }

        /// <summary>
        /// H5、小程序传入参数固定值:interface_page； 通知接口传入参数固定值:interface_service;
        /// </summary>
        /// <value>H5、小程序传入参数固定值:interface_page； 通知接口传入参数固定值:interface_service;</value>
        [DataMember(Name = "interface_type", EmitDefaultValue = false)]
        public string InterfaceType { get; set; }

        /// <summary>
        /// H5 SPI接口的调用地址url，协议必须为https，对整个url字符串必须进行UrlEncode编码。编码为UTF-8;  小程序SPI接口的调用地址ur格式：小程序|小程序缴费页面地址;  协议状态变更通知SPI接口的调用地址url，同H5格式;
        /// </summary>
        /// <value>H5 SPI接口的调用地址url，协议必须为https，对整个url字符串必须进行UrlEncode编码。编码为UTF-8;  小程序SPI接口的调用地址ur格式：小程序|小程序缴费页面地址;  协议状态变更通知SPI接口的调用地址url，同H5格式;</value>
        [DataMember(Name = "interface_url", EmitDefaultValue = false)]
        public string InterfaceUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InterfaceInfoList {\n");
            sb.Append("  InterfaceName: ").Append(InterfaceName).Append("\n");
            sb.Append("  InterfaceType: ").Append(InterfaceType).Append("\n");
            sb.Append("  InterfaceUrl: ").Append(InterfaceUrl).Append("\n");
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
            return this.Equals(input as InterfaceInfoList);
        }

        /// <summary>
        /// Returns true if InterfaceInfoList instances are equal
        /// </summary>
        /// <param name="input">Instance of InterfaceInfoList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterfaceInfoList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InterfaceName == input.InterfaceName ||
                    (this.InterfaceName != null &&
                    this.InterfaceName.Equals(input.InterfaceName))
                ) && 
                (
                    this.InterfaceType == input.InterfaceType ||
                    (this.InterfaceType != null &&
                    this.InterfaceType.Equals(input.InterfaceType))
                ) && 
                (
                    this.InterfaceUrl == input.InterfaceUrl ||
                    (this.InterfaceUrl != null &&
                    this.InterfaceUrl.Equals(input.InterfaceUrl))
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
                if (this.InterfaceName != null)
                {
                    hashCode = (hashCode * 59) + this.InterfaceName.GetHashCode();
                }
                if (this.InterfaceType != null)
                {
                    hashCode = (hashCode * 59) + this.InterfaceType.GetHashCode();
                }
                if (this.InterfaceUrl != null)
                {
                    hashCode = (hashCode * 59) + this.InterfaceUrl.GetHashCode();
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
