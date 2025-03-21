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
    /// AlipayOpenMiniVersionUploadModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniVersionUploadModel")]
    public partial class AlipayOpenMiniVersionUploadModel : IEquatable<AlipayOpenMiniVersionUploadModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniVersionUploadModel" /> class.
        /// </summary>
        /// <param name="appVersion">商家小程序版本号。版本号必须满足 x.y.z, 且均为数字。要求版本号比商户之前最新的版本号高。.</param>
        /// <param name="bundleId">小程序客户端类型，默认为支付宝端。常见支持如下客户端： com.alipay.alipaywallet：支付宝端； com.alibaba.android.rimet：DINGDING端； com.amap.app：高德端； com.alibaba.ailabs.genie.webapps：天猫精灵端； com.alipay.iot.xpaas：支付宝IoT端。 如需更多端投放，请联系业务BD。.</param>
        /// <param name="ext">自定义参数，用于配置商家小程序的个性化内容，具体使用方法参见示例代码。 在小程序中可以通过 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/api/getExtConfig\&quot;&gt;my.getExtConfig()&lt;/a&gt; 或 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/api/getExtConfigSync\&quot;&gt;my.getExtConfigSync()&lt;/a&gt; 获取 ext 参数内容（建议支付宝版本 &gt; 10.1.38，并使用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/api/can-i-use\&quot;&gt;my.canIUse&lt;/a&gt; 做兼容处理）。.</param>
        /// <param name="templateId">小程序模板 APPID。.</param>
        /// <param name="templateVersion">小程序模板版本号。版本号必须满足 x.y.z, 且均为数字。不传默认使用最新在架（已上架）模板版本。.</param>
        public AlipayOpenMiniVersionUploadModel(string appVersion = default(string), string bundleId = default(string), string ext = default(string), string templateId = default(string), string templateVersion = default(string))
        {
            this.AppVersion = appVersion;
            this.BundleId = bundleId;
            this.Ext = ext;
            this.TemplateId = templateId;
            this.TemplateVersion = templateVersion;
        }

        /// <summary>
        /// 商家小程序版本号。版本号必须满足 x.y.z, 且均为数字。要求版本号比商户之前最新的版本号高。
        /// </summary>
        /// <value>商家小程序版本号。版本号必须满足 x.y.z, 且均为数字。要求版本号比商户之前最新的版本号高。</value>
        [DataMember(Name = "app_version", EmitDefaultValue = false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序客户端类型，默认为支付宝端。常见支持如下客户端： com.alipay.alipaywallet：支付宝端； com.alibaba.android.rimet：DINGDING端； com.amap.app：高德端； com.alibaba.ailabs.genie.webapps：天猫精灵端； com.alipay.iot.xpaas：支付宝IoT端。 如需更多端投放，请联系业务BD。
        /// </summary>
        /// <value>小程序客户端类型，默认为支付宝端。常见支持如下客户端： com.alipay.alipaywallet：支付宝端； com.alibaba.android.rimet：DINGDING端； com.amap.app：高德端； com.alibaba.ailabs.genie.webapps：天猫精灵端； com.alipay.iot.xpaas：支付宝IoT端。 如需更多端投放，请联系业务BD。</value>
        [DataMember(Name = "bundle_id", EmitDefaultValue = false)]
        public string BundleId { get; set; }

        /// <summary>
        /// 自定义参数，用于配置商家小程序的个性化内容，具体使用方法参见示例代码。 在小程序中可以通过 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/api/getExtConfig\&quot;&gt;my.getExtConfig()&lt;/a&gt; 或 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/api/getExtConfigSync\&quot;&gt;my.getExtConfigSync()&lt;/a&gt; 获取 ext 参数内容（建议支付宝版本 &gt; 10.1.38，并使用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/api/can-i-use\&quot;&gt;my.canIUse&lt;/a&gt; 做兼容处理）。
        /// </summary>
        /// <value>自定义参数，用于配置商家小程序的个性化内容，具体使用方法参见示例代码。 在小程序中可以通过 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/api/getExtConfig\&quot;&gt;my.getExtConfig()&lt;/a&gt; 或 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/api/getExtConfigSync\&quot;&gt;my.getExtConfigSync()&lt;/a&gt; 获取 ext 参数内容（建议支付宝版本 &gt; 10.1.38，并使用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/api/can-i-use\&quot;&gt;my.canIUse&lt;/a&gt; 做兼容处理）。</value>
        [DataMember(Name = "ext", EmitDefaultValue = false)]
        public string Ext { get; set; }

        /// <summary>
        /// 小程序模板 APPID。
        /// </summary>
        /// <value>小程序模板 APPID。</value>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 小程序模板版本号。版本号必须满足 x.y.z, 且均为数字。不传默认使用最新在架（已上架）模板版本。
        /// </summary>
        /// <value>小程序模板版本号。版本号必须满足 x.y.z, 且均为数字。不传默认使用最新在架（已上架）模板版本。</value>
        [DataMember(Name = "template_version", EmitDefaultValue = false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniVersionUploadModel {\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  TemplateVersion: ").Append(TemplateVersion).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniVersionUploadModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniVersionUploadModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniVersionUploadModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniVersionUploadModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.BundleId == input.BundleId ||
                    (this.BundleId != null &&
                    this.BundleId.Equals(input.BundleId))
                ) && 
                (
                    this.Ext == input.Ext ||
                    (this.Ext != null &&
                    this.Ext.Equals(input.Ext))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.TemplateVersion == input.TemplateVersion ||
                    (this.TemplateVersion != null &&
                    this.TemplateVersion.Equals(input.TemplateVersion))
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
                if (this.AppVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppVersion.GetHashCode();
                }
                if (this.BundleId != null)
                {
                    hashCode = (hashCode * 59) + this.BundleId.GetHashCode();
                }
                if (this.Ext != null)
                {
                    hashCode = (hashCode * 59) + this.Ext.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.TemplateVersion != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateVersion.GetHashCode();
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
