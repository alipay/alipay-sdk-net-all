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
    /// AlipayFundTransPayModel
    /// </summary>
    [DataContract(Name = "AlipayFundTransPayModel")]
    public partial class AlipayFundTransPayModel : IEquatable<AlipayFundTransPayModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundTransPayModel" /> class.
        /// </summary>
        /// <param name="authInfo">authInfo.</param>
        /// <param name="bizScene">业务场景，比如群收款、红包等.</param>
        /// <param name="businessParams">JSON格式，传递业务扩展参数，使用前请与支付宝工程师联系！.</param>
        /// <param name="orderTitle">订单的标题，用于在收银台和消费记录展示.</param>
        /// <param name="outBizNo">商户端的唯一订单号，对于同一笔转账请求，商户需保证该订单号唯一。.</param>
        /// <param name="passbackParams">回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数。.</param>
        /// <param name="payeeInfo">payeeInfo.</param>
        /// <param name="payerInfo">payerInfo.</param>
        /// <param name="productCode">销售产品码，商家和支付宝签约的产品码.</param>
        /// <param name="refundTimeExpire">退款超时时间，格式yyyy-MM-dd HH:mm。到指定时间后，系统会自动触发退款，并原路退回到付款账户。如果指定了退款时间，必须早于销售方案里设置的最晚退款时间。.</param>
        /// <param name="remark">备注.</param>
        /// <param name="timeExpire">绝对超时时间，格式为yyyy-MM-dd HH:mm.</param>
        /// <param name="transAmount">订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000].</param>
        public AlipayFundTransPayModel(AuthInfo authInfo = default(AuthInfo), string bizScene = default(string), string businessParams = default(string), string orderTitle = default(string), string outBizNo = default(string), string passbackParams = default(string), Participant payeeInfo = default(Participant), Participant payerInfo = default(Participant), string productCode = default(string), string refundTimeExpire = default(string), string remark = default(string), string timeExpire = default(string), string transAmount = default(string))
        {
            this.AuthInfo = authInfo;
            this.BizScene = bizScene;
            this.BusinessParams = businessParams;
            this.OrderTitle = orderTitle;
            this.OutBizNo = outBizNo;
            this.PassbackParams = passbackParams;
            this.PayeeInfo = payeeInfo;
            this.PayerInfo = payerInfo;
            this.ProductCode = productCode;
            this.RefundTimeExpire = refundTimeExpire;
            this.Remark = remark;
            this.TimeExpire = timeExpire;
            this.TransAmount = transAmount;
        }

        /// <summary>
        /// Gets or Sets AuthInfo
        /// </summary>
        [DataMember(Name = "auth_info", EmitDefaultValue = false)]
        public AuthInfo AuthInfo { get; set; }

        /// <summary>
        /// 业务场景，比如群收款、红包等
        /// </summary>
        /// <value>业务场景，比如群收款、红包等</value>
        [DataMember(Name = "biz_scene", EmitDefaultValue = false)]
        public string BizScene { get; set; }

        /// <summary>
        /// JSON格式，传递业务扩展参数，使用前请与支付宝工程师联系！
        /// </summary>
        /// <value>JSON格式，传递业务扩展参数，使用前请与支付宝工程师联系！</value>
        [DataMember(Name = "business_params", EmitDefaultValue = false)]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 订单的标题，用于在收银台和消费记录展示
        /// </summary>
        /// <value>订单的标题，用于在收银台和消费记录展示</value>
        [DataMember(Name = "order_title", EmitDefaultValue = false)]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户端的唯一订单号，对于同一笔转账请求，商户需保证该订单号唯一。
        /// </summary>
        /// <value>商户端的唯一订单号，对于同一笔转账请求，商户需保证该订单号唯一。</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数。
        /// </summary>
        /// <value>回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数。</value>
        [DataMember(Name = "passback_params", EmitDefaultValue = false)]
        public string PassbackParams { get; set; }

        /// <summary>
        /// Gets or Sets PayeeInfo
        /// </summary>
        [DataMember(Name = "payee_info", EmitDefaultValue = false)]
        public Participant PayeeInfo { get; set; }

        /// <summary>
        /// Gets or Sets PayerInfo
        /// </summary>
        [DataMember(Name = "payer_info", EmitDefaultValue = false)]
        public Participant PayerInfo { get; set; }

        /// <summary>
        /// 销售产品码，商家和支付宝签约的产品码
        /// </summary>
        /// <value>销售产品码，商家和支付宝签约的产品码</value>
        [DataMember(Name = "product_code", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// 退款超时时间，格式yyyy-MM-dd HH:mm。到指定时间后，系统会自动触发退款，并原路退回到付款账户。如果指定了退款时间，必须早于销售方案里设置的最晚退款时间。
        /// </summary>
        /// <value>退款超时时间，格式yyyy-MM-dd HH:mm。到指定时间后，系统会自动触发退款，并原路退回到付款账户。如果指定了退款时间，必须早于销售方案里设置的最晚退款时间。</value>
        [DataMember(Name = "refund_time_expire", EmitDefaultValue = false)]
        public string RefundTimeExpire { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        /// <value>备注</value>
        [DataMember(Name = "remark", EmitDefaultValue = false)]
        public string Remark { get; set; }

        /// <summary>
        /// 绝对超时时间，格式为yyyy-MM-dd HH:mm
        /// </summary>
        /// <value>绝对超时时间，格式为yyyy-MM-dd HH:mm</value>
        [DataMember(Name = "time_expire", EmitDefaultValue = false)]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        /// <value>订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]</value>
        [DataMember(Name = "trans_amount", EmitDefaultValue = false)]
        public string TransAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundTransPayModel {\n");
            sb.Append("  AuthInfo: ").Append(AuthInfo).Append("\n");
            sb.Append("  BizScene: ").Append(BizScene).Append("\n");
            sb.Append("  BusinessParams: ").Append(BusinessParams).Append("\n");
            sb.Append("  OrderTitle: ").Append(OrderTitle).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  PassbackParams: ").Append(PassbackParams).Append("\n");
            sb.Append("  PayeeInfo: ").Append(PayeeInfo).Append("\n");
            sb.Append("  PayerInfo: ").Append(PayerInfo).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  RefundTimeExpire: ").Append(RefundTimeExpire).Append("\n");
            sb.Append("  Remark: ").Append(Remark).Append("\n");
            sb.Append("  TimeExpire: ").Append(TimeExpire).Append("\n");
            sb.Append("  TransAmount: ").Append(TransAmount).Append("\n");
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
            return this.Equals(input as AlipayFundTransPayModel);
        }

        /// <summary>
        /// Returns true if AlipayFundTransPayModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundTransPayModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundTransPayModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthInfo == input.AuthInfo ||
                    (this.AuthInfo != null &&
                    this.AuthInfo.Equals(input.AuthInfo))
                ) && 
                (
                    this.BizScene == input.BizScene ||
                    (this.BizScene != null &&
                    this.BizScene.Equals(input.BizScene))
                ) && 
                (
                    this.BusinessParams == input.BusinessParams ||
                    (this.BusinessParams != null &&
                    this.BusinessParams.Equals(input.BusinessParams))
                ) && 
                (
                    this.OrderTitle == input.OrderTitle ||
                    (this.OrderTitle != null &&
                    this.OrderTitle.Equals(input.OrderTitle))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.PassbackParams == input.PassbackParams ||
                    (this.PassbackParams != null &&
                    this.PassbackParams.Equals(input.PassbackParams))
                ) && 
                (
                    this.PayeeInfo == input.PayeeInfo ||
                    (this.PayeeInfo != null &&
                    this.PayeeInfo.Equals(input.PayeeInfo))
                ) && 
                (
                    this.PayerInfo == input.PayerInfo ||
                    (this.PayerInfo != null &&
                    this.PayerInfo.Equals(input.PayerInfo))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.RefundTimeExpire == input.RefundTimeExpire ||
                    (this.RefundTimeExpire != null &&
                    this.RefundTimeExpire.Equals(input.RefundTimeExpire))
                ) && 
                (
                    this.Remark == input.Remark ||
                    (this.Remark != null &&
                    this.Remark.Equals(input.Remark))
                ) && 
                (
                    this.TimeExpire == input.TimeExpire ||
                    (this.TimeExpire != null &&
                    this.TimeExpire.Equals(input.TimeExpire))
                ) && 
                (
                    this.TransAmount == input.TransAmount ||
                    (this.TransAmount != null &&
                    this.TransAmount.Equals(input.TransAmount))
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
                if (this.AuthInfo != null)
                {
                    hashCode = (hashCode * 59) + this.AuthInfo.GetHashCode();
                }
                if (this.BizScene != null)
                {
                    hashCode = (hashCode * 59) + this.BizScene.GetHashCode();
                }
                if (this.BusinessParams != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessParams.GetHashCode();
                }
                if (this.OrderTitle != null)
                {
                    hashCode = (hashCode * 59) + this.OrderTitle.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.PassbackParams != null)
                {
                    hashCode = (hashCode * 59) + this.PassbackParams.GetHashCode();
                }
                if (this.PayeeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeInfo.GetHashCode();
                }
                if (this.PayerInfo != null)
                {
                    hashCode = (hashCode * 59) + this.PayerInfo.GetHashCode();
                }
                if (this.ProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProductCode.GetHashCode();
                }
                if (this.RefundTimeExpire != null)
                {
                    hashCode = (hashCode * 59) + this.RefundTimeExpire.GetHashCode();
                }
                if (this.Remark != null)
                {
                    hashCode = (hashCode * 59) + this.Remark.GetHashCode();
                }
                if (this.TimeExpire != null)
                {
                    hashCode = (hashCode * 59) + this.TimeExpire.GetHashCode();
                }
                if (this.TransAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TransAmount.GetHashCode();
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
