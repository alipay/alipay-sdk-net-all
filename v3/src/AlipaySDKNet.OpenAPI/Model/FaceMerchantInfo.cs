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
    /// FaceMerchantInfo
    /// </summary>
    [DataContract(Name = "FaceMerchantInfo")]
    public partial class FaceMerchantInfo : IEquatable<FaceMerchantInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaceMerchantInfo" /> class.
        /// </summary>
        /// <param name="areaCode">区域编码.</param>
        /// <param name="brandCode">品牌编码.</param>
        /// <param name="deviceMac">机具Mac地址.</param>
        /// <param name="deviceNum">机具编码.</param>
        /// <param name="geo">经纬度.</param>
        /// <param name="group">机具分组编码.</param>
        /// <param name="merchantId">商户ID.</param>
        /// <param name="partnerId">ISV ID.</param>
        /// <param name="storeCode">门店编码.</param>
        /// <param name="wifimac">WI-FI Mac地址.</param>
        /// <param name="wifiname">WI-FI 名称.</param>
        public FaceMerchantInfo(string areaCode = default(string), string brandCode = default(string), string deviceMac = default(string), string deviceNum = default(string), string geo = default(string), string group = default(string), string merchantId = default(string), string partnerId = default(string), string storeCode = default(string), string wifimac = default(string), string wifiname = default(string))
        {
            this.AreaCode = areaCode;
            this.BrandCode = brandCode;
            this.DeviceMac = deviceMac;
            this.DeviceNum = deviceNum;
            this.Geo = geo;
            this.Group = group;
            this.MerchantId = merchantId;
            this.PartnerId = partnerId;
            this.StoreCode = storeCode;
            this.Wifimac = wifimac;
            this.Wifiname = wifiname;
        }

        /// <summary>
        /// 区域编码
        /// </summary>
        /// <value>区域编码</value>
        [DataMember(Name = "area_code", EmitDefaultValue = false)]
        public string AreaCode { get; set; }

        /// <summary>
        /// 品牌编码
        /// </summary>
        /// <value>品牌编码</value>
        [DataMember(Name = "brand_code", EmitDefaultValue = false)]
        public string BrandCode { get; set; }

        /// <summary>
        /// 机具Mac地址
        /// </summary>
        /// <value>机具Mac地址</value>
        [DataMember(Name = "device_mac", EmitDefaultValue = false)]
        public string DeviceMac { get; set; }

        /// <summary>
        /// 机具编码
        /// </summary>
        /// <value>机具编码</value>
        [DataMember(Name = "device_num", EmitDefaultValue = false)]
        public string DeviceNum { get; set; }

        /// <summary>
        /// 经纬度
        /// </summary>
        /// <value>经纬度</value>
        [DataMember(Name = "geo", EmitDefaultValue = false)]
        public string Geo { get; set; }

        /// <summary>
        /// 机具分组编码
        /// </summary>
        /// <value>机具分组编码</value>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public string Group { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        /// <value>商户ID</value>
        [DataMember(Name = "merchant_id", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// ISV ID
        /// </summary>
        /// <value>ISV ID</value>
        [DataMember(Name = "partner_id", EmitDefaultValue = false)]
        public string PartnerId { get; set; }

        /// <summary>
        /// 门店编码
        /// </summary>
        /// <value>门店编码</value>
        [DataMember(Name = "store_code", EmitDefaultValue = false)]
        public string StoreCode { get; set; }

        /// <summary>
        /// WI-FI Mac地址
        /// </summary>
        /// <value>WI-FI Mac地址</value>
        [DataMember(Name = "wifimac", EmitDefaultValue = false)]
        public string Wifimac { get; set; }

        /// <summary>
        /// WI-FI 名称
        /// </summary>
        /// <value>WI-FI 名称</value>
        [DataMember(Name = "wifiname", EmitDefaultValue = false)]
        public string Wifiname { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FaceMerchantInfo {\n");
            sb.Append("  AreaCode: ").Append(AreaCode).Append("\n");
            sb.Append("  BrandCode: ").Append(BrandCode).Append("\n");
            sb.Append("  DeviceMac: ").Append(DeviceMac).Append("\n");
            sb.Append("  DeviceNum: ").Append(DeviceNum).Append("\n");
            sb.Append("  Geo: ").Append(Geo).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  StoreCode: ").Append(StoreCode).Append("\n");
            sb.Append("  Wifimac: ").Append(Wifimac).Append("\n");
            sb.Append("  Wifiname: ").Append(Wifiname).Append("\n");
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
            return this.Equals(input as FaceMerchantInfo);
        }

        /// <summary>
        /// Returns true if FaceMerchantInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of FaceMerchantInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaceMerchantInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AreaCode == input.AreaCode ||
                    (this.AreaCode != null &&
                    this.AreaCode.Equals(input.AreaCode))
                ) && 
                (
                    this.BrandCode == input.BrandCode ||
                    (this.BrandCode != null &&
                    this.BrandCode.Equals(input.BrandCode))
                ) && 
                (
                    this.DeviceMac == input.DeviceMac ||
                    (this.DeviceMac != null &&
                    this.DeviceMac.Equals(input.DeviceMac))
                ) && 
                (
                    this.DeviceNum == input.DeviceNum ||
                    (this.DeviceNum != null &&
                    this.DeviceNum.Equals(input.DeviceNum))
                ) && 
                (
                    this.Geo == input.Geo ||
                    (this.Geo != null &&
                    this.Geo.Equals(input.Geo))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.PartnerId == input.PartnerId ||
                    (this.PartnerId != null &&
                    this.PartnerId.Equals(input.PartnerId))
                ) && 
                (
                    this.StoreCode == input.StoreCode ||
                    (this.StoreCode != null &&
                    this.StoreCode.Equals(input.StoreCode))
                ) && 
                (
                    this.Wifimac == input.Wifimac ||
                    (this.Wifimac != null &&
                    this.Wifimac.Equals(input.Wifimac))
                ) && 
                (
                    this.Wifiname == input.Wifiname ||
                    (this.Wifiname != null &&
                    this.Wifiname.Equals(input.Wifiname))
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
                if (this.AreaCode != null)
                {
                    hashCode = (hashCode * 59) + this.AreaCode.GetHashCode();
                }
                if (this.BrandCode != null)
                {
                    hashCode = (hashCode * 59) + this.BrandCode.GetHashCode();
                }
                if (this.DeviceMac != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceMac.GetHashCode();
                }
                if (this.DeviceNum != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceNum.GetHashCode();
                }
                if (this.Geo != null)
                {
                    hashCode = (hashCode * 59) + this.Geo.GetHashCode();
                }
                if (this.Group != null)
                {
                    hashCode = (hashCode * 59) + this.Group.GetHashCode();
                }
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
                }
                if (this.PartnerId != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerId.GetHashCode();
                }
                if (this.StoreCode != null)
                {
                    hashCode = (hashCode * 59) + this.StoreCode.GetHashCode();
                }
                if (this.Wifimac != null)
                {
                    hashCode = (hashCode * 59) + this.Wifimac.GetHashCode();
                }
                if (this.Wifiname != null)
                {
                    hashCode = (hashCode * 59) + this.Wifiname.GetHashCode();
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
