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
    /// ServiceRecordCatRequest
    /// </summary>
    [DataContract(Name = "ServiceRecordCatRequest")]
    public partial class ServiceRecordCatRequest : IEquatable<ServiceRecordCatRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceRecordCatRequest" /> class.
        /// </summary>
        /// <param name="catName">类目名称(需要每一级用;分隔封装).</param>
        /// <param name="firstCat">一级类目编码.</param>
        /// <param name="fourthCat">四级类目编码.</param>
        /// <param name="instenceCode">类目树编码.</param>
        /// <param name="secondCat">二级类目编码.</param>
        /// <param name="thirdCat">三级类目编码.</param>
        public ServiceRecordCatRequest(string catName = default(string), string firstCat = default(string), string fourthCat = default(string), string instenceCode = default(string), string secondCat = default(string), string thirdCat = default(string))
        {
            this.CatName = catName;
            this.FirstCat = firstCat;
            this.FourthCat = fourthCat;
            this.InstenceCode = instenceCode;
            this.SecondCat = secondCat;
            this.ThirdCat = thirdCat;
        }

        /// <summary>
        /// 类目名称(需要每一级用;分隔封装)
        /// </summary>
        /// <value>类目名称(需要每一级用;分隔封装)</value>
        [DataMember(Name = "cat_name", EmitDefaultValue = false)]
        public string CatName { get; set; }

        /// <summary>
        /// 一级类目编码
        /// </summary>
        /// <value>一级类目编码</value>
        [DataMember(Name = "first_cat", EmitDefaultValue = false)]
        public string FirstCat { get; set; }

        /// <summary>
        /// 四级类目编码
        /// </summary>
        /// <value>四级类目编码</value>
        [DataMember(Name = "fourth_cat", EmitDefaultValue = false)]
        public string FourthCat { get; set; }

        /// <summary>
        /// 类目树编码
        /// </summary>
        /// <value>类目树编码</value>
        [DataMember(Name = "instence_code", EmitDefaultValue = false)]
        public string InstenceCode { get; set; }

        /// <summary>
        /// 二级类目编码
        /// </summary>
        /// <value>二级类目编码</value>
        [DataMember(Name = "second_cat", EmitDefaultValue = false)]
        public string SecondCat { get; set; }

        /// <summary>
        /// 三级类目编码
        /// </summary>
        /// <value>三级类目编码</value>
        [DataMember(Name = "third_cat", EmitDefaultValue = false)]
        public string ThirdCat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServiceRecordCatRequest {\n");
            sb.Append("  CatName: ").Append(CatName).Append("\n");
            sb.Append("  FirstCat: ").Append(FirstCat).Append("\n");
            sb.Append("  FourthCat: ").Append(FourthCat).Append("\n");
            sb.Append("  InstenceCode: ").Append(InstenceCode).Append("\n");
            sb.Append("  SecondCat: ").Append(SecondCat).Append("\n");
            sb.Append("  ThirdCat: ").Append(ThirdCat).Append("\n");
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
            return this.Equals(input as ServiceRecordCatRequest);
        }

        /// <summary>
        /// Returns true if ServiceRecordCatRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceRecordCatRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceRecordCatRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CatName == input.CatName ||
                    (this.CatName != null &&
                    this.CatName.Equals(input.CatName))
                ) && 
                (
                    this.FirstCat == input.FirstCat ||
                    (this.FirstCat != null &&
                    this.FirstCat.Equals(input.FirstCat))
                ) && 
                (
                    this.FourthCat == input.FourthCat ||
                    (this.FourthCat != null &&
                    this.FourthCat.Equals(input.FourthCat))
                ) && 
                (
                    this.InstenceCode == input.InstenceCode ||
                    (this.InstenceCode != null &&
                    this.InstenceCode.Equals(input.InstenceCode))
                ) && 
                (
                    this.SecondCat == input.SecondCat ||
                    (this.SecondCat != null &&
                    this.SecondCat.Equals(input.SecondCat))
                ) && 
                (
                    this.ThirdCat == input.ThirdCat ||
                    (this.ThirdCat != null &&
                    this.ThirdCat.Equals(input.ThirdCat))
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
                if (this.CatName != null)
                {
                    hashCode = (hashCode * 59) + this.CatName.GetHashCode();
                }
                if (this.FirstCat != null)
                {
                    hashCode = (hashCode * 59) + this.FirstCat.GetHashCode();
                }
                if (this.FourthCat != null)
                {
                    hashCode = (hashCode * 59) + this.FourthCat.GetHashCode();
                }
                if (this.InstenceCode != null)
                {
                    hashCode = (hashCode * 59) + this.InstenceCode.GetHashCode();
                }
                if (this.SecondCat != null)
                {
                    hashCode = (hashCode * 59) + this.SecondCat.GetHashCode();
                }
                if (this.ThirdCat != null)
                {
                    hashCode = (hashCode * 59) + this.ThirdCat.GetHashCode();
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
