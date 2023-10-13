using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceReimburseInfoOpenApiOrder Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceReimburseInfoOpenApiOrder : AopObject
    {
        /// <summary>
        /// 费用明细
        /// </summary>
        [XmlArray("account_info_order_list")]
        [XmlArrayItem("account_info_open_api_order")]
        public List<AccountInfoOpenApiOrder> AccountInfoOrderList { get; set; }

        /// <summary>
        /// 报销单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 报销行号
        /// </summary>
        [XmlElement("line_no")]
        public string LineNo { get; set; }

        /// <summary>
        /// 发票使用金额
        /// </summary>
        [XmlElement("use_amt")]
        public string UseAmt { get; set; }
    }
}
