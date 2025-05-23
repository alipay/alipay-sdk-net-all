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
    /// AlipayOpenPublicUserFollowQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicUserFollowQueryResponseModel")]
    public partial class AlipayOpenPublicUserFollowQueryResponseModel : IEquatable<AlipayOpenPublicUserFollowQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicUserFollowQueryResponseModel" /> class.
        /// </summary>
        /// <param name="isFollow">用户是否关注。枚举值如下： *T：代表已关注。 *F：代表未关注。.</param>
        public AlipayOpenPublicUserFollowQueryResponseModel(string isFollow = default(string))
        {
            this.IsFollow = isFollow;
        }

        /// <summary>
        /// 用户是否关注。枚举值如下： *T：代表已关注。 *F：代表未关注。
        /// </summary>
        /// <value>用户是否关注。枚举值如下： *T：代表已关注。 *F：代表未关注。</value>
        [DataMember(Name = "is_follow", EmitDefaultValue = false)]
        public string IsFollow { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicUserFollowQueryResponseModel {\n");
            sb.Append("  IsFollow: ").Append(IsFollow).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicUserFollowQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicUserFollowQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicUserFollowQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicUserFollowQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsFollow == input.IsFollow ||
                    (this.IsFollow != null &&
                    this.IsFollow.Equals(input.IsFollow))
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
                if (this.IsFollow != null)
                {
                    hashCode = (hashCode * 59) + this.IsFollow.GetHashCode();
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
