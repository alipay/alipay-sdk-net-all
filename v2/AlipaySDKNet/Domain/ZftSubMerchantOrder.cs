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
        /// 是否开通线上预授权
        /// </summary>
        [XmlElement("app_pre_auth")]
        public string AppPreAuth { get; set; }

        /// <summary>
        /// 申请单创建时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 本申请单的请求类型。
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
        /// 是否开通线下预授权
        /// </summary>
        [XmlElement("face_pre_auth")]
        public string FacePreAuth { get; set; }

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
        /// 判断个人当面付权限版本，返回TRUE时表示是标准版，返回FALSE表示受限版
        /// </summary>
        [XmlElement("is_face_limit")]
        public string IsFaceLimit { get; set; }

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
        /// 申请单处理失败时，通过此此段返回具体的失败理由；与kf_audit_memo和kz_audit_memo配合使用
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 签约支付宝账号（脱敏）
        /// </summary>
        [XmlElement("safe_binding_logon_id")]
        public string SafeBindingLogonId { get; set; }

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

        /// <summary>
        /// 在快速进件场景下要求二级商户自助签约确认，通过此链接展示的二维码扫码进入支付宝小程序。（仅quickcreate接口返回）
        /// </summary>
        [XmlElement("sub_sign_qr_code_url")]
        public string SubSignQrCodeUrl { get; set; }

        /// <summary>
        /// 页面跳转的短链接，用于二级商户完成签约确认，可以支持平台商发送此短链接给二级商户，通过链接跳转的方式进入支付宝小程序完成确认。（仅quickcreate接口返回）
        /// </summary>
        [XmlElement("sub_sign_short_chain_url")]
        public string SubSignShortChainUrl { get; set; }
    }
}
