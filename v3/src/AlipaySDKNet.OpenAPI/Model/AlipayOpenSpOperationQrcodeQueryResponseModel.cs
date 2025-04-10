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
    /// AlipayOpenSpOperationQrcodeQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSpOperationQrcodeQueryResponseModel")]
    public partial class AlipayOpenSpOperationQrcodeQueryResponseModel : IEquatable<AlipayOpenSpOperationQrcodeQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSpOperationQrcodeQueryResponseModel" /> class.
        /// </summary>
        /// <param name="batchNo">支付宝操作批次号.</param>
        /// <param name="bindAccount">bindAccount.</param>
        /// <param name="qrCodeUrl">二维码图片地址，urlEncode处理过。 注意： 1.有效期为24h; 2.用户扫码确认授权操作（同意/拒绝）后，支付宝将通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01lc2d\&quot;&gt;alipay.open.sp.operation.result.notify&lt;/a&gt;接口发送异步通知给服务商。.</param>
        /// <param name="recommendAccountList">只针对服务商代间连商家发起代运营绑定、授权时，如果传递的alipay_account不符合绑定或授权要求，这个字段会返回推荐的商家支付宝账号列表，包括：支付宝账号和名称，为保护商家信息，账号和名称都按照规范脱敏。.</param>
        /// <param name="recommendAccounts">recommendAccounts.</param>
        public AlipayOpenSpOperationQrcodeQueryResponseModel(string batchNo = default(string), RecommendAccountDTO bindAccount = default(RecommendAccountDTO), string qrCodeUrl = default(string), List<RecommendAccountDTO> recommendAccountList = default(List<RecommendAccountDTO>), RecommendAccountDTO recommendAccounts = default(RecommendAccountDTO))
        {
            this.BatchNo = batchNo;
            this.BindAccount = bindAccount;
            this.QrCodeUrl = qrCodeUrl;
            this.RecommendAccountList = recommendAccountList;
            this.RecommendAccounts = recommendAccounts;
        }

        /// <summary>
        /// 支付宝操作批次号
        /// </summary>
        /// <value>支付宝操作批次号</value>
        [DataMember(Name = "batch_no", EmitDefaultValue = false)]
        public string BatchNo { get; set; }

        /// <summary>
        /// Gets or Sets BindAccount
        /// </summary>
        [DataMember(Name = "bind_account", EmitDefaultValue = false)]
        public RecommendAccountDTO BindAccount { get; set; }

        /// <summary>
        /// 二维码图片地址，urlEncode处理过。 注意： 1.有效期为24h; 2.用户扫码确认授权操作（同意/拒绝）后，支付宝将通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01lc2d\&quot;&gt;alipay.open.sp.operation.result.notify&lt;/a&gt;接口发送异步通知给服务商。
        /// </summary>
        /// <value>二维码图片地址，urlEncode处理过。 注意： 1.有效期为24h; 2.用户扫码确认授权操作（同意/拒绝）后，支付宝将通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01lc2d\&quot;&gt;alipay.open.sp.operation.result.notify&lt;/a&gt;接口发送异步通知给服务商。</value>
        [DataMember(Name = "qr_code_url", EmitDefaultValue = false)]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 只针对服务商代间连商家发起代运营绑定、授权时，如果传递的alipay_account不符合绑定或授权要求，这个字段会返回推荐的商家支付宝账号列表，包括：支付宝账号和名称，为保护商家信息，账号和名称都按照规范脱敏。
        /// </summary>
        /// <value>只针对服务商代间连商家发起代运营绑定、授权时，如果传递的alipay_account不符合绑定或授权要求，这个字段会返回推荐的商家支付宝账号列表，包括：支付宝账号和名称，为保护商家信息，账号和名称都按照规范脱敏。</value>
        [DataMember(Name = "recommend_account_list", EmitDefaultValue = false)]
        public List<RecommendAccountDTO> RecommendAccountList { get; set; }

        /// <summary>
        /// Gets or Sets RecommendAccounts
        /// </summary>
        [DataMember(Name = "recommend_accounts", EmitDefaultValue = false)]
        public RecommendAccountDTO RecommendAccounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSpOperationQrcodeQueryResponseModel {\n");
            sb.Append("  BatchNo: ").Append(BatchNo).Append("\n");
            sb.Append("  BindAccount: ").Append(BindAccount).Append("\n");
            sb.Append("  QrCodeUrl: ").Append(QrCodeUrl).Append("\n");
            sb.Append("  RecommendAccountList: ").Append(RecommendAccountList).Append("\n");
            sb.Append("  RecommendAccounts: ").Append(RecommendAccounts).Append("\n");
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
            return this.Equals(input as AlipayOpenSpOperationQrcodeQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSpOperationQrcodeQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSpOperationQrcodeQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSpOperationQrcodeQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BatchNo == input.BatchNo ||
                    (this.BatchNo != null &&
                    this.BatchNo.Equals(input.BatchNo))
                ) && 
                (
                    this.BindAccount == input.BindAccount ||
                    (this.BindAccount != null &&
                    this.BindAccount.Equals(input.BindAccount))
                ) && 
                (
                    this.QrCodeUrl == input.QrCodeUrl ||
                    (this.QrCodeUrl != null &&
                    this.QrCodeUrl.Equals(input.QrCodeUrl))
                ) && 
                (
                    this.RecommendAccountList == input.RecommendAccountList ||
                    this.RecommendAccountList != null &&
                    input.RecommendAccountList != null &&
                    this.RecommendAccountList.SequenceEqual(input.RecommendAccountList)
                ) && 
                (
                    this.RecommendAccounts == input.RecommendAccounts ||
                    (this.RecommendAccounts != null &&
                    this.RecommendAccounts.Equals(input.RecommendAccounts))
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
                if (this.BatchNo != null)
                {
                    hashCode = (hashCode * 59) + this.BatchNo.GetHashCode();
                }
                if (this.BindAccount != null)
                {
                    hashCode = (hashCode * 59) + this.BindAccount.GetHashCode();
                }
                if (this.QrCodeUrl != null)
                {
                    hashCode = (hashCode * 59) + this.QrCodeUrl.GetHashCode();
                }
                if (this.RecommendAccountList != null)
                {
                    hashCode = (hashCode * 59) + this.RecommendAccountList.GetHashCode();
                }
                if (this.RecommendAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.RecommendAccounts.GetHashCode();
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
