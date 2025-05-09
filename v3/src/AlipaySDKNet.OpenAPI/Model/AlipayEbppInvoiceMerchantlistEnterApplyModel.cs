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
    /// AlipayEbppInvoiceMerchantlistEnterApplyModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceMerchantlistEnterApplyModel")]
    public partial class AlipayEbppInvoiceMerchantlistEnterApplyModel : IEquatable<AlipayEbppInvoiceMerchantlistEnterApplyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceMerchantlistEnterApplyModel" /> class.
        /// </summary>
        /// <param name="merchantBase">merchantBase.</param>
        /// <param name="subMerchantCommonInfo">subMerchantCommonInfo.</param>
        /// <param name="subMerchantList">商户门店列表信息，最多传入30个门店信息.</param>
        public AlipayEbppInvoiceMerchantlistEnterApplyModel(MerchantBaseEnterOpenModel merchantBase = default(MerchantBaseEnterOpenModel), SubMerchantCommonEnterOpenModel subMerchantCommonInfo = default(SubMerchantCommonEnterOpenModel), List<SubMerchantEnterOpenModel> subMerchantList = default(List<SubMerchantEnterOpenModel>))
        {
            this.MerchantBase = merchantBase;
            this.SubMerchantCommonInfo = subMerchantCommonInfo;
            this.SubMerchantList = subMerchantList;
        }

        /// <summary>
        /// Gets or Sets MerchantBase
        /// </summary>
        [DataMember(Name = "merchant_base", EmitDefaultValue = false)]
        public MerchantBaseEnterOpenModel MerchantBase { get; set; }

        /// <summary>
        /// Gets or Sets SubMerchantCommonInfo
        /// </summary>
        [DataMember(Name = "sub_merchant_common_info", EmitDefaultValue = false)]
        public SubMerchantCommonEnterOpenModel SubMerchantCommonInfo { get; set; }

        /// <summary>
        /// 商户门店列表信息，最多传入30个门店信息
        /// </summary>
        /// <value>商户门店列表信息，最多传入30个门店信息</value>
        [DataMember(Name = "sub_merchant_list", EmitDefaultValue = false)]
        public List<SubMerchantEnterOpenModel> SubMerchantList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceMerchantlistEnterApplyModel {\n");
            sb.Append("  MerchantBase: ").Append(MerchantBase).Append("\n");
            sb.Append("  SubMerchantCommonInfo: ").Append(SubMerchantCommonInfo).Append("\n");
            sb.Append("  SubMerchantList: ").Append(SubMerchantList).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceMerchantlistEnterApplyModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceMerchantlistEnterApplyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceMerchantlistEnterApplyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceMerchantlistEnterApplyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MerchantBase == input.MerchantBase ||
                    (this.MerchantBase != null &&
                    this.MerchantBase.Equals(input.MerchantBase))
                ) && 
                (
                    this.SubMerchantCommonInfo == input.SubMerchantCommonInfo ||
                    (this.SubMerchantCommonInfo != null &&
                    this.SubMerchantCommonInfo.Equals(input.SubMerchantCommonInfo))
                ) && 
                (
                    this.SubMerchantList == input.SubMerchantList ||
                    this.SubMerchantList != null &&
                    input.SubMerchantList != null &&
                    this.SubMerchantList.SequenceEqual(input.SubMerchantList)
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
                if (this.MerchantBase != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantBase.GetHashCode();
                }
                if (this.SubMerchantCommonInfo != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantCommonInfo.GetHashCode();
                }
                if (this.SubMerchantList != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantList.GetHashCode();
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
