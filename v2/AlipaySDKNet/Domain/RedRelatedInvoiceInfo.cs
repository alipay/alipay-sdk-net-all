using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RedRelatedInvoiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RedRelatedInvoiceInfo : AopObject
    {
        /// <summary>
        /// 原蓝票发票种类；红票可由原票快照补齐 81 数电专用增值税发票，82 数电普通发票
        /// </summary>
        [XmlElement("origin_invoice_kind")]
        public string OriginInvoiceKind { get; set; }

        /// <summary>
        /// 红票关联的原蓝票发票号码
        /// </summary>
        [XmlElement("origin_invoice_no")]
        public string OriginInvoiceNo { get; set; }

        /// <summary>
        /// 01 开票有误，02 销货退回，03 服务中止，04 销售折让
        /// </summary>
        [XmlElement("red_reason")]
        public string RedReason { get; set; }
    }
}
