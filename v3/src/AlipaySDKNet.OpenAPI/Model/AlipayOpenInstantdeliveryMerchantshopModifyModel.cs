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
    /// AlipayOpenInstantdeliveryMerchantshopModifyModel
    /// </summary>
    [DataContract(Name = "AlipayOpenInstantdeliveryMerchantshopModifyModel")]
    public partial class AlipayOpenInstantdeliveryMerchantshopModifyModel : IEquatable<AlipayOpenInstantdeliveryMerchantshopModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenInstantdeliveryMerchantshopModifyModel" /> class.
        /// </summary>
        /// <param name="contactName">联系人姓名.</param>
        /// <param name="logisticsCodes">要更新的配送公司列表，必须包含已经创建过该门店的配送公司，可以新增开通了账户的配送公司.</param>
        /// <param name="outBizNo">外部业务号.</param>
        /// <param name="phone">联系人电话/手机号.</param>
        /// <param name="shopNo">商家门店编码.</param>
        public AlipayOpenInstantdeliveryMerchantshopModifyModel(string contactName = default(string), List<string> logisticsCodes = default(List<string>), string outBizNo = default(string), string phone = default(string), string shopNo = default(string))
        {
            this.ContactName = contactName;
            this.LogisticsCodes = logisticsCodes;
            this.OutBizNo = outBizNo;
            this.Phone = phone;
            this.ShopNo = shopNo;
        }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        /// <value>联系人姓名</value>
        [DataMember(Name = "contact_name", EmitDefaultValue = false)]
        public string ContactName { get; set; }

        /// <summary>
        /// 要更新的配送公司列表，必须包含已经创建过该门店的配送公司，可以新增开通了账户的配送公司
        /// </summary>
        /// <value>要更新的配送公司列表，必须包含已经创建过该门店的配送公司，可以新增开通了账户的配送公司</value>
        [DataMember(Name = "logistics_codes", EmitDefaultValue = false)]
        public List<string> LogisticsCodes { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        /// <value>外部业务号</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 联系人电话/手机号
        /// </summary>
        /// <value>联系人电话/手机号</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// 商家门店编码
        /// </summary>
        /// <value>商家门店编码</value>
        [DataMember(Name = "shop_no", EmitDefaultValue = false)]
        public string ShopNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenInstantdeliveryMerchantshopModifyModel {\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  LogisticsCodes: ").Append(LogisticsCodes).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  ShopNo: ").Append(ShopNo).Append("\n");
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
            return this.Equals(input as AlipayOpenInstantdeliveryMerchantshopModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenInstantdeliveryMerchantshopModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenInstantdeliveryMerchantshopModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenInstantdeliveryMerchantshopModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.LogisticsCodes == input.LogisticsCodes ||
                    this.LogisticsCodes != null &&
                    input.LogisticsCodes != null &&
                    this.LogisticsCodes.SequenceEqual(input.LogisticsCodes)
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.ShopNo == input.ShopNo ||
                    (this.ShopNo != null &&
                    this.ShopNo.Equals(input.ShopNo))
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
                if (this.ContactName != null)
                {
                    hashCode = (hashCode * 59) + this.ContactName.GetHashCode();
                }
                if (this.LogisticsCodes != null)
                {
                    hashCode = (hashCode * 59) + this.LogisticsCodes.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.ShopNo != null)
                {
                    hashCode = (hashCode * 59) + this.ShopNo.GetHashCode();
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
