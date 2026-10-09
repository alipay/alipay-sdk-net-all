using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTransferConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTransferConsultModel : AopObject
    {
        /// <summary>
        /// 汇款相关信息
        /// </summary>
        [XmlElement("additional_transfer_details")]
        public string AdditionalTransferDetails { get; set; }

        /// <summary>
        /// 收端用户收款的方式
        /// </summary>
        [XmlElement("beneficiary_receipt_method")]
        public string BeneficiaryReceiptMethod { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_scene_type")]
        public string BizSceneType { get; set; }

        /// <summary>
        /// 透传信息
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 发端机构id
        /// </summary>
        [XmlElement("payer_agent_id")]
        public string PayerAgentId { get; set; }

        /// <summary>
        /// 汇出金额
        /// </summary>
        [XmlElement("transfer_to_amount")]
        public Money TransferToAmount { get; set; }
    }
}
