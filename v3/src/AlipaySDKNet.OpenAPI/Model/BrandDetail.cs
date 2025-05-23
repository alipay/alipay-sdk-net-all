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
    /// BrandDetail
    /// </summary>
    [DataContract(Name = "BrandDetail")]
    public partial class BrandDetail : IEquatable<BrandDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandDetail" /> class.
        /// </summary>
        /// <param name="blockType">搜索工单详情数据block_type.</param>
        /// <param name="boxVersion">版本号.</param>
        /// <param name="desc">描述信息.</param>
        /// <param name="img">img地址.</param>
        /// <param name="index">索引信息.</param>
        /// <param name="key">工单详情数据key.</param>
        /// <param name="materialId">工单详情数据material_id.</param>
        /// <param name="name">应用名称.</param>
        /// <param name="publicBindAppId">搜索运营工单详情数据public_bind_app_id.</param>
        /// <param name="serviceCode">服务码.</param>
        public BrandDetail(string blockType = default(string), string boxVersion = default(string), string desc = default(string), string img = default(string), string index = default(string), string key = default(string), string materialId = default(string), string name = default(string), string publicBindAppId = default(string), string serviceCode = default(string))
        {
            this.BlockType = blockType;
            this.BoxVersion = boxVersion;
            this.Desc = desc;
            this.Img = img;
            this.Index = index;
            this.Key = key;
            this.MaterialId = materialId;
            this.Name = name;
            this.PublicBindAppId = publicBindAppId;
            this.ServiceCode = serviceCode;
        }

        /// <summary>
        /// 搜索工单详情数据block_type
        /// </summary>
        /// <value>搜索工单详情数据block_type</value>
        [DataMember(Name = "block_type", EmitDefaultValue = false)]
        public string BlockType { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        /// <value>版本号</value>
        [DataMember(Name = "box_version", EmitDefaultValue = false)]
        public string BoxVersion { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        /// <value>描述信息</value>
        [DataMember(Name = "desc", EmitDefaultValue = false)]
        public string Desc { get; set; }

        /// <summary>
        /// img地址
        /// </summary>
        /// <value>img地址</value>
        [DataMember(Name = "img", EmitDefaultValue = false)]
        public string Img { get; set; }

        /// <summary>
        /// 索引信息
        /// </summary>
        /// <value>索引信息</value>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public string Index { get; set; }

        /// <summary>
        /// 工单详情数据key
        /// </summary>
        /// <value>工单详情数据key</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// 工单详情数据material_id
        /// </summary>
        /// <value>工单详情数据material_id</value>
        [DataMember(Name = "material_id", EmitDefaultValue = false)]
        public string MaterialId { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        /// <value>应用名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 搜索运营工单详情数据public_bind_app_id
        /// </summary>
        /// <value>搜索运营工单详情数据public_bind_app_id</value>
        [DataMember(Name = "public_bind_app_id", EmitDefaultValue = false)]
        public string PublicBindAppId { get; set; }

        /// <summary>
        /// 服务码
        /// </summary>
        /// <value>服务码</value>
        [DataMember(Name = "service_code", EmitDefaultValue = false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BrandDetail {\n");
            sb.Append("  BlockType: ").Append(BlockType).Append("\n");
            sb.Append("  BoxVersion: ").Append(BoxVersion).Append("\n");
            sb.Append("  Desc: ").Append(Desc).Append("\n");
            sb.Append("  Img: ").Append(Img).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  MaterialId: ").Append(MaterialId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PublicBindAppId: ").Append(PublicBindAppId).Append("\n");
            sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
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
            return this.Equals(input as BrandDetail);
        }

        /// <summary>
        /// Returns true if BrandDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of BrandDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BlockType == input.BlockType ||
                    (this.BlockType != null &&
                    this.BlockType.Equals(input.BlockType))
                ) && 
                (
                    this.BoxVersion == input.BoxVersion ||
                    (this.BoxVersion != null &&
                    this.BoxVersion.Equals(input.BoxVersion))
                ) && 
                (
                    this.Desc == input.Desc ||
                    (this.Desc != null &&
                    this.Desc.Equals(input.Desc))
                ) && 
                (
                    this.Img == input.Img ||
                    (this.Img != null &&
                    this.Img.Equals(input.Img))
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.MaterialId == input.MaterialId ||
                    (this.MaterialId != null &&
                    this.MaterialId.Equals(input.MaterialId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PublicBindAppId == input.PublicBindAppId ||
                    (this.PublicBindAppId != null &&
                    this.PublicBindAppId.Equals(input.PublicBindAppId))
                ) && 
                (
                    this.ServiceCode == input.ServiceCode ||
                    (this.ServiceCode != null &&
                    this.ServiceCode.Equals(input.ServiceCode))
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
                if (this.BlockType != null)
                {
                    hashCode = (hashCode * 59) + this.BlockType.GetHashCode();
                }
                if (this.BoxVersion != null)
                {
                    hashCode = (hashCode * 59) + this.BoxVersion.GetHashCode();
                }
                if (this.Desc != null)
                {
                    hashCode = (hashCode * 59) + this.Desc.GetHashCode();
                }
                if (this.Img != null)
                {
                    hashCode = (hashCode * 59) + this.Img.GetHashCode();
                }
                if (this.Index != null)
                {
                    hashCode = (hashCode * 59) + this.Index.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.MaterialId != null)
                {
                    hashCode = (hashCode * 59) + this.MaterialId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.PublicBindAppId != null)
                {
                    hashCode = (hashCode * 59) + this.PublicBindAppId.GetHashCode();
                }
                if (this.ServiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCode.GetHashCode();
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
