using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceTparecoverySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceTparecoverySyncModel : AopObject
    {
        /// <summary>
        /// 单位：元，保留2位小数。
        /// </summary>
        [XmlElement("balance_recovery_amount")]
        public string BalanceRecoveryAmount { get; set; }

        /// <summary>
        /// 是否需要进行差额追缴
        /// </summary>
        [XmlElement("balance_recovery_required")]
        public bool BalanceRecoveryRequired { get; set; }

        /// <summary>
        /// claim_no
        /// </summary>
        [XmlElement("claim_no")]
        public string ClaimNo { get; set; }

        /// <summary>
        /// 保司类型
        /// </summary>
        [XmlElement("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// 支付宝用户的唯一ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// WINDSTONE（风石）
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
