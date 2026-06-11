using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceTpapreauthstatusNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceTpapreauthstatusNotifyModel : AopObject
    {
        /// <summary>
        /// 押金额度,单位,元,人民币
        /// </summary>
        [XmlElement("deposit_amount")]
        public string DepositAmount { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 支付宝用户的唯一ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 预授权申请单号
        /// </summary>
        [XmlElement("pre_auth_audit_status")]
        public string PreAuthAuditStatus { get; set; }

        /// <summary>
        /// 预授权申请单号
        /// </summary>
        [XmlElement("pre_auth_audit_status_msg")]
        public string PreAuthAuditStatusMsg { get; set; }

        /// <summary>
        /// 预授权申请单号
        /// </summary>
        [XmlElement("pre_auth_no")]
        public string PreAuthNo { get; set; }

        /// <summary>
        /// 单位：元，保留2位小数
        /// </summary>
        [XmlElement("pre_auth_quota")]
        public string PreAuthQuota { get; set; }

        /// <summary>
        /// 垫资方
        /// </summary>
        [XmlElement("tpa_id")]
        public string TpaId { get; set; }

        /// <summary>
        /// 支付宝用户的唯一ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
