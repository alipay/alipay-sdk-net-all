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
    /// MiniAppServiceInfo
    /// </summary>
    [DataContract(Name = "MiniAppServiceInfo")]
    public partial class MiniAppServiceInfo : IEquatable<MiniAppServiceInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MiniAppServiceInfo" /> class.
        /// </summary>
        /// <param name="bizStatus">插件发布状态码，暂存100，风控审核200，运营审核300，等待上架400，已预发上架500，已上架501，已下架600，已驳回700.</param>
        /// <param name="isInner">是否是内部标，true/false.</param>
        /// <param name="isOrder">是否订购，true/false.</param>
        /// <param name="isvAppId">三方应用appid.</param>
        /// <param name="miniAppId">应用id.</param>
        /// <param name="miniAppName">测试插件.</param>
        /// <param name="sellerId">卖家pid.</param>
        /// <param name="sellerName">卖家名.</param>
        /// <param name="serviceCode">商品CODE.</param>
        /// <param name="serviceLogo">服务图标.</param>
        /// <param name="serviceName">服务名.</param>
        /// <param name="serviceSlogan">服务简介.</param>
        /// <param name="showType">是否在服务市场透出，SHOW展示、HIDE隐藏.</param>
        public MiniAppServiceInfo(string bizStatus = default(string), bool isInner = default(bool), bool isOrder = default(bool), string isvAppId = default(string), string miniAppId = default(string), string miniAppName = default(string), string sellerId = default(string), string sellerName = default(string), string serviceCode = default(string), string serviceLogo = default(string), string serviceName = default(string), string serviceSlogan = default(string), string showType = default(string))
        {
            this.BizStatus = bizStatus;
            this.IsInner = isInner;
            this.IsOrder = isOrder;
            this.IsvAppId = isvAppId;
            this.MiniAppId = miniAppId;
            this.MiniAppName = miniAppName;
            this.SellerId = sellerId;
            this.SellerName = sellerName;
            this.ServiceCode = serviceCode;
            this.ServiceLogo = serviceLogo;
            this.ServiceName = serviceName;
            this.ServiceSlogan = serviceSlogan;
            this.ShowType = showType;
        }

        /// <summary>
        /// 插件发布状态码，暂存100，风控审核200，运营审核300，等待上架400，已预发上架500，已上架501，已下架600，已驳回700
        /// </summary>
        /// <value>插件发布状态码，暂存100，风控审核200，运营审核300，等待上架400，已预发上架500，已上架501，已下架600，已驳回700</value>
        [DataMember(Name = "biz_status", EmitDefaultValue = false)]
        public string BizStatus { get; set; }

        /// <summary>
        /// 是否是内部标，true/false
        /// </summary>
        /// <value>是否是内部标，true/false</value>
        [DataMember(Name = "is_inner", EmitDefaultValue = true)]
        public bool IsInner { get; set; }

        /// <summary>
        /// 是否订购，true/false
        /// </summary>
        /// <value>是否订购，true/false</value>
        [DataMember(Name = "is_order", EmitDefaultValue = true)]
        public bool IsOrder { get; set; }

        /// <summary>
        /// 三方应用appid
        /// </summary>
        /// <value>三方应用appid</value>
        [DataMember(Name = "isv_app_id", EmitDefaultValue = false)]
        public string IsvAppId { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        /// <value>应用id</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 测试插件
        /// </summary>
        /// <value>测试插件</value>
        [DataMember(Name = "mini_app_name", EmitDefaultValue = false)]
        public string MiniAppName { get; set; }

        /// <summary>
        /// 卖家pid
        /// </summary>
        /// <value>卖家pid</value>
        [DataMember(Name = "seller_id", EmitDefaultValue = false)]
        public string SellerId { get; set; }

        /// <summary>
        /// 卖家名
        /// </summary>
        /// <value>卖家名</value>
        [DataMember(Name = "seller_name", EmitDefaultValue = false)]
        public string SellerName { get; set; }

        /// <summary>
        /// 商品CODE
        /// </summary>
        /// <value>商品CODE</value>
        [DataMember(Name = "service_code", EmitDefaultValue = false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务图标
        /// </summary>
        /// <value>服务图标</value>
        [DataMember(Name = "service_logo", EmitDefaultValue = false)]
        public string ServiceLogo { get; set; }

        /// <summary>
        /// 服务名
        /// </summary>
        /// <value>服务名</value>
        [DataMember(Name = "service_name", EmitDefaultValue = false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务简介
        /// </summary>
        /// <value>服务简介</value>
        [DataMember(Name = "service_slogan", EmitDefaultValue = false)]
        public string ServiceSlogan { get; set; }

        /// <summary>
        /// 是否在服务市场透出，SHOW展示、HIDE隐藏
        /// </summary>
        /// <value>是否在服务市场透出，SHOW展示、HIDE隐藏</value>
        [DataMember(Name = "show_type", EmitDefaultValue = false)]
        public string ShowType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MiniAppServiceInfo {\n");
            sb.Append("  BizStatus: ").Append(BizStatus).Append("\n");
            sb.Append("  IsInner: ").Append(IsInner).Append("\n");
            sb.Append("  IsOrder: ").Append(IsOrder).Append("\n");
            sb.Append("  IsvAppId: ").Append(IsvAppId).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  MiniAppName: ").Append(MiniAppName).Append("\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
            sb.Append("  SellerName: ").Append(SellerName).Append("\n");
            sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
            sb.Append("  ServiceLogo: ").Append(ServiceLogo).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  ServiceSlogan: ").Append(ServiceSlogan).Append("\n");
            sb.Append("  ShowType: ").Append(ShowType).Append("\n");
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
            return this.Equals(input as MiniAppServiceInfo);
        }

        /// <summary>
        /// Returns true if MiniAppServiceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MiniAppServiceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MiniAppServiceInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizStatus == input.BizStatus ||
                    (this.BizStatus != null &&
                    this.BizStatus.Equals(input.BizStatus))
                ) && 
                (
                    this.IsInner == input.IsInner ||
                    this.IsInner.Equals(input.IsInner)
                ) && 
                (
                    this.IsOrder == input.IsOrder ||
                    this.IsOrder.Equals(input.IsOrder)
                ) && 
                (
                    this.IsvAppId == input.IsvAppId ||
                    (this.IsvAppId != null &&
                    this.IsvAppId.Equals(input.IsvAppId))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.MiniAppName == input.MiniAppName ||
                    (this.MiniAppName != null &&
                    this.MiniAppName.Equals(input.MiniAppName))
                ) && 
                (
                    this.SellerId == input.SellerId ||
                    (this.SellerId != null &&
                    this.SellerId.Equals(input.SellerId))
                ) && 
                (
                    this.SellerName == input.SellerName ||
                    (this.SellerName != null &&
                    this.SellerName.Equals(input.SellerName))
                ) && 
                (
                    this.ServiceCode == input.ServiceCode ||
                    (this.ServiceCode != null &&
                    this.ServiceCode.Equals(input.ServiceCode))
                ) && 
                (
                    this.ServiceLogo == input.ServiceLogo ||
                    (this.ServiceLogo != null &&
                    this.ServiceLogo.Equals(input.ServiceLogo))
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.ServiceSlogan == input.ServiceSlogan ||
                    (this.ServiceSlogan != null &&
                    this.ServiceSlogan.Equals(input.ServiceSlogan))
                ) && 
                (
                    this.ShowType == input.ShowType ||
                    (this.ShowType != null &&
                    this.ShowType.Equals(input.ShowType))
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
                if (this.BizStatus != null)
                {
                    hashCode = (hashCode * 59) + this.BizStatus.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsInner.GetHashCode();
                hashCode = (hashCode * 59) + this.IsOrder.GetHashCode();
                if (this.IsvAppId != null)
                {
                    hashCode = (hashCode * 59) + this.IsvAppId.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.MiniAppName != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppName.GetHashCode();
                }
                if (this.SellerId != null)
                {
                    hashCode = (hashCode * 59) + this.SellerId.GetHashCode();
                }
                if (this.SellerName != null)
                {
                    hashCode = (hashCode * 59) + this.SellerName.GetHashCode();
                }
                if (this.ServiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCode.GetHashCode();
                }
                if (this.ServiceLogo != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceLogo.GetHashCode();
                }
                if (this.ServiceName != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceName.GetHashCode();
                }
                if (this.ServiceSlogan != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceSlogan.GetHashCode();
                }
                if (this.ShowType != null)
                {
                    hashCode = (hashCode * 59) + this.ShowType.GetHashCode();
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
