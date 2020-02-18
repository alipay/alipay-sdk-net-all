using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinanceReceivableInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FinanceReceivableInfo : AopObject
    {
        /// <summary>
        /// 账款金额，以元为单位，精确到小数点后2位
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 核心企业信息
        /// </summary>
        [XmlElement("core_business_info")]
        public FinanceMemberInfo CoreBusinessInfo { get; set; }

        /// <summary>
        /// 向核心企业授信的配置id
        /// </summary>
        [XmlArray("credit_ids")]
        [XmlArrayItem("string")]
        public List<string> CreditIds { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// UTC标准格式
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 发票信息列表
        /// </summary>
        [XmlArray("invoice_list")]
        [XmlArrayItem("finance_invoice_info")]
        public List<FinanceInvoiceInfo> InvoiceList { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 核心企业角度的应收账款编号
        /// </summary>
        [XmlElement("out_asset_id")]
        public string OutAssetId { get; set; }

        /// <summary>
        /// 采购内容信息
        /// </summary>
        [XmlElement("purchase")]
        public FinancePurchaseInfo Purchase { get; set; }

        /// <summary>
        /// 供应商信息
        /// </summary>
        [XmlElement("supplier_info")]
        public FinanceMemberInfo SupplierInfo { get; set; }
    }
}
