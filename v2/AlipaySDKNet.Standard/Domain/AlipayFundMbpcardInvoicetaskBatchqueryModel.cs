using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundMbpcardInvoicetaskBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundMbpcardInvoicetaskBatchqueryModel : AopObject
    {
        /// <summary>
        /// 开始时间，格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("begin_date")]
        public string BeginDate { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 结束时间，格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 回票任务状态
        /// </summary>
        [XmlElement("invoice_task_status")]
        public string InvoiceTaskStatus { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页条数，最大值20
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
