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
    /// AlipayOpenMiniInnerappPluginsyncmodeModifyModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerappPluginsyncmodeModifyModel")]
    public partial class AlipayOpenMiniInnerappPluginsyncmodeModifyModel : IEquatable<AlipayOpenMiniInnerappPluginsyncmodeModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerappPluginsyncmodeModifyModel" /> class.
        /// </summary>
        /// <param name="appOrigin">来源.</param>
        /// <param name="miniAppId">小程序应用 ID，.</param>
        /// <param name="pluginId">插件id.</param>
        /// <param name="syncMode">模式，SYNC/NONE.</param>
        public AlipayOpenMiniInnerappPluginsyncmodeModifyModel(string appOrigin = default(string), string miniAppId = default(string), string pluginId = default(string), string syncMode = default(string))
        {
            this.AppOrigin = appOrigin;
            this.MiniAppId = miniAppId;
            this.PluginId = pluginId;
            this.SyncMode = syncMode;
        }

        /// <summary>
        /// 来源
        /// </summary>
        /// <value>来源</value>
        [DataMember(Name = "app_origin", EmitDefaultValue = false)]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序应用 ID，
        /// </summary>
        /// <value>小程序应用 ID，</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 插件id
        /// </summary>
        /// <value>插件id</value>
        [DataMember(Name = "plugin_id", EmitDefaultValue = false)]
        public string PluginId { get; set; }

        /// <summary>
        /// 模式，SYNC/NONE
        /// </summary>
        /// <value>模式，SYNC/NONE</value>
        [DataMember(Name = "sync_mode", EmitDefaultValue = false)]
        public string SyncMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniInnerappPluginsyncmodeModifyModel {\n");
            sb.Append("  AppOrigin: ").Append(AppOrigin).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  PluginId: ").Append(PluginId).Append("\n");
            sb.Append("  SyncMode: ").Append(SyncMode).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniInnerappPluginsyncmodeModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerappPluginsyncmodeModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerappPluginsyncmodeModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerappPluginsyncmodeModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppOrigin == input.AppOrigin ||
                    (this.AppOrigin != null &&
                    this.AppOrigin.Equals(input.AppOrigin))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.PluginId == input.PluginId ||
                    (this.PluginId != null &&
                    this.PluginId.Equals(input.PluginId))
                ) && 
                (
                    this.SyncMode == input.SyncMode ||
                    (this.SyncMode != null &&
                    this.SyncMode.Equals(input.SyncMode))
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
                if (this.AppOrigin != null)
                {
                    hashCode = (hashCode * 59) + this.AppOrigin.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.PluginId != null)
                {
                    hashCode = (hashCode * 59) + this.PluginId.GetHashCode();
                }
                if (this.SyncMode != null)
                {
                    hashCode = (hashCode * 59) + this.SyncMode.GetHashCode();
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
