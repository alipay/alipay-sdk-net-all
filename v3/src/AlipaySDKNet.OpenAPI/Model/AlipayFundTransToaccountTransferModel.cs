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
    /// AlipayFundTransToaccountTransferModel
    /// </summary>
    [DataContract(Name = "AlipayFundTransToaccountTransferModel")]
    public partial class AlipayFundTransToaccountTransferModel : IEquatable<AlipayFundTransToaccountTransferModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundTransToaccountTransferModel" /> class.
        /// </summary>
        /// <param name="amount">转账金额，单位：元。  只支持2位小数，小数点前最大支持13位，金额必须大于等于0.1元。   最大转账金额以实际签约的限额为准。.</param>
        /// <param name="extParam">扩展参数，json字符串格式，目前仅支持的key&#x3D;order_title，表示收款方的转账账单标题，value可以根据自己的业务定制。.</param>
        /// <param name="outBizNo">商户转账唯一订单号。发起转账来源方定义的转账单据ID，用于将转账回执通知给来源方。  不同来源方给出的ID可以重复，同一个来源方必须保证其ID的唯一性。  只支持半角英文、数字，及“-”、“_”。.</param>
        /// <param name="payeeAccount">收款方账户。与payee_type配合使用。付款方和收款方不能是同一个账户。.</param>
        /// <param name="payeeRealName">收款方真实姓名（最长支持100个英文/50个汉字）。  如果本参数不为空，则会校验该账户在支付宝登记的实名是否与收款方真实姓名一致。.</param>
        /// <param name="payeeType">收款方账户类型。可取值： 1、ALIPAY_USERID：支付宝账号对应的支付宝唯一用户号。以2088开头的16位纯数字组成。 2、ALIPAY_LOGONID：支付宝登录号，支持邮箱和手机号格式。 2、ALIPAY_OPENID：支付宝openid.</param>
        /// <param name="payerRealName">付款方真实姓名（最长支持100个英文/50个汉字）。  如果本参数不为空，则会校验该账户在支付宝登记的实名是否与付款方真实姓名一致。.</param>
        /// <param name="payerShowName">付款方姓名（最长支持100个英文/50个汉字）。显示在收款方的账单详情页。如果该字段不传，则默认显示付款方的支付宝认证姓名或单位名称。.</param>
        /// <param name="remark">转账备注（支持200个英文/100个汉字）。  当付款方为企业账户，且转账金额达到（大于等于）50000元，remark不能为空。收款方可见，会展示在收款用户的收支详情中。.</param>
        public AlipayFundTransToaccountTransferModel(string amount = default(string), string extParam = default(string), string outBizNo = default(string), string payeeAccount = default(string), string payeeRealName = default(string), string payeeType = default(string), string payerRealName = default(string), string payerShowName = default(string), string remark = default(string))
        {
            this.Amount = amount;
            this.ExtParam = extParam;
            this.OutBizNo = outBizNo;
            this.PayeeAccount = payeeAccount;
            this.PayeeRealName = payeeRealName;
            this.PayeeType = payeeType;
            this.PayerRealName = payerRealName;
            this.PayerShowName = payerShowName;
            this.Remark = remark;
        }

        /// <summary>
        /// 转账金额，单位：元。  只支持2位小数，小数点前最大支持13位，金额必须大于等于0.1元。   最大转账金额以实际签约的限额为准。
        /// </summary>
        /// <value>转账金额，单位：元。  只支持2位小数，小数点前最大支持13位，金额必须大于等于0.1元。   最大转账金额以实际签约的限额为准。</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 扩展参数，json字符串格式，目前仅支持的key&#x3D;order_title，表示收款方的转账账单标题，value可以根据自己的业务定制。
        /// </summary>
        /// <value>扩展参数，json字符串格式，目前仅支持的key&#x3D;order_title，表示收款方的转账账单标题，value可以根据自己的业务定制。</value>
        [DataMember(Name = "ext_param", EmitDefaultValue = false)]
        public string ExtParam { get; set; }

        /// <summary>
        /// 商户转账唯一订单号。发起转账来源方定义的转账单据ID，用于将转账回执通知给来源方。  不同来源方给出的ID可以重复，同一个来源方必须保证其ID的唯一性。  只支持半角英文、数字，及“-”、“_”。
        /// </summary>
        /// <value>商户转账唯一订单号。发起转账来源方定义的转账单据ID，用于将转账回执通知给来源方。  不同来源方给出的ID可以重复，同一个来源方必须保证其ID的唯一性。  只支持半角英文、数字，及“-”、“_”。</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 收款方账户。与payee_type配合使用。付款方和收款方不能是同一个账户。
        /// </summary>
        /// <value>收款方账户。与payee_type配合使用。付款方和收款方不能是同一个账户。</value>
        [DataMember(Name = "payee_account", EmitDefaultValue = false)]
        public string PayeeAccount { get; set; }

        /// <summary>
        /// 收款方真实姓名（最长支持100个英文/50个汉字）。  如果本参数不为空，则会校验该账户在支付宝登记的实名是否与收款方真实姓名一致。
        /// </summary>
        /// <value>收款方真实姓名（最长支持100个英文/50个汉字）。  如果本参数不为空，则会校验该账户在支付宝登记的实名是否与收款方真实姓名一致。</value>
        [DataMember(Name = "payee_real_name", EmitDefaultValue = false)]
        public string PayeeRealName { get; set; }

        /// <summary>
        /// 收款方账户类型。可取值： 1、ALIPAY_USERID：支付宝账号对应的支付宝唯一用户号。以2088开头的16位纯数字组成。 2、ALIPAY_LOGONID：支付宝登录号，支持邮箱和手机号格式。 2、ALIPAY_OPENID：支付宝openid
        /// </summary>
        /// <value>收款方账户类型。可取值： 1、ALIPAY_USERID：支付宝账号对应的支付宝唯一用户号。以2088开头的16位纯数字组成。 2、ALIPAY_LOGONID：支付宝登录号，支持邮箱和手机号格式。 2、ALIPAY_OPENID：支付宝openid</value>
        [DataMember(Name = "payee_type", EmitDefaultValue = false)]
        public string PayeeType { get; set; }

        /// <summary>
        /// 付款方真实姓名（最长支持100个英文/50个汉字）。  如果本参数不为空，则会校验该账户在支付宝登记的实名是否与付款方真实姓名一致。
        /// </summary>
        /// <value>付款方真实姓名（最长支持100个英文/50个汉字）。  如果本参数不为空，则会校验该账户在支付宝登记的实名是否与付款方真实姓名一致。</value>
        [DataMember(Name = "payer_real_name", EmitDefaultValue = false)]
        public string PayerRealName { get; set; }

        /// <summary>
        /// 付款方姓名（最长支持100个英文/50个汉字）。显示在收款方的账单详情页。如果该字段不传，则默认显示付款方的支付宝认证姓名或单位名称。
        /// </summary>
        /// <value>付款方姓名（最长支持100个英文/50个汉字）。显示在收款方的账单详情页。如果该字段不传，则默认显示付款方的支付宝认证姓名或单位名称。</value>
        [DataMember(Name = "payer_show_name", EmitDefaultValue = false)]
        public string PayerShowName { get; set; }

        /// <summary>
        /// 转账备注（支持200个英文/100个汉字）。  当付款方为企业账户，且转账金额达到（大于等于）50000元，remark不能为空。收款方可见，会展示在收款用户的收支详情中。
        /// </summary>
        /// <value>转账备注（支持200个英文/100个汉字）。  当付款方为企业账户，且转账金额达到（大于等于）50000元，remark不能为空。收款方可见，会展示在收款用户的收支详情中。</value>
        [DataMember(Name = "remark", EmitDefaultValue = false)]
        public string Remark { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundTransToaccountTransferModel {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ExtParam: ").Append(ExtParam).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  PayeeAccount: ").Append(PayeeAccount).Append("\n");
            sb.Append("  PayeeRealName: ").Append(PayeeRealName).Append("\n");
            sb.Append("  PayeeType: ").Append(PayeeType).Append("\n");
            sb.Append("  PayerRealName: ").Append(PayerRealName).Append("\n");
            sb.Append("  PayerShowName: ").Append(PayerShowName).Append("\n");
            sb.Append("  Remark: ").Append(Remark).Append("\n");
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
            return this.Equals(input as AlipayFundTransToaccountTransferModel);
        }

        /// <summary>
        /// Returns true if AlipayFundTransToaccountTransferModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundTransToaccountTransferModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundTransToaccountTransferModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.ExtParam == input.ExtParam ||
                    (this.ExtParam != null &&
                    this.ExtParam.Equals(input.ExtParam))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.PayeeAccount == input.PayeeAccount ||
                    (this.PayeeAccount != null &&
                    this.PayeeAccount.Equals(input.PayeeAccount))
                ) && 
                (
                    this.PayeeRealName == input.PayeeRealName ||
                    (this.PayeeRealName != null &&
                    this.PayeeRealName.Equals(input.PayeeRealName))
                ) && 
                (
                    this.PayeeType == input.PayeeType ||
                    (this.PayeeType != null &&
                    this.PayeeType.Equals(input.PayeeType))
                ) && 
                (
                    this.PayerRealName == input.PayerRealName ||
                    (this.PayerRealName != null &&
                    this.PayerRealName.Equals(input.PayerRealName))
                ) && 
                (
                    this.PayerShowName == input.PayerShowName ||
                    (this.PayerShowName != null &&
                    this.PayerShowName.Equals(input.PayerShowName))
                ) && 
                (
                    this.Remark == input.Remark ||
                    (this.Remark != null &&
                    this.Remark.Equals(input.Remark))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.ExtParam != null)
                {
                    hashCode = (hashCode * 59) + this.ExtParam.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.PayeeAccount != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeAccount.GetHashCode();
                }
                if (this.PayeeRealName != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeRealName.GetHashCode();
                }
                if (this.PayeeType != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeType.GetHashCode();
                }
                if (this.PayerRealName != null)
                {
                    hashCode = (hashCode * 59) + this.PayerRealName.GetHashCode();
                }
                if (this.PayerShowName != null)
                {
                    hashCode = (hashCode * 59) + this.PayerShowName.GetHashCode();
                }
                if (this.Remark != null)
                {
                    hashCode = (hashCode * 59) + this.Remark.GetHashCode();
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
