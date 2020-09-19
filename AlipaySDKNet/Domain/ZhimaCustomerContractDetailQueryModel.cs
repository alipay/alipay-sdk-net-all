using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerContractDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerContractDetailQueryModel : AopObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 发约单号
        /// </summary>
        [XmlElement("offer_no")]
        public string OfferNo { get; set; }

        /// <summary>
        /// 主体id，一般是user_id
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }
    }
}
