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
    /// InvoiceElementModel
    /// </summary>
    [DataContract(Name = "InvoiceElementModel")]
    public partial class InvoiceElementModel : IEquatable<InvoiceElementModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceElementModel" /> class.
        /// </summary>
        /// <param name="expenseStatus">发票报销状态.</param>
        /// <param name="extendFields">扩展字段.</param>
        /// <param name="fakeCode">防伪校验码.</param>
        /// <param name="fileType">发票原始文件文件类型.</param>
        /// <param name="hasPdfFile">发票是否有pdf文件.</param>
        /// <param name="hasRisk">该发票可能存在异常，请核实后使用  true:无异常  false:存在异常.</param>
        /// <param name="invoiceAmount">发票金额，含税，单位元.</param>
        /// <param name="invoiceCode">发票代码.</param>
        /// <param name="invoiceDate">开票日期.</param>
        /// <param name="invoiceImgUrl">发票pdf文件转换后jpg预览地址.</param>
        /// <param name="invoiceKind">发票类型.</param>
        /// <param name="invoiceNo">发票号码.</param>
        /// <param name="invoiceStatus">发票状态　.</param>
        /// <param name="isvContact">服务商联系方式.</param>
        /// <param name="isvName">服务商名称.</param>
        /// <param name="logoUrl">logo地址.</param>
        /// <param name="mName">商户全称.</param>
        /// <param name="outTaxAmount">发票金额，不含税，单位元.</param>
        /// <param name="payeeName">销方名称.</param>
        /// <param name="payeeTaxNo">销方税号.</param>
        /// <param name="payerName">购方名称.</param>
        /// <param name="payerTaxNo">购方税号.</param>
        /// <param name="pdfUrl">PDF的下载链接.</param>
        /// <param name="source">表示发票来源，由发票回传方带入。例如：bz_gd，bz_ele，bz_tmall等.</param>
        /// <param name="tradeList">该发票对应的交易.</param>
        /// <param name="tradeMatchResult">交易匹配结果.</param>
        public InvoiceElementModel(string expenseStatus = default(string), string extendFields = default(string), string fakeCode = default(string), string fileType = default(string), bool hasPdfFile = default(bool), bool hasRisk = default(bool), string invoiceAmount = default(string), string invoiceCode = default(string), string invoiceDate = default(string), string invoiceImgUrl = default(string), string invoiceKind = default(string), string invoiceNo = default(string), string invoiceStatus = default(string), string isvContact = default(string), string isvName = default(string), string logoUrl = default(string), string mName = default(string), string outTaxAmount = default(string), string payeeName = default(string), string payeeTaxNo = default(string), string payerName = default(string), string payerTaxNo = default(string), string pdfUrl = default(string), string source = default(string), List<EinvTrade> tradeList = default(List<EinvTrade>), string tradeMatchResult = default(string))
        {
            this.ExpenseStatus = expenseStatus;
            this.ExtendFields = extendFields;
            this.FakeCode = fakeCode;
            this.FileType = fileType;
            this.HasPdfFile = hasPdfFile;
            this.HasRisk = hasRisk;
            this.InvoiceAmount = invoiceAmount;
            this.InvoiceCode = invoiceCode;
            this.InvoiceDate = invoiceDate;
            this.InvoiceImgUrl = invoiceImgUrl;
            this.InvoiceKind = invoiceKind;
            this.InvoiceNo = invoiceNo;
            this.InvoiceStatus = invoiceStatus;
            this.IsvContact = isvContact;
            this.IsvName = isvName;
            this.LogoUrl = logoUrl;
            this.MName = mName;
            this.OutTaxAmount = outTaxAmount;
            this.PayeeName = payeeName;
            this.PayeeTaxNo = payeeTaxNo;
            this.PayerName = payerName;
            this.PayerTaxNo = payerTaxNo;
            this.PdfUrl = pdfUrl;
            this.Source = source;
            this.TradeList = tradeList;
            this.TradeMatchResult = tradeMatchResult;
        }

        /// <summary>
        /// 发票报销状态
        /// </summary>
        /// <value>发票报销状态</value>
        [DataMember(Name = "expense_status", EmitDefaultValue = false)]
        public string ExpenseStatus { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        /// <value>扩展字段</value>
        [DataMember(Name = "extend_fields", EmitDefaultValue = false)]
        public string ExtendFields { get; set; }

        /// <summary>
        /// 防伪校验码
        /// </summary>
        /// <value>防伪校验码</value>
        [DataMember(Name = "fake_code", EmitDefaultValue = false)]
        public string FakeCode { get; set; }

        /// <summary>
        /// 发票原始文件文件类型
        /// </summary>
        /// <value>发票原始文件文件类型</value>
        [DataMember(Name = "file_type", EmitDefaultValue = false)]
        public string FileType { get; set; }

        /// <summary>
        /// 发票是否有pdf文件
        /// </summary>
        /// <value>发票是否有pdf文件</value>
        [DataMember(Name = "has_pdf_file", EmitDefaultValue = true)]
        public bool HasPdfFile { get; set; }

        /// <summary>
        /// 该发票可能存在异常，请核实后使用  true:无异常  false:存在异常
        /// </summary>
        /// <value>该发票可能存在异常，请核实后使用  true:无异常  false:存在异常</value>
        [DataMember(Name = "has_risk", EmitDefaultValue = true)]
        public bool HasRisk { get; set; }

        /// <summary>
        /// 发票金额，含税，单位元
        /// </summary>
        /// <value>发票金额，含税，单位元</value>
        [DataMember(Name = "invoice_amount", EmitDefaultValue = false)]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        /// <value>发票代码</value>
        [DataMember(Name = "invoice_code", EmitDefaultValue = false)]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        /// <value>开票日期</value>
        [DataMember(Name = "invoice_date", EmitDefaultValue = false)]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票pdf文件转换后jpg预览地址
        /// </summary>
        /// <value>发票pdf文件转换后jpg预览地址</value>
        [DataMember(Name = "invoice_img_url", EmitDefaultValue = false)]
        public string InvoiceImgUrl { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        /// <value>发票类型</value>
        [DataMember(Name = "invoice_kind", EmitDefaultValue = false)]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        /// <value>发票号码</value>
        [DataMember(Name = "invoice_no", EmitDefaultValue = false)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票状态　
        /// </summary>
        /// <value>发票状态　</value>
        [DataMember(Name = "invoice_status", EmitDefaultValue = false)]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 服务商联系方式
        /// </summary>
        /// <value>服务商联系方式</value>
        [DataMember(Name = "isv_contact", EmitDefaultValue = false)]
        public string IsvContact { get; set; }

        /// <summary>
        /// 服务商名称
        /// </summary>
        /// <value>服务商名称</value>
        [DataMember(Name = "isv_name", EmitDefaultValue = false)]
        public string IsvName { get; set; }

        /// <summary>
        /// logo地址
        /// </summary>
        /// <value>logo地址</value>
        [DataMember(Name = "logo_url", EmitDefaultValue = false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 商户全称
        /// </summary>
        /// <value>商户全称</value>
        [DataMember(Name = "m_name", EmitDefaultValue = false)]
        public string MName { get; set; }

        /// <summary>
        /// 发票金额，不含税，单位元
        /// </summary>
        /// <value>发票金额，不含税，单位元</value>
        [DataMember(Name = "out_tax_amount", EmitDefaultValue = false)]
        public string OutTaxAmount { get; set; }

        /// <summary>
        /// 销方名称
        /// </summary>
        /// <value>销方名称</value>
        [DataMember(Name = "payee_name", EmitDefaultValue = false)]
        public string PayeeName { get; set; }

        /// <summary>
        /// 销方税号
        /// </summary>
        /// <value>销方税号</value>
        [DataMember(Name = "payee_tax_no", EmitDefaultValue = false)]
        public string PayeeTaxNo { get; set; }

        /// <summary>
        /// 购方名称
        /// </summary>
        /// <value>购方名称</value>
        [DataMember(Name = "payer_name", EmitDefaultValue = false)]
        public string PayerName { get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        /// <value>购方税号</value>
        [DataMember(Name = "payer_tax_no", EmitDefaultValue = false)]
        public string PayerTaxNo { get; set; }

        /// <summary>
        /// PDF的下载链接
        /// </summary>
        /// <value>PDF的下载链接</value>
        [DataMember(Name = "pdf_url", EmitDefaultValue = false)]
        public string PdfUrl { get; set; }

        /// <summary>
        /// 表示发票来源，由发票回传方带入。例如：bz_gd，bz_ele，bz_tmall等
        /// </summary>
        /// <value>表示发票来源，由发票回传方带入。例如：bz_gd，bz_ele，bz_tmall等</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// 该发票对应的交易
        /// </summary>
        /// <value>该发票对应的交易</value>
        [DataMember(Name = "trade_list", EmitDefaultValue = false)]
        public List<EinvTrade> TradeList { get; set; }

        /// <summary>
        /// 交易匹配结果
        /// </summary>
        /// <value>交易匹配结果</value>
        [DataMember(Name = "trade_match_result", EmitDefaultValue = false)]
        public string TradeMatchResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceElementModel {\n");
            sb.Append("  ExpenseStatus: ").Append(ExpenseStatus).Append("\n");
            sb.Append("  ExtendFields: ").Append(ExtendFields).Append("\n");
            sb.Append("  FakeCode: ").Append(FakeCode).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  HasPdfFile: ").Append(HasPdfFile).Append("\n");
            sb.Append("  HasRisk: ").Append(HasRisk).Append("\n");
            sb.Append("  InvoiceAmount: ").Append(InvoiceAmount).Append("\n");
            sb.Append("  InvoiceCode: ").Append(InvoiceCode).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  InvoiceImgUrl: ").Append(InvoiceImgUrl).Append("\n");
            sb.Append("  InvoiceKind: ").Append(InvoiceKind).Append("\n");
            sb.Append("  InvoiceNo: ").Append(InvoiceNo).Append("\n");
            sb.Append("  InvoiceStatus: ").Append(InvoiceStatus).Append("\n");
            sb.Append("  IsvContact: ").Append(IsvContact).Append("\n");
            sb.Append("  IsvName: ").Append(IsvName).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  MName: ").Append(MName).Append("\n");
            sb.Append("  OutTaxAmount: ").Append(OutTaxAmount).Append("\n");
            sb.Append("  PayeeName: ").Append(PayeeName).Append("\n");
            sb.Append("  PayeeTaxNo: ").Append(PayeeTaxNo).Append("\n");
            sb.Append("  PayerName: ").Append(PayerName).Append("\n");
            sb.Append("  PayerTaxNo: ").Append(PayerTaxNo).Append("\n");
            sb.Append("  PdfUrl: ").Append(PdfUrl).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  TradeList: ").Append(TradeList).Append("\n");
            sb.Append("  TradeMatchResult: ").Append(TradeMatchResult).Append("\n");
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
            return this.Equals(input as InvoiceElementModel);
        }

        /// <summary>
        /// Returns true if InvoiceElementModel instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceElementModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceElementModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExpenseStatus == input.ExpenseStatus ||
                    (this.ExpenseStatus != null &&
                    this.ExpenseStatus.Equals(input.ExpenseStatus))
                ) && 
                (
                    this.ExtendFields == input.ExtendFields ||
                    (this.ExtendFields != null &&
                    this.ExtendFields.Equals(input.ExtendFields))
                ) && 
                (
                    this.FakeCode == input.FakeCode ||
                    (this.FakeCode != null &&
                    this.FakeCode.Equals(input.FakeCode))
                ) && 
                (
                    this.FileType == input.FileType ||
                    (this.FileType != null &&
                    this.FileType.Equals(input.FileType))
                ) && 
                (
                    this.HasPdfFile == input.HasPdfFile ||
                    this.HasPdfFile.Equals(input.HasPdfFile)
                ) && 
                (
                    this.HasRisk == input.HasRisk ||
                    this.HasRisk.Equals(input.HasRisk)
                ) && 
                (
                    this.InvoiceAmount == input.InvoiceAmount ||
                    (this.InvoiceAmount != null &&
                    this.InvoiceAmount.Equals(input.InvoiceAmount))
                ) && 
                (
                    this.InvoiceCode == input.InvoiceCode ||
                    (this.InvoiceCode != null &&
                    this.InvoiceCode.Equals(input.InvoiceCode))
                ) && 
                (
                    this.InvoiceDate == input.InvoiceDate ||
                    (this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(input.InvoiceDate))
                ) && 
                (
                    this.InvoiceImgUrl == input.InvoiceImgUrl ||
                    (this.InvoiceImgUrl != null &&
                    this.InvoiceImgUrl.Equals(input.InvoiceImgUrl))
                ) && 
                (
                    this.InvoiceKind == input.InvoiceKind ||
                    (this.InvoiceKind != null &&
                    this.InvoiceKind.Equals(input.InvoiceKind))
                ) && 
                (
                    this.InvoiceNo == input.InvoiceNo ||
                    (this.InvoiceNo != null &&
                    this.InvoiceNo.Equals(input.InvoiceNo))
                ) && 
                (
                    this.InvoiceStatus == input.InvoiceStatus ||
                    (this.InvoiceStatus != null &&
                    this.InvoiceStatus.Equals(input.InvoiceStatus))
                ) && 
                (
                    this.IsvContact == input.IsvContact ||
                    (this.IsvContact != null &&
                    this.IsvContact.Equals(input.IsvContact))
                ) && 
                (
                    this.IsvName == input.IsvName ||
                    (this.IsvName != null &&
                    this.IsvName.Equals(input.IsvName))
                ) && 
                (
                    this.LogoUrl == input.LogoUrl ||
                    (this.LogoUrl != null &&
                    this.LogoUrl.Equals(input.LogoUrl))
                ) && 
                (
                    this.MName == input.MName ||
                    (this.MName != null &&
                    this.MName.Equals(input.MName))
                ) && 
                (
                    this.OutTaxAmount == input.OutTaxAmount ||
                    (this.OutTaxAmount != null &&
                    this.OutTaxAmount.Equals(input.OutTaxAmount))
                ) && 
                (
                    this.PayeeName == input.PayeeName ||
                    (this.PayeeName != null &&
                    this.PayeeName.Equals(input.PayeeName))
                ) && 
                (
                    this.PayeeTaxNo == input.PayeeTaxNo ||
                    (this.PayeeTaxNo != null &&
                    this.PayeeTaxNo.Equals(input.PayeeTaxNo))
                ) && 
                (
                    this.PayerName == input.PayerName ||
                    (this.PayerName != null &&
                    this.PayerName.Equals(input.PayerName))
                ) && 
                (
                    this.PayerTaxNo == input.PayerTaxNo ||
                    (this.PayerTaxNo != null &&
                    this.PayerTaxNo.Equals(input.PayerTaxNo))
                ) && 
                (
                    this.PdfUrl == input.PdfUrl ||
                    (this.PdfUrl != null &&
                    this.PdfUrl.Equals(input.PdfUrl))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.TradeList == input.TradeList ||
                    this.TradeList != null &&
                    input.TradeList != null &&
                    this.TradeList.SequenceEqual(input.TradeList)
                ) && 
                (
                    this.TradeMatchResult == input.TradeMatchResult ||
                    (this.TradeMatchResult != null &&
                    this.TradeMatchResult.Equals(input.TradeMatchResult))
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
                if (this.ExpenseStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseStatus.GetHashCode();
                }
                if (this.ExtendFields != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendFields.GetHashCode();
                }
                if (this.FakeCode != null)
                {
                    hashCode = (hashCode * 59) + this.FakeCode.GetHashCode();
                }
                if (this.FileType != null)
                {
                    hashCode = (hashCode * 59) + this.FileType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasPdfFile.GetHashCode();
                hashCode = (hashCode * 59) + this.HasRisk.GetHashCode();
                if (this.InvoiceAmount != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceAmount.GetHashCode();
                }
                if (this.InvoiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceCode.GetHashCode();
                }
                if (this.InvoiceDate != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceDate.GetHashCode();
                }
                if (this.InvoiceImgUrl != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceImgUrl.GetHashCode();
                }
                if (this.InvoiceKind != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceKind.GetHashCode();
                }
                if (this.InvoiceNo != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceNo.GetHashCode();
                }
                if (this.InvoiceStatus != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceStatus.GetHashCode();
                }
                if (this.IsvContact != null)
                {
                    hashCode = (hashCode * 59) + this.IsvContact.GetHashCode();
                }
                if (this.IsvName != null)
                {
                    hashCode = (hashCode * 59) + this.IsvName.GetHashCode();
                }
                if (this.LogoUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LogoUrl.GetHashCode();
                }
                if (this.MName != null)
                {
                    hashCode = (hashCode * 59) + this.MName.GetHashCode();
                }
                if (this.OutTaxAmount != null)
                {
                    hashCode = (hashCode * 59) + this.OutTaxAmount.GetHashCode();
                }
                if (this.PayeeName != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeName.GetHashCode();
                }
                if (this.PayeeTaxNo != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeTaxNo.GetHashCode();
                }
                if (this.PayerName != null)
                {
                    hashCode = (hashCode * 59) + this.PayerName.GetHashCode();
                }
                if (this.PayerTaxNo != null)
                {
                    hashCode = (hashCode * 59) + this.PayerTaxNo.GetHashCode();
                }
                if (this.PdfUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PdfUrl.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.TradeList != null)
                {
                    hashCode = (hashCode * 59) + this.TradeList.GetHashCode();
                }
                if (this.TradeMatchResult != null)
                {
                    hashCode = (hashCode * 59) + this.TradeMatchResult.GetHashCode();
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
