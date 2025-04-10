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
    /// AlipayOpenMiniTemplatemessageUsertemplateApplyModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniTemplatemessageUsertemplateApplyModel")]
    public partial class AlipayOpenMiniTemplatemessageUsertemplateApplyModel : IEquatable<AlipayOpenMiniTemplatemessageUsertemplateApplyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniTemplatemessageUsertemplateApplyModel" /> class.
        /// </summary>
        /// <param name="keywordList">开发者自行组合好的模板关键词列表，关键词之间使用英文的逗号“,”进行分割，关键词顺序可以自由搭配，最多支持10个关键词组合,这里组织的关键词，在发送模板消息接口中，按照这里的顺序进行占位符替换.</param>
        /// <param name="templateLibraryId">模板库id，可登录小程序后台查看获取.</param>
        public AlipayOpenMiniTemplatemessageUsertemplateApplyModel(string keywordList = default(string), string templateLibraryId = default(string))
        {
            this.KeywordList = keywordList;
            this.TemplateLibraryId = templateLibraryId;
        }

        /// <summary>
        /// 开发者自行组合好的模板关键词列表，关键词之间使用英文的逗号“,”进行分割，关键词顺序可以自由搭配，最多支持10个关键词组合,这里组织的关键词，在发送模板消息接口中，按照这里的顺序进行占位符替换
        /// </summary>
        /// <value>开发者自行组合好的模板关键词列表，关键词之间使用英文的逗号“,”进行分割，关键词顺序可以自由搭配，最多支持10个关键词组合,这里组织的关键词，在发送模板消息接口中，按照这里的顺序进行占位符替换</value>
        [DataMember(Name = "keyword_list", EmitDefaultValue = false)]
        public string KeywordList { get; set; }

        /// <summary>
        /// 模板库id，可登录小程序后台查看获取
        /// </summary>
        /// <value>模板库id，可登录小程序后台查看获取</value>
        [DataMember(Name = "template_library_id", EmitDefaultValue = false)]
        public string TemplateLibraryId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniTemplatemessageUsertemplateApplyModel {\n");
            sb.Append("  KeywordList: ").Append(KeywordList).Append("\n");
            sb.Append("  TemplateLibraryId: ").Append(TemplateLibraryId).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniTemplatemessageUsertemplateApplyModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniTemplatemessageUsertemplateApplyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniTemplatemessageUsertemplateApplyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniTemplatemessageUsertemplateApplyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.KeywordList == input.KeywordList ||
                    (this.KeywordList != null &&
                    this.KeywordList.Equals(input.KeywordList))
                ) && 
                (
                    this.TemplateLibraryId == input.TemplateLibraryId ||
                    (this.TemplateLibraryId != null &&
                    this.TemplateLibraryId.Equals(input.TemplateLibraryId))
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
                if (this.KeywordList != null)
                {
                    hashCode = (hashCode * 59) + this.KeywordList.GetHashCode();
                }
                if (this.TemplateLibraryId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateLibraryId.GetHashCode();
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
