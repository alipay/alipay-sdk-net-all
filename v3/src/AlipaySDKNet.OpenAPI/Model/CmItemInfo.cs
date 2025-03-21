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
    /// CmItemInfo
    /// </summary>
    [DataContract(Name = "CmItemInfo")]
    public partial class CmItemInfo : IEquatable<CmItemInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CmItemInfo" /> class.
        /// </summary>
        /// <param name="description">商品描述.</param>
        /// <param name="extInfo">商品扩展信息.</param>
        /// <param name="frontCategoryIdList">商品所属前台类目ID列表.</param>
        /// <param name="gmtCreate">商品创建时间.</param>
        /// <param name="gmtModified">商品更新时间.</param>
        /// <param name="itemId">商品ID.</param>
        /// <param name="materialList">商品素材列表.</param>
        /// <param name="name">商品名称.</param>
        /// <param name="propertyList">商品属性列表.</param>
        /// <param name="skuList">商品SKU列表.</param>
        /// <param name="standardCategoryId">商品所属标准类目ID（具体值请参见产品文档）.</param>
        /// <param name="status">商品状态.</param>
        /// <param name="targetId">商品归属主体ID  例：商品归属主体类型为店铺，则商品归属主体ID为店铺ID；归属主体为小程序，则归属主体ID为小程序ID.</param>
        /// <param name="targetType">商品归属主体类型:  5（店铺）  8（小程序）.</param>
        /// <param name="type">商品类型：  STANDARD_GOODS（标品）、NON_STANDARD_GOODS（非标品）.</param>
        public CmItemInfo(string description = default(string), List<ItemExtInfo> extInfo = default(List<ItemExtInfo>), List<string> frontCategoryIdList = default(List<string>), string gmtCreate = default(string), string gmtModified = default(string), string itemId = default(string), List<MaterialInfo> materialList = default(List<MaterialInfo>), string name = default(string), List<ItemPropertyInfo> propertyList = default(List<ItemPropertyInfo>), List<CmItemSkuInfo> skuList = default(List<CmItemSkuInfo>), string standardCategoryId = default(string), string status = default(string), string targetId = default(string), string targetType = default(string), string type = default(string))
        {
            this.Description = description;
            this.ExtInfo = extInfo;
            this.FrontCategoryIdList = frontCategoryIdList;
            this.GmtCreate = gmtCreate;
            this.GmtModified = gmtModified;
            this.ItemId = itemId;
            this.MaterialList = materialList;
            this.Name = name;
            this.PropertyList = propertyList;
            this.SkuList = skuList;
            this.StandardCategoryId = standardCategoryId;
            this.Status = status;
            this.TargetId = targetId;
            this.TargetType = targetType;
            this.Type = type;
        }

        /// <summary>
        /// 商品描述
        /// </summary>
        /// <value>商品描述</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 商品扩展信息
        /// </summary>
        /// <value>商品扩展信息</value>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public List<ItemExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 商品所属前台类目ID列表
        /// </summary>
        /// <value>商品所属前台类目ID列表</value>
        [DataMember(Name = "front_category_id_list", EmitDefaultValue = false)]
        public List<string> FrontCategoryIdList { get; set; }

        /// <summary>
        /// 商品创建时间
        /// </summary>
        /// <value>商品创建时间</value>
        [DataMember(Name = "gmt_create", EmitDefaultValue = false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 商品更新时间
        /// </summary>
        /// <value>商品更新时间</value>
        [DataMember(Name = "gmt_modified", EmitDefaultValue = false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        /// <value>商品ID</value>
        [DataMember(Name = "item_id", EmitDefaultValue = false)]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品素材列表
        /// </summary>
        /// <value>商品素材列表</value>
        [DataMember(Name = "material_list", EmitDefaultValue = false)]
        public List<MaterialInfo> MaterialList { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        /// <value>商品名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 商品属性列表
        /// </summary>
        /// <value>商品属性列表</value>
        [DataMember(Name = "property_list", EmitDefaultValue = false)]
        public List<ItemPropertyInfo> PropertyList { get; set; }

        /// <summary>
        /// 商品SKU列表
        /// </summary>
        /// <value>商品SKU列表</value>
        [DataMember(Name = "sku_list", EmitDefaultValue = false)]
        public List<CmItemSkuInfo> SkuList { get; set; }

        /// <summary>
        /// 商品所属标准类目ID（具体值请参见产品文档）
        /// </summary>
        /// <value>商品所属标准类目ID（具体值请参见产品文档）</value>
        [DataMember(Name = "standard_category_id", EmitDefaultValue = false)]
        public string StandardCategoryId { get; set; }

        /// <summary>
        /// 商品状态
        /// </summary>
        /// <value>商品状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 商品归属主体ID  例：商品归属主体类型为店铺，则商品归属主体ID为店铺ID；归属主体为小程序，则归属主体ID为小程序ID
        /// </summary>
        /// <value>商品归属主体ID  例：商品归属主体类型为店铺，则商品归属主体ID为店铺ID；归属主体为小程序，则归属主体ID为小程序ID</value>
        [DataMember(Name = "target_id", EmitDefaultValue = false)]
        public string TargetId { get; set; }

        /// <summary>
        /// 商品归属主体类型:  5（店铺）  8（小程序）
        /// </summary>
        /// <value>商品归属主体类型:  5（店铺）  8（小程序）</value>
        [DataMember(Name = "target_type", EmitDefaultValue = false)]
        public string TargetType { get; set; }

        /// <summary>
        /// 商品类型：  STANDARD_GOODS（标品）、NON_STANDARD_GOODS（非标品）
        /// </summary>
        /// <value>商品类型：  STANDARD_GOODS（标品）、NON_STANDARD_GOODS（非标品）</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CmItemInfo {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  FrontCategoryIdList: ").Append(FrontCategoryIdList).Append("\n");
            sb.Append("  GmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  GmtModified: ").Append(GmtModified).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  MaterialList: ").Append(MaterialList).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PropertyList: ").Append(PropertyList).Append("\n");
            sb.Append("  SkuList: ").Append(SkuList).Append("\n");
            sb.Append("  StandardCategoryId: ").Append(StandardCategoryId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as CmItemInfo);
        }

        /// <summary>
        /// Returns true if CmItemInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CmItemInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CmItemInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    this.ExtInfo != null &&
                    input.ExtInfo != null &&
                    this.ExtInfo.SequenceEqual(input.ExtInfo)
                ) && 
                (
                    this.FrontCategoryIdList == input.FrontCategoryIdList ||
                    this.FrontCategoryIdList != null &&
                    input.FrontCategoryIdList != null &&
                    this.FrontCategoryIdList.SequenceEqual(input.FrontCategoryIdList)
                ) && 
                (
                    this.GmtCreate == input.GmtCreate ||
                    (this.GmtCreate != null &&
                    this.GmtCreate.Equals(input.GmtCreate))
                ) && 
                (
                    this.GmtModified == input.GmtModified ||
                    (this.GmtModified != null &&
                    this.GmtModified.Equals(input.GmtModified))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.MaterialList == input.MaterialList ||
                    this.MaterialList != null &&
                    input.MaterialList != null &&
                    this.MaterialList.SequenceEqual(input.MaterialList)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PropertyList == input.PropertyList ||
                    this.PropertyList != null &&
                    input.PropertyList != null &&
                    this.PropertyList.SequenceEqual(input.PropertyList)
                ) && 
                (
                    this.SkuList == input.SkuList ||
                    this.SkuList != null &&
                    input.SkuList != null &&
                    this.SkuList.SequenceEqual(input.SkuList)
                ) && 
                (
                    this.StandardCategoryId == input.StandardCategoryId ||
                    (this.StandardCategoryId != null &&
                    this.StandardCategoryId.Equals(input.StandardCategoryId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
                ) && 
                (
                    this.TargetType == input.TargetType ||
                    (this.TargetType != null &&
                    this.TargetType.Equals(input.TargetType))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.FrontCategoryIdList != null)
                {
                    hashCode = (hashCode * 59) + this.FrontCategoryIdList.GetHashCode();
                }
                if (this.GmtCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtCreate.GetHashCode();
                }
                if (this.GmtModified != null)
                {
                    hashCode = (hashCode * 59) + this.GmtModified.GetHashCode();
                }
                if (this.ItemId != null)
                {
                    hashCode = (hashCode * 59) + this.ItemId.GetHashCode();
                }
                if (this.MaterialList != null)
                {
                    hashCode = (hashCode * 59) + this.MaterialList.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.PropertyList != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyList.GetHashCode();
                }
                if (this.SkuList != null)
                {
                    hashCode = (hashCode * 59) + this.SkuList.GetHashCode();
                }
                if (this.StandardCategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.StandardCategoryId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.TargetId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetId.GetHashCode();
                }
                if (this.TargetType != null)
                {
                    hashCode = (hashCode * 59) + this.TargetType.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
