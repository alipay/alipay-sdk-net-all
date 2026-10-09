using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAgreementMigrateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAgreementMigrateModel : AopObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 需要迁移的目标商户应用id
        /// </summary>
        [XmlElement("target_app_id")]
        public string TargetAppId { get; set; }

        /// <summary>
        /// 需要迁移的目标商户调用应用id
        /// </summary>
        [XmlElement("target_invoke_app_id")]
        public string TargetInvokeAppId { get; set; }

        /// <summary>
        /// 需要迁移的目标商户id
        /// </summary>
        [XmlElement("target_partner_id")]
        public string TargetPartnerId { get; set; }
    }
}
