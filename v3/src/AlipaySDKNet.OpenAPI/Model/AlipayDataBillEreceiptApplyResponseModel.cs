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
    /// AlipayDataBillEreceiptApplyResponseModel
    /// </summary>
    [DataContract(Name = "AlipayDataBillEreceiptApplyResponseModel")]
    public partial class AlipayDataBillEreceiptApplyResponseModel : IEquatable<AlipayDataBillEreceiptApplyResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataBillEreceiptApplyResponseModel" /> class.
        /// </summary>
        /// <param name="fileId">文件申请号file_id信息。 使用file_id可以查询处理状态，有效期：2天.</param>
        public AlipayDataBillEreceiptApplyResponseModel(string fileId = default(string))
        {
            this.FileId = fileId;
        }

        /// <summary>
        /// 文件申请号file_id信息。 使用file_id可以查询处理状态，有效期：2天
        /// </summary>
        /// <value>文件申请号file_id信息。 使用file_id可以查询处理状态，有效期：2天</value>
        [DataMember(Name = "file_id", EmitDefaultValue = false)]
        public string FileId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayDataBillEreceiptApplyResponseModel {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
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
            return this.Equals(input as AlipayDataBillEreceiptApplyResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayDataBillEreceiptApplyResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayDataBillEreceiptApplyResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayDataBillEreceiptApplyResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
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
                if (this.FileId != null)
                {
                    hashCode = (hashCode * 59) + this.FileId.GetHashCode();
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
