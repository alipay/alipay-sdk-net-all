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
    /// BkAgentReqInfo
    /// </summary>
    [DataContract(Name = "BkAgentReqInfo")]
    public partial class BkAgentReqInfo : IEquatable<BkAgentReqInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BkAgentReqInfo" /> class.
        /// </summary>
        /// <param name="acqCode">收单机构在清算组织登记或分配的机构代码.</param>
        /// <param name="deviceType">终端设备类型，受理方可参考终端注册时的设备类型填写。.</param>
        /// <param name="location">终端设备实时经纬度信息，格式为纬度/经度，+表示北纬、东经，-表示南纬、西经。.</param>
        /// <param name="merchCode">收单机构在清算组织登记的商户编码.</param>
        /// <param name="serialNum">终端类型填写为 02、 03、04、05、06、08、09 或 10 时，必 须填写终端序列号。.</param>
        public BkAgentReqInfo(string acqCode = default(string), string deviceType = default(string), string location = default(string), string merchCode = default(string), string serialNum = default(string))
        {
            this.AcqCode = acqCode;
            this.DeviceType = deviceType;
            this.Location = location;
            this.MerchCode = merchCode;
            this.SerialNum = serialNum;
        }

        /// <summary>
        /// 收单机构在清算组织登记或分配的机构代码
        /// </summary>
        /// <value>收单机构在清算组织登记或分配的机构代码</value>
        [DataMember(Name = "acq_code", EmitDefaultValue = false)]
        public string AcqCode { get; set; }

        /// <summary>
        /// 终端设备类型，受理方可参考终端注册时的设备类型填写。
        /// </summary>
        /// <value>终端设备类型，受理方可参考终端注册时的设备类型填写。</value>
        [DataMember(Name = "device_type", EmitDefaultValue = false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// 终端设备实时经纬度信息，格式为纬度/经度，+表示北纬、东经，-表示南纬、西经。
        /// </summary>
        /// <value>终端设备实时经纬度信息，格式为纬度/经度，+表示北纬、东经，-表示南纬、西经。</value>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public string Location { get; set; }

        /// <summary>
        /// 收单机构在清算组织登记的商户编码
        /// </summary>
        /// <value>收单机构在清算组织登记的商户编码</value>
        [DataMember(Name = "merch_code", EmitDefaultValue = false)]
        public string MerchCode { get; set; }

        /// <summary>
        /// 终端类型填写为 02、 03、04、05、06、08、09 或 10 时，必 须填写终端序列号。
        /// </summary>
        /// <value>终端类型填写为 02、 03、04、05、06、08、09 或 10 时，必 须填写终端序列号。</value>
        [DataMember(Name = "serial_num", EmitDefaultValue = false)]
        public string SerialNum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BkAgentReqInfo {\n");
            sb.Append("  AcqCode: ").Append(AcqCode).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  MerchCode: ").Append(MerchCode).Append("\n");
            sb.Append("  SerialNum: ").Append(SerialNum).Append("\n");
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
            return this.Equals(input as BkAgentReqInfo);
        }

        /// <summary>
        /// Returns true if BkAgentReqInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BkAgentReqInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BkAgentReqInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcqCode == input.AcqCode ||
                    (this.AcqCode != null &&
                    this.AcqCode.Equals(input.AcqCode))
                ) && 
                (
                    this.DeviceType == input.DeviceType ||
                    (this.DeviceType != null &&
                    this.DeviceType.Equals(input.DeviceType))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.MerchCode == input.MerchCode ||
                    (this.MerchCode != null &&
                    this.MerchCode.Equals(input.MerchCode))
                ) && 
                (
                    this.SerialNum == input.SerialNum ||
                    (this.SerialNum != null &&
                    this.SerialNum.Equals(input.SerialNum))
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
                if (this.AcqCode != null)
                {
                    hashCode = (hashCode * 59) + this.AcqCode.GetHashCode();
                }
                if (this.DeviceType != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceType.GetHashCode();
                }
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                if (this.MerchCode != null)
                {
                    hashCode = (hashCode * 59) + this.MerchCode.GetHashCode();
                }
                if (this.SerialNum != null)
                {
                    hashCode = (hashCode * 59) + this.SerialNum.GetHashCode();
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
