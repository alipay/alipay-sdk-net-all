using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ArInvoiceReturnOrderOpenApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ArInvoiceReturnOrderOpenApiResponse : AopObject
    {
        /// <summary>
        /// 退换票详情信息
        /// </summary>
        [XmlArray("ar_invoice_return_order_details")]
        [XmlArrayItem("ar_invoice_return_order_detail_open_api_response")]
        public List<ArInvoiceReturnOrderDetailOpenApiResponse> ArInvoiceReturnOrderDetails { get; set; }

        /// <summary>
        /// 申请人,标识是谁申请的,客户的pid或者小二的花名或者工号
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 结算对象ipid-主站为mid
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 结算对象角色id-主站为pid
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 最近修改人,标识是谁修改的,客户的pid或者小二的花名或者工号
        /// </summary>
        [XmlElement("last_moder")]
        public string LastModer { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 修改项
        /// </summary>
        [XmlElement("modified_item")]
        public string ModifiedItem { get; set; }

        /// <summary>
        /// 申请渠道,01:商户 02:小二
        /// </summary>
        [XmlElement("order_channel")]
        public string OrderChannel { get; set; }

        /// <summary>
        /// 申请编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 申请状态,01:待审核 02:已撤销 03:审核通过处理中 04:等待资料补全中 05:审核驳回 06:退票已完成 07:重新开票中 08:已重新开票
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 退换票类型,01:退票 02:换票
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 审批工单号
        /// </summary>
        [XmlElement("process_instance_id")]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// 换票时，是否需要重开发票 true 需要, false 不需要,退票时，null
        /// </summary>
        [XmlElement("re_invoice")]
        public bool ReInvoice { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 退换票原因类型; 01:发票介质修改; 02发票类型修改; 03:发票信息修改; 05:其他; 06:不需要发票;
        /// </summary>
        [XmlElement("return_reason_type")]
        public string ReturnReasonType { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("tracking_no")]
        public string TrackingNo { get; set; }
    }
}
