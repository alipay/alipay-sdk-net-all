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
    /// AlipayEcoMycarParkingOvertimecharginginfoSyncModel
    /// </summary>
    [DataContract(Name = "AlipayEcoMycarParkingOvertimecharginginfoSyncModel")]
    public partial class AlipayEcoMycarParkingOvertimecharginginfoSyncModel : IEquatable<AlipayEcoMycarParkingOvertimecharginginfoSyncModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoMycarParkingOvertimecharginginfoSyncModel" /> class.
        /// </summary>
        /// <param name="carNumber">车牌号.</param>
        /// <param name="isvUrl">智能助理当前的跳转链接.</param>
        /// <param name="parkingId">支付宝停车平台ID，由支付宝定义的该停车场标识，同一个isv或商户范围内唯一。通过 alipay.eco.mycar.parking.parkinglotinfo.create(录入停车场信息)接口获取。.</param>
        /// <param name="serialNo">支付宝业务流水号，用于记录车辆从驶入到驶出的全流程.</param>
        public AlipayEcoMycarParkingOvertimecharginginfoSyncModel(string carNumber = default(string), string isvUrl = default(string), string parkingId = default(string), string serialNo = default(string))
        {
            this.CarNumber = carNumber;
            this.IsvUrl = isvUrl;
            this.ParkingId = parkingId;
            this.SerialNo = serialNo;
        }

        /// <summary>
        /// 车牌号
        /// </summary>
        /// <value>车牌号</value>
        [DataMember(Name = "car_number", EmitDefaultValue = false)]
        public string CarNumber { get; set; }

        /// <summary>
        /// 智能助理当前的跳转链接
        /// </summary>
        /// <value>智能助理当前的跳转链接</value>
        [DataMember(Name = "isv_url", EmitDefaultValue = false)]
        public string IsvUrl { get; set; }

        /// <summary>
        /// 支付宝停车平台ID，由支付宝定义的该停车场标识，同一个isv或商户范围内唯一。通过 alipay.eco.mycar.parking.parkinglotinfo.create(录入停车场信息)接口获取。
        /// </summary>
        /// <value>支付宝停车平台ID，由支付宝定义的该停车场标识，同一个isv或商户范围内唯一。通过 alipay.eco.mycar.parking.parkinglotinfo.create(录入停车场信息)接口获取。</value>
        [DataMember(Name = "parking_id", EmitDefaultValue = false)]
        public string ParkingId { get; set; }

        /// <summary>
        /// 支付宝业务流水号，用于记录车辆从驶入到驶出的全流程
        /// </summary>
        /// <value>支付宝业务流水号，用于记录车辆从驶入到驶出的全流程</value>
        [DataMember(Name = "serial_no", EmitDefaultValue = false)]
        public string SerialNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEcoMycarParkingOvertimecharginginfoSyncModel {\n");
            sb.Append("  CarNumber: ").Append(CarNumber).Append("\n");
            sb.Append("  IsvUrl: ").Append(IsvUrl).Append("\n");
            sb.Append("  ParkingId: ").Append(ParkingId).Append("\n");
            sb.Append("  SerialNo: ").Append(SerialNo).Append("\n");
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
            return this.Equals(input as AlipayEcoMycarParkingOvertimecharginginfoSyncModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoMycarParkingOvertimecharginginfoSyncModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoMycarParkingOvertimecharginginfoSyncModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoMycarParkingOvertimecharginginfoSyncModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CarNumber == input.CarNumber ||
                    (this.CarNumber != null &&
                    this.CarNumber.Equals(input.CarNumber))
                ) && 
                (
                    this.IsvUrl == input.IsvUrl ||
                    (this.IsvUrl != null &&
                    this.IsvUrl.Equals(input.IsvUrl))
                ) && 
                (
                    this.ParkingId == input.ParkingId ||
                    (this.ParkingId != null &&
                    this.ParkingId.Equals(input.ParkingId))
                ) && 
                (
                    this.SerialNo == input.SerialNo ||
                    (this.SerialNo != null &&
                    this.SerialNo.Equals(input.SerialNo))
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
                if (this.CarNumber != null)
                {
                    hashCode = (hashCode * 59) + this.CarNumber.GetHashCode();
                }
                if (this.IsvUrl != null)
                {
                    hashCode = (hashCode * 59) + this.IsvUrl.GetHashCode();
                }
                if (this.ParkingId != null)
                {
                    hashCode = (hashCode * 59) + this.ParkingId.GetHashCode();
                }
                if (this.SerialNo != null)
                {
                    hashCode = (hashCode * 59) + this.SerialNo.GetHashCode();
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
