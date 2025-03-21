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
    /// AlipayEcoSignFlowCreateModel
    /// </summary>
    [DataContract(Name = "AlipayEcoSignFlowCreateModel")]
    public partial class AlipayEcoSignFlowCreateModel : IEquatable<AlipayEcoSignFlowCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoSignFlowCreateModel" /> class.
        /// </summary>
        /// <param name="attachments">附件信息.</param>
        /// <param name="businessScene">流程主题.</param>
        /// <param name="configInfo">configInfo.</param>
        /// <param name="templateInfos">模板信息.</param>
        public AlipayEcoSignFlowCreateModel(List<Attachment> attachments = default(List<Attachment>), string businessScene = default(string), ConfigInfo configInfo = default(ConfigInfo), List<TemplateInfo> templateInfos = default(List<TemplateInfo>))
        {
            this.Attachments = attachments;
            this.BusinessScene = businessScene;
            this.ConfigInfo = configInfo;
            this.TemplateInfos = templateInfos;
        }

        /// <summary>
        /// 附件信息
        /// </summary>
        /// <value>附件信息</value>
        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// 流程主题
        /// </summary>
        /// <value>流程主题</value>
        [DataMember(Name = "business_scene", EmitDefaultValue = false)]
        public string BusinessScene { get; set; }

        /// <summary>
        /// Gets or Sets ConfigInfo
        /// </summary>
        [DataMember(Name = "config_info", EmitDefaultValue = false)]
        public ConfigInfo ConfigInfo { get; set; }

        /// <summary>
        /// 模板信息
        /// </summary>
        /// <value>模板信息</value>
        [DataMember(Name = "template_infos", EmitDefaultValue = false)]
        public List<TemplateInfo> TemplateInfos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEcoSignFlowCreateModel {\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  BusinessScene: ").Append(BusinessScene).Append("\n");
            sb.Append("  ConfigInfo: ").Append(ConfigInfo).Append("\n");
            sb.Append("  TemplateInfos: ").Append(TemplateInfos).Append("\n");
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
            return this.Equals(input as AlipayEcoSignFlowCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoSignFlowCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoSignFlowCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoSignFlowCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.BusinessScene == input.BusinessScene ||
                    (this.BusinessScene != null &&
                    this.BusinessScene.Equals(input.BusinessScene))
                ) && 
                (
                    this.ConfigInfo == input.ConfigInfo ||
                    (this.ConfigInfo != null &&
                    this.ConfigInfo.Equals(input.ConfigInfo))
                ) && 
                (
                    this.TemplateInfos == input.TemplateInfos ||
                    this.TemplateInfos != null &&
                    input.TemplateInfos != null &&
                    this.TemplateInfos.SequenceEqual(input.TemplateInfos)
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
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.BusinessScene != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessScene.GetHashCode();
                }
                if (this.ConfigInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigInfo.GetHashCode();
                }
                if (this.TemplateInfos != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateInfos.GetHashCode();
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
