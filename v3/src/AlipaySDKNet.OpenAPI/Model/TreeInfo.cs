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
    /// TreeInfo
    /// </summary>
    [DataContract(Name = "TreeInfo")]
    public partial class TreeInfo : IEquatable<TreeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TreeInfo" /> class.
        /// </summary>
        /// <param name="id">类目树ID.</param>
        /// <param name="instanceCode">知识库对应的类目树名称，与treeId不可同时为空.</param>
        /// <param name="name">类目名称.</param>
        public TreeInfo(int id = default(int), string instanceCode = default(string), string name = default(string))
        {
            this.Id = id;
            this.InstanceCode = instanceCode;
            this.Name = name;
        }

        /// <summary>
        /// 类目树ID
        /// </summary>
        /// <value>类目树ID</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// 知识库对应的类目树名称，与treeId不可同时为空
        /// </summary>
        /// <value>知识库对应的类目树名称，与treeId不可同时为空</value>
        [DataMember(Name = "instance_code", EmitDefaultValue = false)]
        public string InstanceCode { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        /// <value>类目名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TreeInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InstanceCode: ").Append(InstanceCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as TreeInfo);
        }

        /// <summary>
        /// Returns true if TreeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TreeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TreeInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.InstanceCode == input.InstanceCode ||
                    (this.InstanceCode != null &&
                    this.InstanceCode.Equals(input.InstanceCode))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.InstanceCode != null)
                {
                    hashCode = (hashCode * 59) + this.InstanceCode.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
