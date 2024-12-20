using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceEnergyaggrSubinviteQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceEnergyaggrSubinviteQueryModel : AopObject
    {
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
    }
}
