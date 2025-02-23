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
    /// AlipayOpenMiniCategoryQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniCategoryQueryResponseModel")]
    public partial class AlipayOpenMiniCategoryQueryResponseModel : IEquatable<AlipayOpenMiniCategoryQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniCategoryQueryResponseModel" /> class.
        /// </summary>
        /// <param name="categoryList">小程序类目列表.</param>
        /// <param name="miniCategoryList">小程序新类目列表。小程序新类目列表，为三级类目。创建、修改、提审传入mini_category_ids，资质相关请参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/operation/material \&quot;&gt;https://opendocs.alipay.com/mini/operation/material&lt;/a&gt;.</param>
        public AlipayOpenMiniCategoryQueryResponseModel(List<MiniAppCategory> categoryList = default(List<MiniAppCategory>), List<MiniAppCategory> miniCategoryList = default(List<MiniAppCategory>))
        {
            this.CategoryList = categoryList;
            this.MiniCategoryList = miniCategoryList;
        }

        /// <summary>
        /// 小程序类目列表
        /// </summary>
        /// <value>小程序类目列表</value>
        [DataMember(Name = "category_list", EmitDefaultValue = false)]
        public List<MiniAppCategory> CategoryList { get; set; }

        /// <summary>
        /// 小程序新类目列表。小程序新类目列表，为三级类目。创建、修改、提审传入mini_category_ids，资质相关请参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/operation/material \&quot;&gt;https://opendocs.alipay.com/mini/operation/material&lt;/a&gt;
        /// </summary>
        /// <value>小程序新类目列表。小程序新类目列表，为三级类目。创建、修改、提审传入mini_category_ids，资质相关请参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/operation/material \&quot;&gt;https://opendocs.alipay.com/mini/operation/material&lt;/a&gt;</value>
        [DataMember(Name = "mini_category_list", EmitDefaultValue = false)]
        public List<MiniAppCategory> MiniCategoryList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniCategoryQueryResponseModel {\n");
            sb.Append("  CategoryList: ").Append(CategoryList).Append("\n");
            sb.Append("  MiniCategoryList: ").Append(MiniCategoryList).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniCategoryQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniCategoryQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniCategoryQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniCategoryQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CategoryList == input.CategoryList ||
                    this.CategoryList != null &&
                    input.CategoryList != null &&
                    this.CategoryList.SequenceEqual(input.CategoryList)
                ) && 
                (
                    this.MiniCategoryList == input.MiniCategoryList ||
                    this.MiniCategoryList != null &&
                    input.MiniCategoryList != null &&
                    this.MiniCategoryList.SequenceEqual(input.MiniCategoryList)
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
                if (this.CategoryList != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryList.GetHashCode();
                }
                if (this.MiniCategoryList != null)
                {
                    hashCode = (hashCode * 59) + this.MiniCategoryList.GetHashCode();
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
