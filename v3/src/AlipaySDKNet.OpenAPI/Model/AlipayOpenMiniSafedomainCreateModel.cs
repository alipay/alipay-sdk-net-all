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
    /// AlipayOpenMiniSafedomainCreateModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniSafedomainCreateModel")]
    public partial class AlipayOpenMiniSafedomainCreateModel : IEquatable<AlipayOpenMiniSafedomainCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniSafedomainCreateModel" /> class.
        /// </summary>
        /// <param name="safeDomain">服务器域名白名单。支付宝小程序在HTTP请求、上传文件等场景只能与域名白名单中的域名进行通讯 。 新添加域白名单后需重新上传应用版本（模板模式下小程序模板及商家应用都需重新上传、实例化版本）才会生效。老版本应用继续使用老版本名单。 每个应用最多可添加30个 URL。.</param>
        public AlipayOpenMiniSafedomainCreateModel(string safeDomain = default(string))
        {
            this.SafeDomain = safeDomain;
        }

        /// <summary>
        /// 服务器域名白名单。支付宝小程序在HTTP请求、上传文件等场景只能与域名白名单中的域名进行通讯 。 新添加域白名单后需重新上传应用版本（模板模式下小程序模板及商家应用都需重新上传、实例化版本）才会生效。老版本应用继续使用老版本名单。 每个应用最多可添加30个 URL。
        /// </summary>
        /// <value>服务器域名白名单。支付宝小程序在HTTP请求、上传文件等场景只能与域名白名单中的域名进行通讯 。 新添加域白名单后需重新上传应用版本（模板模式下小程序模板及商家应用都需重新上传、实例化版本）才会生效。老版本应用继续使用老版本名单。 每个应用最多可添加30个 URL。</value>
        [DataMember(Name = "safe_domain", EmitDefaultValue = false)]
        public string SafeDomain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniSafedomainCreateModel {\n");
            sb.Append("  SafeDomain: ").Append(SafeDomain).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniSafedomainCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniSafedomainCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniSafedomainCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniSafedomainCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SafeDomain == input.SafeDomain ||
                    (this.SafeDomain != null &&
                    this.SafeDomain.Equals(input.SafeDomain))
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
                if (this.SafeDomain != null)
                {
                    hashCode = (hashCode * 59) + this.SafeDomain.GetHashCode();
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
