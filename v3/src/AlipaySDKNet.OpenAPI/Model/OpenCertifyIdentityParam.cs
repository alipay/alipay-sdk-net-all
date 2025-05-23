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
    /// OpenCertifyIdentityParam
    /// </summary>
    [DataContract(Name = "OpenCertifyIdentityParam")]
    public partial class OpenCertifyIdentityParam : IEquatable<OpenCertifyIdentityParam>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenCertifyIdentityParam" /> class.
        /// </summary>
        /// <param name="certDigest">cert_digest： 身份信息摘要.</param>
        /// <param name="certName">cert_name： 填入真实姓名.</param>
        /// <param name="certNo">cert_no： 填入姓名相匹配的证件号码.</param>
        /// <param name="certType">cert_type： 1、若为身份证，填IDENTITY_CARD； 2、若为港澳居民来往内地通行证，填HOME_VISIT_PERMIT_HK_MC； 3、若为台湾居民来往内地通行证，填HOME_VISIT_PERMIT_TAIWAN； 4、若为港澳居民居住证，填RESIDENCE_PERMIT_HK_MC； 5、若为台湾居民居住证，填RESIDENCE_PERMIT_TAIWAN； 6、外国人永久居留证，填PERMANENT_RESIDENCE_FOREIGNER；.</param>
        /// <param name="facialPictureFront">facial_picture_front： 活体人脸图片base64串，主要用于离线人脸比对.</param>
        /// <param name="identityType">identity_type 1.若本人验证，使用CERT_INFO； 2.若代他人验证，使用AGENT_CERT_INFO；.</param>
        /// <param name="openId">open_id： 开放平台用户ID.</param>
        /// <param name="phoneNo">phone_no： 填写姓名相匹配的手机号.</param>
        /// <param name="userId">user_id： 支付宝用户ID.</param>
        public OpenCertifyIdentityParam(string certDigest = default(string), string certName = default(string), string certNo = default(string), string certType = default(string), string facialPictureFront = default(string), string identityType = default(string), string openId = default(string), string phoneNo = default(string), string userId = default(string))
        {
            this.CertDigest = certDigest;
            this.CertName = certName;
            this.CertNo = certNo;
            this.CertType = certType;
            this.FacialPictureFront = facialPictureFront;
            this.IdentityType = identityType;
            this.OpenId = openId;
            this.PhoneNo = phoneNo;
            this.UserId = userId;
        }

        /// <summary>
        /// cert_digest： 身份信息摘要
        /// </summary>
        /// <value>cert_digest： 身份信息摘要</value>
        [DataMember(Name = "cert_digest", EmitDefaultValue = false)]
        public string CertDigest { get; set; }

        /// <summary>
        /// cert_name： 填入真实姓名
        /// </summary>
        /// <value>cert_name： 填入真实姓名</value>
        [DataMember(Name = "cert_name", EmitDefaultValue = false)]
        public string CertName { get; set; }

        /// <summary>
        /// cert_no： 填入姓名相匹配的证件号码
        /// </summary>
        /// <value>cert_no： 填入姓名相匹配的证件号码</value>
        [DataMember(Name = "cert_no", EmitDefaultValue = false)]
        public string CertNo { get; set; }

        /// <summary>
        /// cert_type： 1、若为身份证，填IDENTITY_CARD； 2、若为港澳居民来往内地通行证，填HOME_VISIT_PERMIT_HK_MC； 3、若为台湾居民来往内地通行证，填HOME_VISIT_PERMIT_TAIWAN； 4、若为港澳居民居住证，填RESIDENCE_PERMIT_HK_MC； 5、若为台湾居民居住证，填RESIDENCE_PERMIT_TAIWAN； 6、外国人永久居留证，填PERMANENT_RESIDENCE_FOREIGNER；
        /// </summary>
        /// <value>cert_type： 1、若为身份证，填IDENTITY_CARD； 2、若为港澳居民来往内地通行证，填HOME_VISIT_PERMIT_HK_MC； 3、若为台湾居民来往内地通行证，填HOME_VISIT_PERMIT_TAIWAN； 4、若为港澳居民居住证，填RESIDENCE_PERMIT_HK_MC； 5、若为台湾居民居住证，填RESIDENCE_PERMIT_TAIWAN； 6、外国人永久居留证，填PERMANENT_RESIDENCE_FOREIGNER；</value>
        [DataMember(Name = "cert_type", EmitDefaultValue = false)]
        public string CertType { get; set; }

        /// <summary>
        /// facial_picture_front： 活体人脸图片base64串，主要用于离线人脸比对
        /// </summary>
        /// <value>facial_picture_front： 活体人脸图片base64串，主要用于离线人脸比对</value>
        [DataMember(Name = "facial_picture_front", EmitDefaultValue = false)]
        public string FacialPictureFront { get; set; }

        /// <summary>
        /// identity_type 1.若本人验证，使用CERT_INFO； 2.若代他人验证，使用AGENT_CERT_INFO；
        /// </summary>
        /// <value>identity_type 1.若本人验证，使用CERT_INFO； 2.若代他人验证，使用AGENT_CERT_INFO；</value>
        [DataMember(Name = "identity_type", EmitDefaultValue = false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// open_id： 开放平台用户ID
        /// </summary>
        /// <value>open_id： 开放平台用户ID</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// phone_no： 填写姓名相匹配的手机号
        /// </summary>
        /// <value>phone_no： 填写姓名相匹配的手机号</value>
        [DataMember(Name = "phone_no", EmitDefaultValue = false)]
        public string PhoneNo { get; set; }

        /// <summary>
        /// user_id： 支付宝用户ID
        /// </summary>
        /// <value>user_id： 支付宝用户ID</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OpenCertifyIdentityParam {\n");
            sb.Append("  CertDigest: ").Append(CertDigest).Append("\n");
            sb.Append("  CertName: ").Append(CertName).Append("\n");
            sb.Append("  CertNo: ").Append(CertNo).Append("\n");
            sb.Append("  CertType: ").Append(CertType).Append("\n");
            sb.Append("  FacialPictureFront: ").Append(FacialPictureFront).Append("\n");
            sb.Append("  IdentityType: ").Append(IdentityType).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  PhoneNo: ").Append(PhoneNo).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as OpenCertifyIdentityParam);
        }

        /// <summary>
        /// Returns true if OpenCertifyIdentityParam instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenCertifyIdentityParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenCertifyIdentityParam input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CertDigest == input.CertDigest ||
                    (this.CertDigest != null &&
                    this.CertDigest.Equals(input.CertDigest))
                ) && 
                (
                    this.CertName == input.CertName ||
                    (this.CertName != null &&
                    this.CertName.Equals(input.CertName))
                ) && 
                (
                    this.CertNo == input.CertNo ||
                    (this.CertNo != null &&
                    this.CertNo.Equals(input.CertNo))
                ) && 
                (
                    this.CertType == input.CertType ||
                    (this.CertType != null &&
                    this.CertType.Equals(input.CertType))
                ) && 
                (
                    this.FacialPictureFront == input.FacialPictureFront ||
                    (this.FacialPictureFront != null &&
                    this.FacialPictureFront.Equals(input.FacialPictureFront))
                ) && 
                (
                    this.IdentityType == input.IdentityType ||
                    (this.IdentityType != null &&
                    this.IdentityType.Equals(input.IdentityType))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.PhoneNo == input.PhoneNo ||
                    (this.PhoneNo != null &&
                    this.PhoneNo.Equals(input.PhoneNo))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.CertDigest != null)
                {
                    hashCode = (hashCode * 59) + this.CertDigest.GetHashCode();
                }
                if (this.CertName != null)
                {
                    hashCode = (hashCode * 59) + this.CertName.GetHashCode();
                }
                if (this.CertNo != null)
                {
                    hashCode = (hashCode * 59) + this.CertNo.GetHashCode();
                }
                if (this.CertType != null)
                {
                    hashCode = (hashCode * 59) + this.CertType.GetHashCode();
                }
                if (this.FacialPictureFront != null)
                {
                    hashCode = (hashCode * 59) + this.FacialPictureFront.GetHashCode();
                }
                if (this.IdentityType != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityType.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.PhoneNo != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNo.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
