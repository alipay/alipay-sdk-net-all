using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceEnergyaggrInvitedeclareApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceEnergyaggrInvitedeclareApplyModel : AopObject
    {
        /// <summary>
        /// 是否需要申报
        /// </summary>
        [XmlElement("declare_flag")]
        public bool DeclareFlag { get; set; }

        /// <summary>
        /// 产品合约码
        /// </summary>
        [XmlElement("product_agreement_code")]
        public string ProductAgreementCode { get; set; }

        /// <summary>
        /// 子邀约ID
        /// </summary>
        [XmlElement("sub_invite_id")]
        public string SubInviteId { get; set; }

        /// <summary>
        /// 申报目标调节负荷
        /// </summary>
        [XmlArray("target_adjustment")]
        [XmlArrayItem("load_info_node")]
        public List<LoadInfoNode> TargetAdjustment { get; set; }
    }
}
