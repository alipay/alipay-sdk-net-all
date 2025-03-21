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
    /// AlipayOpenSearchBoxactivityBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSearchBoxactivityBatchqueryResponseModel")]
    public partial class AlipayOpenSearchBoxactivityBatchqueryResponseModel : IEquatable<AlipayOpenSearchBoxactivityBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSearchBoxactivityBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="models">活动明细列表.</param>
        /// <param name="pageNumber">当前页码.</param>
        /// <param name="pageSize">每页记录数.</param>
        /// <param name="totalCount">总记录数.</param>
        /// <param name="totalPageCount">总页数.</param>
        public AlipayOpenSearchBoxactivityBatchqueryResponseModel(List<SearchBoxActivity> models = default(List<SearchBoxActivity>), string pageNumber = default(string), string pageSize = default(string), int totalCount = default(int), int totalPageCount = default(int))
        {
            this.Models = models;
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.TotalCount = totalCount;
            this.TotalPageCount = totalPageCount;
        }

        /// <summary>
        /// 活动明细列表
        /// </summary>
        /// <value>活动明细列表</value>
        [DataMember(Name = "models", EmitDefaultValue = false)]
        public List<SearchBoxActivity> Models { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        /// <value>当前页码</value>
        [DataMember(Name = "page_number", EmitDefaultValue = false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        /// <value>每页记录数</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public string PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        /// <value>总记录数</value>
        [DataMember(Name = "total_count", EmitDefaultValue = false)]
        public int TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        /// <value>总页数</value>
        [DataMember(Name = "total_page_count", EmitDefaultValue = false)]
        public int TotalPageCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSearchBoxactivityBatchqueryResponseModel {\n");
            sb.Append("  Models: ").Append(Models).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  TotalPageCount: ").Append(TotalPageCount).Append("\n");
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
            return this.Equals(input as AlipayOpenSearchBoxactivityBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSearchBoxactivityBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSearchBoxactivityBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSearchBoxactivityBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Models == input.Models ||
                    this.Models != null &&
                    input.Models != null &&
                    this.Models.SequenceEqual(input.Models)
                ) && 
                (
                    this.PageNumber == input.PageNumber ||
                    (this.PageNumber != null &&
                    this.PageNumber.Equals(input.PageNumber))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    this.TotalCount.Equals(input.TotalCount)
                ) && 
                (
                    this.TotalPageCount == input.TotalPageCount ||
                    this.TotalPageCount.Equals(input.TotalPageCount)
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
                if (this.Models != null)
                {
                    hashCode = (hashCode * 59) + this.Models.GetHashCode();
                }
                if (this.PageNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PageNumber.GetHashCode();
                }
                if (this.PageSize != null)
                {
                    hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalCount.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalPageCount.GetHashCode();
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
