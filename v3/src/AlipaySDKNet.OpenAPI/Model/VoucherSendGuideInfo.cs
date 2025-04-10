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
    /// VoucherSendGuideInfo
    /// </summary>
    [DataContract(Name = "VoucherSendGuideInfo")]
    public partial class VoucherSendGuideInfo : IEquatable<VoucherSendGuideInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherSendGuideInfo" /> class.
        /// </summary>
        /// <param name="miniAppSendGuideInfo">miniAppSendGuideInfo.</param>
        /// <param name="sendGuideMode">发放引导模式.</param>
        public VoucherSendGuideInfo(VoucherMiniAppSendGuideInfo miniAppSendGuideInfo = default(VoucherMiniAppSendGuideInfo), List<string> sendGuideMode = default(List<string>))
        {
            this.MiniAppSendGuideInfo = miniAppSendGuideInfo;
            this.SendGuideMode = sendGuideMode;
        }

        /// <summary>
        /// Gets or Sets MiniAppSendGuideInfo
        /// </summary>
        [DataMember(Name = "mini_app_send_guide_info", EmitDefaultValue = false)]
        public VoucherMiniAppSendGuideInfo MiniAppSendGuideInfo { get; set; }

        /// <summary>
        /// 发放引导模式
        /// </summary>
        /// <value>发放引导模式</value>
        [DataMember(Name = "send_guide_mode", EmitDefaultValue = false)]
        public List<string> SendGuideMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherSendGuideInfo {\n");
            sb.Append("  MiniAppSendGuideInfo: ").Append(MiniAppSendGuideInfo).Append("\n");
            sb.Append("  SendGuideMode: ").Append(SendGuideMode).Append("\n");
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
            return this.Equals(input as VoucherSendGuideInfo);
        }

        /// <summary>
        /// Returns true if VoucherSendGuideInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherSendGuideInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherSendGuideInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MiniAppSendGuideInfo == input.MiniAppSendGuideInfo ||
                    (this.MiniAppSendGuideInfo != null &&
                    this.MiniAppSendGuideInfo.Equals(input.MiniAppSendGuideInfo))
                ) && 
                (
                    this.SendGuideMode == input.SendGuideMode ||
                    this.SendGuideMode != null &&
                    input.SendGuideMode != null &&
                    this.SendGuideMode.SequenceEqual(input.SendGuideMode)
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
                if (this.MiniAppSendGuideInfo != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppSendGuideInfo.GetHashCode();
                }
                if (this.SendGuideMode != null)
                {
                    hashCode = (hashCode * 59) + this.SendGuideMode.GetHashCode();
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
