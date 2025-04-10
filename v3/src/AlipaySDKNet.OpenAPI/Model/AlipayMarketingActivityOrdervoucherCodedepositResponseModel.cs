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
    /// AlipayMarketingActivityOrdervoucherCodedepositResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityOrdervoucherCodedepositResponseModel")]
    public partial class AlipayMarketingActivityOrdervoucherCodedepositResponseModel : IEquatable<AlipayMarketingActivityOrdervoucherCodedepositResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityOrdervoucherCodedepositResponseModel" /> class.
        /// </summary>
        /// <param name="failCount">导入失败的券码数量.</param>
        /// <param name="failVoucherCodeDetailList">上传失败券码详情列表，包括上传失败的券码及对应的错误码和错误原因.</param>
        /// <param name="successCount">导入成功的券码数量.</param>
        /// <param name="successVoucherCodeList">上传成功的券码列表.</param>
        public AlipayMarketingActivityOrdervoucherCodedepositResponseModel(int failCount = default(int), List<FailVoucherCodeDetail> failVoucherCodeDetailList = default(List<FailVoucherCodeDetail>), int successCount = default(int), List<string> successVoucherCodeList = default(List<string>))
        {
            this.FailCount = failCount;
            this.FailVoucherCodeDetailList = failVoucherCodeDetailList;
            this.SuccessCount = successCount;
            this.SuccessVoucherCodeList = successVoucherCodeList;
        }

        /// <summary>
        /// 导入失败的券码数量
        /// </summary>
        /// <value>导入失败的券码数量</value>
        [DataMember(Name = "fail_count", EmitDefaultValue = false)]
        public int FailCount { get; set; }

        /// <summary>
        /// 上传失败券码详情列表，包括上传失败的券码及对应的错误码和错误原因
        /// </summary>
        /// <value>上传失败券码详情列表，包括上传失败的券码及对应的错误码和错误原因</value>
        [DataMember(Name = "fail_voucher_code_detail_list", EmitDefaultValue = false)]
        public List<FailVoucherCodeDetail> FailVoucherCodeDetailList { get; set; }

        /// <summary>
        /// 导入成功的券码数量
        /// </summary>
        /// <value>导入成功的券码数量</value>
        [DataMember(Name = "success_count", EmitDefaultValue = false)]
        public int SuccessCount { get; set; }

        /// <summary>
        /// 上传成功的券码列表
        /// </summary>
        /// <value>上传成功的券码列表</value>
        [DataMember(Name = "success_voucher_code_list", EmitDefaultValue = false)]
        public List<string> SuccessVoucherCodeList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityOrdervoucherCodedepositResponseModel {\n");
            sb.Append("  FailCount: ").Append(FailCount).Append("\n");
            sb.Append("  FailVoucherCodeDetailList: ").Append(FailVoucherCodeDetailList).Append("\n");
            sb.Append("  SuccessCount: ").Append(SuccessCount).Append("\n");
            sb.Append("  SuccessVoucherCodeList: ").Append(SuccessVoucherCodeList).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityOrdervoucherCodedepositResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityOrdervoucherCodedepositResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityOrdervoucherCodedepositResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityOrdervoucherCodedepositResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FailCount == input.FailCount ||
                    this.FailCount.Equals(input.FailCount)
                ) && 
                (
                    this.FailVoucherCodeDetailList == input.FailVoucherCodeDetailList ||
                    this.FailVoucherCodeDetailList != null &&
                    input.FailVoucherCodeDetailList != null &&
                    this.FailVoucherCodeDetailList.SequenceEqual(input.FailVoucherCodeDetailList)
                ) && 
                (
                    this.SuccessCount == input.SuccessCount ||
                    this.SuccessCount.Equals(input.SuccessCount)
                ) && 
                (
                    this.SuccessVoucherCodeList == input.SuccessVoucherCodeList ||
                    this.SuccessVoucherCodeList != null &&
                    input.SuccessVoucherCodeList != null &&
                    this.SuccessVoucherCodeList.SequenceEqual(input.SuccessVoucherCodeList)
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
                hashCode = (hashCode * 59) + this.FailCount.GetHashCode();
                if (this.FailVoucherCodeDetailList != null)
                {
                    hashCode = (hashCode * 59) + this.FailVoucherCodeDetailList.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SuccessCount.GetHashCode();
                if (this.SuccessVoucherCodeList != null)
                {
                    hashCode = (hashCode * 59) + this.SuccessVoucherCodeList.GetHashCode();
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
