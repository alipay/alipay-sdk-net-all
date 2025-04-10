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
    /// AuditLicenseInfo
    /// </summary>
    [DataContract(Name = "AuditLicenseInfo")]
    public partial class AuditLicenseInfo : IEquatable<AuditLicenseInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLicenseInfo" /> class.
        /// </summary>
        /// <param name="licenseName">营业执照名称，需要与营业执照保持一致.</param>
        /// <param name="licenseNo">营业执照号，部分小程序类目需要提交，参照 &lt;a href&#x3D;‘https://opendocs.alipay.com/b/03al2m’&gt;开放服务类目&lt;/a&gt; 中是否需要营业执照信息，如果不填默认采用当前小程序应用营业执照号。.</param>
        /// <param name="licensePicList">营业执照照片地址列表.</param>
        /// <param name="licenseValidDate">营业执有效期，格式为yyyy-MM-dd，9999-12-31表示长期.</param>
        /// <param name="outDoorPic">门头照图片地址，部分小程序类目需要提交，参照 &lt;a href&#x3D;‘https://opendocs.alipay.com/b/03al2m’&gt;开放服务类目&lt;/a&gt; 中是否需要营业执照信息，如果不填默认采用当前小程序门头照图片.</param>
        public AuditLicenseInfo(string licenseName = default(string), string licenseNo = default(string), List<string> licensePicList = default(List<string>), string licenseValidDate = default(string), string outDoorPic = default(string))
        {
            this.LicenseName = licenseName;
            this.LicenseNo = licenseNo;
            this.LicensePicList = licensePicList;
            this.LicenseValidDate = licenseValidDate;
            this.OutDoorPic = outDoorPic;
        }

        /// <summary>
        /// 营业执照名称，需要与营业执照保持一致
        /// </summary>
        /// <value>营业执照名称，需要与营业执照保持一致</value>
        [DataMember(Name = "license_name", EmitDefaultValue = false)]
        public string LicenseName { get; set; }

        /// <summary>
        /// 营业执照号，部分小程序类目需要提交，参照 &lt;a href&#x3D;‘https://opendocs.alipay.com/b/03al2m’&gt;开放服务类目&lt;/a&gt; 中是否需要营业执照信息，如果不填默认采用当前小程序应用营业执照号。
        /// </summary>
        /// <value>营业执照号，部分小程序类目需要提交，参照 &lt;a href&#x3D;‘https://opendocs.alipay.com/b/03al2m’&gt;开放服务类目&lt;/a&gt; 中是否需要营业执照信息，如果不填默认采用当前小程序应用营业执照号。</value>
        [DataMember(Name = "license_no", EmitDefaultValue = false)]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 营业执照照片地址列表
        /// </summary>
        /// <value>营业执照照片地址列表</value>
        [DataMember(Name = "license_pic_list", EmitDefaultValue = false)]
        public List<string> LicensePicList { get; set; }

        /// <summary>
        /// 营业执有效期，格式为yyyy-MM-dd，9999-12-31表示长期
        /// </summary>
        /// <value>营业执有效期，格式为yyyy-MM-dd，9999-12-31表示长期</value>
        [DataMember(Name = "license_valid_date", EmitDefaultValue = false)]
        public string LicenseValidDate { get; set; }

        /// <summary>
        /// 门头照图片地址，部分小程序类目需要提交，参照 &lt;a href&#x3D;‘https://opendocs.alipay.com/b/03al2m’&gt;开放服务类目&lt;/a&gt; 中是否需要营业执照信息，如果不填默认采用当前小程序门头照图片
        /// </summary>
        /// <value>门头照图片地址，部分小程序类目需要提交，参照 &lt;a href&#x3D;‘https://opendocs.alipay.com/b/03al2m’&gt;开放服务类目&lt;/a&gt; 中是否需要营业执照信息，如果不填默认采用当前小程序门头照图片</value>
        [DataMember(Name = "out_door_pic", EmitDefaultValue = false)]
        public string OutDoorPic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuditLicenseInfo {\n");
            sb.Append("  LicenseName: ").Append(LicenseName).Append("\n");
            sb.Append("  LicenseNo: ").Append(LicenseNo).Append("\n");
            sb.Append("  LicensePicList: ").Append(LicensePicList).Append("\n");
            sb.Append("  LicenseValidDate: ").Append(LicenseValidDate).Append("\n");
            sb.Append("  OutDoorPic: ").Append(OutDoorPic).Append("\n");
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
            return this.Equals(input as AuditLicenseInfo);
        }

        /// <summary>
        /// Returns true if AuditLicenseInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditLicenseInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditLicenseInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LicenseName == input.LicenseName ||
                    (this.LicenseName != null &&
                    this.LicenseName.Equals(input.LicenseName))
                ) && 
                (
                    this.LicenseNo == input.LicenseNo ||
                    (this.LicenseNo != null &&
                    this.LicenseNo.Equals(input.LicenseNo))
                ) && 
                (
                    this.LicensePicList == input.LicensePicList ||
                    this.LicensePicList != null &&
                    input.LicensePicList != null &&
                    this.LicensePicList.SequenceEqual(input.LicensePicList)
                ) && 
                (
                    this.LicenseValidDate == input.LicenseValidDate ||
                    (this.LicenseValidDate != null &&
                    this.LicenseValidDate.Equals(input.LicenseValidDate))
                ) && 
                (
                    this.OutDoorPic == input.OutDoorPic ||
                    (this.OutDoorPic != null &&
                    this.OutDoorPic.Equals(input.OutDoorPic))
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
                if (this.LicenseName != null)
                {
                    hashCode = (hashCode * 59) + this.LicenseName.GetHashCode();
                }
                if (this.LicenseNo != null)
                {
                    hashCode = (hashCode * 59) + this.LicenseNo.GetHashCode();
                }
                if (this.LicensePicList != null)
                {
                    hashCode = (hashCode * 59) + this.LicensePicList.GetHashCode();
                }
                if (this.LicenseValidDate != null)
                {
                    hashCode = (hashCode * 59) + this.LicenseValidDate.GetHashCode();
                }
                if (this.OutDoorPic != null)
                {
                    hashCode = (hashCode * 59) + this.OutDoorPic.GetHashCode();
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
