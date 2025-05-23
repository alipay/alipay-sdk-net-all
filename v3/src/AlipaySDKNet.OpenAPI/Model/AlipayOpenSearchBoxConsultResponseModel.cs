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
    /// AlipayOpenSearchBoxConsultResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSearchBoxConsultResponseModel")]
    public partial class AlipayOpenSearchBoxConsultResponseModel : IEquatable<AlipayOpenSearchBoxConsultResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSearchBoxConsultResponseModel" /> class.
        /// </summary>
        /// <param name="access">是否准入，false代表不准入.</param>
        /// <param name="notPassItems">不准入项列表。不准入项用字符串描述，可参照接口文档和&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-open/0311q3#%E5%87%86%E5%85%A5%E6%9D%A1%E4%BB%B6\&quot;&gt;准入条件&lt;/a&gt;，进行调整以达到申请要求.</param>
        public AlipayOpenSearchBoxConsultResponseModel(bool access = default(bool), List<string> notPassItems = default(List<string>))
        {
            this.Access = access;
            this.NotPassItems = notPassItems;
        }

        /// <summary>
        /// 是否准入，false代表不准入
        /// </summary>
        /// <value>是否准入，false代表不准入</value>
        [DataMember(Name = "access", EmitDefaultValue = true)]
        public bool Access { get; set; }

        /// <summary>
        /// 不准入项列表。不准入项用字符串描述，可参照接口文档和&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-open/0311q3#%E5%87%86%E5%85%A5%E6%9D%A1%E4%BB%B6\&quot;&gt;准入条件&lt;/a&gt;，进行调整以达到申请要求
        /// </summary>
        /// <value>不准入项列表。不准入项用字符串描述，可参照接口文档和&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-open/0311q3#%E5%87%86%E5%85%A5%E6%9D%A1%E4%BB%B6\&quot;&gt;准入条件&lt;/a&gt;，进行调整以达到申请要求</value>
        [DataMember(Name = "not_pass_items", EmitDefaultValue = false)]
        public List<string> NotPassItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSearchBoxConsultResponseModel {\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  NotPassItems: ").Append(NotPassItems).Append("\n");
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
            return this.Equals(input as AlipayOpenSearchBoxConsultResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSearchBoxConsultResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSearchBoxConsultResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSearchBoxConsultResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Access == input.Access ||
                    this.Access.Equals(input.Access)
                ) && 
                (
                    this.NotPassItems == input.NotPassItems ||
                    this.NotPassItems != null &&
                    input.NotPassItems != null &&
                    this.NotPassItems.SequenceEqual(input.NotPassItems)
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
                hashCode = (hashCode * 59) + this.Access.GetHashCode();
                if (this.NotPassItems != null)
                {
                    hashCode = (hashCode * 59) + this.NotPassItems.GetHashCode();
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
