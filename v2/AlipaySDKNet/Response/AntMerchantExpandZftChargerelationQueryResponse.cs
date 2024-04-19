using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandZftChargerelationQueryResponse.
    /// </summary>
    public class AntMerchantExpandZftChargerelationQueryResponse : AopResponse
    {
        /// <summary>
        /// 审核驳回原因
        /// </summary>
        [XmlElement("audit_memo")]
        public string AuditMemo { get; set; }

        /// <summary>
        /// orderId
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 申请单处理失败原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 记账方smid
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 申请单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 记账对手方smid
        /// </summary>
        [XmlElement("target_smid")]
        public string TargetSmid { get; set; }
    }
}
