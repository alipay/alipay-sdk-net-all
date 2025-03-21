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
    /// BillSendExtInfo
    /// </summary>
    [DataContract(Name = "BillSendExtInfo")]
    public partial class BillSendExtInfo : IEquatable<BillSendExtInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillSendExtInfo" /> class.
        /// </summary>
        /// <param name="extSchoolId">学校外标编号.</param>
        /// <param name="orderPayType">账单唤起收银台的方式： 1-手机wap;2-当面付。默认值为1（不传值或传非数字值）.</param>
        /// <param name="royaltyAmount">分账金额，单位：元.</param>
        /// <param name="schoolName">学校名称.</param>
        /// <param name="transInPid">分账收入户PID.</param>
        public BillSendExtInfo(string extSchoolId = default(string), string orderPayType = default(string), string royaltyAmount = default(string), string schoolName = default(string), string transInPid = default(string))
        {
            this.ExtSchoolId = extSchoolId;
            this.OrderPayType = orderPayType;
            this.RoyaltyAmount = royaltyAmount;
            this.SchoolName = schoolName;
            this.TransInPid = transInPid;
        }

        /// <summary>
        /// 学校外标编号
        /// </summary>
        /// <value>学校外标编号</value>
        [DataMember(Name = "ext_school_id", EmitDefaultValue = false)]
        public string ExtSchoolId { get; set; }

        /// <summary>
        /// 账单唤起收银台的方式： 1-手机wap;2-当面付。默认值为1（不传值或传非数字值）
        /// </summary>
        /// <value>账单唤起收银台的方式： 1-手机wap;2-当面付。默认值为1（不传值或传非数字值）</value>
        [DataMember(Name = "order_pay_type", EmitDefaultValue = false)]
        public string OrderPayType { get; set; }

        /// <summary>
        /// 分账金额，单位：元
        /// </summary>
        /// <value>分账金额，单位：元</value>
        [DataMember(Name = "royalty_amount", EmitDefaultValue = false)]
        public string RoyaltyAmount { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        /// <value>学校名称</value>
        [DataMember(Name = "school_name", EmitDefaultValue = false)]
        public string SchoolName { get; set; }

        /// <summary>
        /// 分账收入户PID
        /// </summary>
        /// <value>分账收入户PID</value>
        [DataMember(Name = "trans_in_pid", EmitDefaultValue = false)]
        public string TransInPid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BillSendExtInfo {\n");
            sb.Append("  ExtSchoolId: ").Append(ExtSchoolId).Append("\n");
            sb.Append("  OrderPayType: ").Append(OrderPayType).Append("\n");
            sb.Append("  RoyaltyAmount: ").Append(RoyaltyAmount).Append("\n");
            sb.Append("  SchoolName: ").Append(SchoolName).Append("\n");
            sb.Append("  TransInPid: ").Append(TransInPid).Append("\n");
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
            return this.Equals(input as BillSendExtInfo);
        }

        /// <summary>
        /// Returns true if BillSendExtInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BillSendExtInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillSendExtInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExtSchoolId == input.ExtSchoolId ||
                    (this.ExtSchoolId != null &&
                    this.ExtSchoolId.Equals(input.ExtSchoolId))
                ) && 
                (
                    this.OrderPayType == input.OrderPayType ||
                    (this.OrderPayType != null &&
                    this.OrderPayType.Equals(input.OrderPayType))
                ) && 
                (
                    this.RoyaltyAmount == input.RoyaltyAmount ||
                    (this.RoyaltyAmount != null &&
                    this.RoyaltyAmount.Equals(input.RoyaltyAmount))
                ) && 
                (
                    this.SchoolName == input.SchoolName ||
                    (this.SchoolName != null &&
                    this.SchoolName.Equals(input.SchoolName))
                ) && 
                (
                    this.TransInPid == input.TransInPid ||
                    (this.TransInPid != null &&
                    this.TransInPid.Equals(input.TransInPid))
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
                if (this.ExtSchoolId != null)
                {
                    hashCode = (hashCode * 59) + this.ExtSchoolId.GetHashCode();
                }
                if (this.OrderPayType != null)
                {
                    hashCode = (hashCode * 59) + this.OrderPayType.GetHashCode();
                }
                if (this.RoyaltyAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RoyaltyAmount.GetHashCode();
                }
                if (this.SchoolName != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolName.GetHashCode();
                }
                if (this.TransInPid != null)
                {
                    hashCode = (hashCode * 59) + this.TransInPid.GetHashCode();
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
