using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationZftApplyresultSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationZftApplyresultSubmitModel : AopObject
    {
        /// <summary>
        /// 申请单创建时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 外部商户id
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 申请单处理失败时，通过此此段返回具体的失败理由；与kf_audit_memo和kz_audit_memo配合使用
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 风控审核状态。CREATE：已创建待审批、SKIP：跳过风控审批步骤、PASS：风控审核通过、REJECT：风控审批拒绝
        /// </summary>
        [XmlElement("fk_audit")]
        public string FkAudit { get; set; }

        /// <summary>
        /// 风控审批备注，如有则返回
        /// </summary>
        [XmlElement("fk_audit_memo")]
        public string FkAuditMemo { get; set; }

        /// <summary>
        /// 客资审核状态。CREATE：已创建待审批、SKIP：跳过客资审批步骤、PASS：客资审核通过、REJECT：客资审批拒绝
        /// </summary>
        [XmlElement("kz_audit")]
        public string KzAudit { get; set; }

        /// <summary>
        /// 客资审批备注，如有则返回
        /// </summary>
        [XmlElement("kz_audit_memo")]
        public string KzAuditMemo { get; set; }

        /// <summary>
        /// 直付通进件单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 二级商户id。当总体申请状态status为99时，smid才算进件完成
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 直付通进件结果,99:已完结;-1:失败;031:审核中
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 二级商户确认状态。CREATE：已发起二级商户确认、SKIP：无需确认、FAIL：签约失败、NOT_CONFIRM：商户未确认、FINISH签约完成
        /// </summary>
        [XmlElement("sub_confirm")]
        public string SubConfirm { get; set; }
    }
}
