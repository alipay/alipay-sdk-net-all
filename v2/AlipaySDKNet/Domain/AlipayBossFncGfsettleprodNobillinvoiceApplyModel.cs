using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodNobillinvoiceApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodNobillinvoiceApplyModel : AopObject
    {
        /// <summary>
        /// 指定的审批人员，值为审批人员的域账号
        /// </summary>
        [XmlElement("audit_staff")]
        public string AuditStaff { get; set; }

        /// <summary>
        /// 调用方身份识别标记(应用名称) 与业务单据号(biz_no)联合唯一
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务单据号 必填
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 指定发票后续是否可以关联账单 Y:可以 N：不可以
        /// </summary>
        [XmlElement("can_link")]
        public string CanLink { get; set; }

        /// <summary>
        /// 销方OU的instId
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 发票行
        /// </summary>
        [XmlArray("invoice_line_list")]
        [XmlArrayItem("invoice_line_info_order")]
        public List<InvoiceLineInfoOrder> InvoiceLineList { get; set; }

        /// <summary>
        /// 发票介质 01:电子；02：纸质
        /// </summary>
        [XmlElement("invoice_material")]
        public string InvoiceMaterial { get; set; }

        /// <summary>
        /// 票面备注 该内容会原样展示到发票上
        /// </summary>
        [XmlElement("invoice_note")]
        public string InvoiceNote { get; set; }

        /// <summary>
        /// 发票类型 01：专票； 02：普票
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 申请开票的原因如：客户账单调整中先通过无账单开出； 在审批的时候能够看见
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 操作人的域账号，创建流程单使用
        /// </summary>
        [XmlElement("operator_domain_name")]
        public string OperatorDomainName { get; set; }

        /// <summary>
        /// 申请开票方式 01:系统；02：手工 如无特殊情况请传02
        /// </summary>
        [XmlElement("order_way")]
        public string OrderWay { get; set; }

        /// <summary>
        /// 购方信息
        /// </summary>
        [XmlElement("user_invoice_info")]
        public UserInvoiceInfoOrder UserInvoiceInfo { get; set; }
    }
}
