using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopProofInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopProofInfo : AopObject
    {
        /// <summary>
        /// 授权材料图片
        /// </summary>
        [XmlElement("appeal_letter_url")]
        public string AppealLetterUrl { get; set; }

        /// <summary>
        /// 租赁合同图片
        /// </summary>
        [XmlElement("lease_contract_url")]
        public string LeaseContractUrl { get; set; }

        /// <summary>
        /// 产权证明图片
        /// </summary>
        [XmlElement("property_ownership_proof_url")]
        public string PropertyOwnershipProofUrl { get; set; }
    }
}
