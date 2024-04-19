using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundMbpcardInvoiceprocessModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundMbpcardInvoiceprocessModifyModel : AopObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 待修改的发票列表
        /// </summary>
        [XmlArray("invoice_list")]
        [XmlArrayItem("invoice_base_info")]
        public List<InvoiceBaseInfo> InvoiceList { get; set; }

        /// <summary>
        /// 回票商户的ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 指定需要修改的流程ID
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
