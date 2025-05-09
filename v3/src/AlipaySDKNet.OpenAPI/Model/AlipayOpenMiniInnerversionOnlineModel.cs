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
    /// AlipayOpenMiniInnerversionOnlineModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerversionOnlineModel")]
    public partial class AlipayOpenMiniInnerversionOnlineModel : IEquatable<AlipayOpenMiniInnerversionOnlineModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionOnlineModel" /> class.
        /// </summary>
        /// <param name="appOfflineVersion">下架版本.</param>
        /// <param name="appOnlineVersion">上架版本.</param>
        /// <param name="appOrigin">业务来源.</param>
        /// <param name="bundleId">一个端的标识，用于区分不同的客户端，每接入一个客户端，都需要向小程序应用中心申请bundelId入驻.</param>
        /// <param name="instCode">租户code，alipay or taobao.</param>
        /// <param name="miniAppId">小程序ID.</param>
        public AlipayOpenMiniInnerversionOnlineModel(string appOfflineVersion = default(string), string appOnlineVersion = default(string), string appOrigin = default(string), string bundleId = default(string), string instCode = default(string), string miniAppId = default(string))
        {
            this.AppOfflineVersion = appOfflineVersion;
            this.AppOnlineVersion = appOnlineVersion;
            this.AppOrigin = appOrigin;
            this.BundleId = bundleId;
            this.InstCode = instCode;
            this.MiniAppId = miniAppId;
        }

        /// <summary>
        /// 下架版本
        /// </summary>
        /// <value>下架版本</value>
        [DataMember(Name = "app_offline_version", EmitDefaultValue = false)]
        public string AppOfflineVersion { get; set; }

        /// <summary>
        /// 上架版本
        /// </summary>
        /// <value>上架版本</value>
        [DataMember(Name = "app_online_version", EmitDefaultValue = false)]
        public string AppOnlineVersion { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        /// <value>业务来源</value>
        [DataMember(Name = "app_origin", EmitDefaultValue = false)]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 一个端的标识，用于区分不同的客户端，每接入一个客户端，都需要向小程序应用中心申请bundelId入驻
        /// </summary>
        /// <value>一个端的标识，用于区分不同的客户端，每接入一个客户端，都需要向小程序应用中心申请bundelId入驻</value>
        [DataMember(Name = "bundle_id", EmitDefaultValue = false)]
        public string BundleId { get; set; }

        /// <summary>
        /// 租户code，alipay or taobao
        /// </summary>
        /// <value>租户code，alipay or taobao</value>
        [DataMember(Name = "inst_code", EmitDefaultValue = false)]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        /// <value>小程序ID</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniInnerversionOnlineModel {\n");
            sb.Append("  AppOfflineVersion: ").Append(AppOfflineVersion).Append("\n");
            sb.Append("  AppOnlineVersion: ").Append(AppOnlineVersion).Append("\n");
            sb.Append("  AppOrigin: ").Append(AppOrigin).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  InstCode: ").Append(InstCode).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniInnerversionOnlineModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerversionOnlineModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerversionOnlineModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerversionOnlineModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppOfflineVersion == input.AppOfflineVersion ||
                    (this.AppOfflineVersion != null &&
                    this.AppOfflineVersion.Equals(input.AppOfflineVersion))
                ) && 
                (
                    this.AppOnlineVersion == input.AppOnlineVersion ||
                    (this.AppOnlineVersion != null &&
                    this.AppOnlineVersion.Equals(input.AppOnlineVersion))
                ) && 
                (
                    this.AppOrigin == input.AppOrigin ||
                    (this.AppOrigin != null &&
                    this.AppOrigin.Equals(input.AppOrigin))
                ) && 
                (
                    this.BundleId == input.BundleId ||
                    (this.BundleId != null &&
                    this.BundleId.Equals(input.BundleId))
                ) && 
                (
                    this.InstCode == input.InstCode ||
                    (this.InstCode != null &&
                    this.InstCode.Equals(input.InstCode))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
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
                if (this.AppOfflineVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppOfflineVersion.GetHashCode();
                }
                if (this.AppOnlineVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppOnlineVersion.GetHashCode();
                }
                if (this.AppOrigin != null)
                {
                    hashCode = (hashCode * 59) + this.AppOrigin.GetHashCode();
                }
                if (this.BundleId != null)
                {
                    hashCode = (hashCode * 59) + this.BundleId.GetHashCode();
                }
                if (this.InstCode != null)
                {
                    hashCode = (hashCode * 59) + this.InstCode.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
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
