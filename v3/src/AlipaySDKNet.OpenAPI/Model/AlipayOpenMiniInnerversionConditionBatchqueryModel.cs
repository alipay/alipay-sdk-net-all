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
    /// AlipayOpenMiniInnerversionConditionBatchqueryModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerversionConditionBatchqueryModel")]
    public partial class AlipayOpenMiniInnerversionConditionBatchqueryModel : IEquatable<AlipayOpenMiniInnerversionConditionBatchqueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionConditionBatchqueryModel" /> class.
        /// </summary>
        /// <param name="appOrigin">业务来源.</param>
        /// <param name="bundleId">com.alipay.alipaywallet:支付宝，com.amap.app:高德.</param>
        /// <param name="miniAppId">小程序ID，仅特殊场景使用，普通业务方无需关注该参数。.</param>
        /// <param name="pageNum">页码.</param>
        /// <param name="pageSize">分页数.</param>
        /// <param name="versionStatus">INIT:开发中，RELEASE:上架，OFFLINE:下架，AUDITING:审核中，AUDIT_REJECT:审核驳回，WAIT_RELEASE:待上架，GRAY:灰度中，以,号隔开.</param>
        public AlipayOpenMiniInnerversionConditionBatchqueryModel(string appOrigin = default(string), string bundleId = default(string), string miniAppId = default(string), string pageNum = default(string), string pageSize = default(string), string versionStatus = default(string))
        {
            this.AppOrigin = appOrigin;
            this.BundleId = bundleId;
            this.MiniAppId = miniAppId;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.VersionStatus = versionStatus;
        }

        /// <summary>
        /// 业务来源
        /// </summary>
        /// <value>业务来源</value>
        [DataMember(Name = "app_origin", EmitDefaultValue = false)]
        public string AppOrigin { get; set; }

        /// <summary>
        /// com.alipay.alipaywallet:支付宝，com.amap.app:高德
        /// </summary>
        /// <value>com.alipay.alipaywallet:支付宝，com.amap.app:高德</value>
        [DataMember(Name = "bundle_id", EmitDefaultValue = false)]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序ID，仅特殊场景使用，普通业务方无需关注该参数。
        /// </summary>
        /// <value>小程序ID，仅特殊场景使用，普通业务方无需关注该参数。</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        /// <value>页码</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页数
        /// </summary>
        /// <value>分页数</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public string PageSize { get; set; }

        /// <summary>
        /// INIT:开发中，RELEASE:上架，OFFLINE:下架，AUDITING:审核中，AUDIT_REJECT:审核驳回，WAIT_RELEASE:待上架，GRAY:灰度中，以,号隔开
        /// </summary>
        /// <value>INIT:开发中，RELEASE:上架，OFFLINE:下架，AUDITING:审核中，AUDIT_REJECT:审核驳回，WAIT_RELEASE:待上架，GRAY:灰度中，以,号隔开</value>
        [DataMember(Name = "version_status", EmitDefaultValue = false)]
        public string VersionStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniInnerversionConditionBatchqueryModel {\n");
            sb.Append("  AppOrigin: ").Append(AppOrigin).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  VersionStatus: ").Append(VersionStatus).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniInnerversionConditionBatchqueryModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerversionConditionBatchqueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerversionConditionBatchqueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerversionConditionBatchqueryModel input)
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
                    this.BundleId == input.BundleId ||
                    (this.BundleId != null &&
                    this.BundleId.Equals(input.BundleId))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    (this.PageNum != null &&
                    this.PageNum.Equals(input.PageNum))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.VersionStatus == input.VersionStatus ||
                    (this.VersionStatus != null &&
                    this.VersionStatus.Equals(input.VersionStatus))
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
                if (this.BundleId != null)
                {
                    hashCode = (hashCode * 59) + this.BundleId.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.PageNum != null)
                {
                    hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                }
                if (this.PageSize != null)
                {
                    hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                }
                if (this.VersionStatus != null)
                {
                    hashCode = (hashCode * 59) + this.VersionStatus.GetHashCode();
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
