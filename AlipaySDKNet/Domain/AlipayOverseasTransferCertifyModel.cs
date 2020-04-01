using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTransferCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTransferCertifyModel : AopObject
    {
        /// <summary>
        /// 收端用户信息
        /// </summary>
        [XmlElement("beneficiary")]
        public string Beneficiary { get; set; }

        /// <summary>
        /// 收端机构的id
        /// </summary>
        [XmlElement("beneficiary_agent_id")]
        public string BeneficiaryAgentId { get; set; }

        /// <summary>
        /// 收款方式
        /// </summary>
        [XmlElement("beneficiary_receipt_method")]
        public string BeneficiaryReceiptMethod { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_scene_type")]
        public string BizSceneType { get; set; }

        /// <summary>
        /// 金额类型
        /// </summary>
        [XmlElement("instructed_amount_type")]
        public string InstructedAmountType { get; set; }

        /// <summary>
        /// 透传信息
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 发端用户信息
        /// </summary>
        [XmlElement("payer")]
        public string Payer { get; set; }

        /// <summary>
        /// 发端机构的id
        /// </summary>
        [XmlElement("payer_agent_id")]
        public string PayerAgentId { get; set; }

        /// <summary>
        /// 汇款的金额
        /// </summary>
        [XmlElement("transfer_from_amount")]
        public Money TransferFromAmount { get; set; }

        /// <summary>
        /// HK
        /// </summary>
        [XmlElement("transfer_from_region")]
        public string TransferFromRegion { get; set; }

        /// <summary>
        /// 收款的金额
        /// </summary>
        [XmlElement("transfer_to_amount")]
        public Money TransferToAmount { get; set; }

        /// <summary>
        /// 收款地区
        /// </summary>
        [XmlElement("transfer_to_region")]
        public string TransferToRegion { get; set; }
    }
}
