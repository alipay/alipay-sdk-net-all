using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncInvoiceReturnorderBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInvoiceReturnorderBatchqueryModel : AopObject
    {
        /// <summary>
        /// 发票申请日期【起始日期，格式yyyyMMdd】
        /// </summary>
        [XmlElement("apply_date_begin")]
        public string ApplyDateBegin { get; set; }

        /// <summary>
        /// 发票申请日期【结束日期，格式yyyyMMdd】
        /// </summary>
        [XmlElement("apply_date_end")]
        public string ApplyDateEnd { get; set; }

        /// <summary>
        /// 机构(OU)
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票开票日期【起始日期，格式yyyyMMdd】
        /// </summary>
        [XmlElement("invoice_open_date_begin")]
        public string InvoiceOpenDateBegin { get; set; }

        /// <summary>
        /// 发票开票日期【结束日期，格式yyyyMMdd】
        /// </summary>
        [XmlElement("invoice_open_date_end")]
        public string InvoiceOpenDateEnd { get; set; }

        /// <summary>
        /// 发票类型,01专票 02普票 04国际形式发票 05其它发票
        /// </summary>
        [XmlArray("invoice_types")]
        [XmlArrayItem("string")]
        public List<string> InvoiceTypes { get; set; }

        /// <summary>
        /// 结算对象ipid，和主站mid一致
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 结算对象角色ID，和主站pid一致
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 申请编号列表
        /// </summary>
        [XmlArray("order_nos")]
        [XmlArrayItem("string")]
        public List<string> OrderNos { get; set; }

        /// <summary>
        /// 申请状态,01:待审核 02:已撤销 03:审核通过处理中 04:等待资料补全中 05:审核驳回 06:退票已完成 07:重新开票中 08:已重新开票
        /// </summary>
        [XmlArray("order_status")]
        [XmlArrayItem("string")]
        public List<string> OrderStatus { get; set; }

        /// <summary>
        /// 退换票类型,01:退票 02:换票
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 查询第几页
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 查询一页的条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 退换票原因类型
        /// </summary>
        [XmlArray("return_reason_types")]
        [XmlArrayItem("string")]
        public List<string> ReturnReasonTypes { get; set; }

        /// <summary>
        /// 查询来源,建议系统名加模块名
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("tracking_no")]
        public string TrackingNo { get; set; }
    }
}
