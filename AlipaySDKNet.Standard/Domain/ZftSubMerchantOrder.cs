using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZftSubMerchantOrder Data Structure.
    /// </summary>
    [Serializable]
    public class ZftSubMerchantOrder : AopObject
    {
        /// <summary>
        /// 申请单创建时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 本申请单的请求类型。一般可选值包括ZHIFUTONG_CONSULT（直付通商户预校验）/ZHIFUTONG_CREATE（直付通商户创建）/ZHIFUTONG_MODIFY（直付通商户修改）
        /// </summary>
        [XmlElement("apply_type")]
        public string ApplyType { get; set; }

        /// <summary>
        /// 进件生成的卡编号，在发起结算时可以作为结算账号
        /// </summary>
        [XmlElement("card_alias_no")]
        public string CardAliasNo { get; set; }

        /// <summary>
        /// 外部商户id
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

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
        /// 进件时填写的商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 二级商户id。当总体申请状态status为99时，smid才算进件完成
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 申请总体状态。99:已完结;-1:失败;031:审核中
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
