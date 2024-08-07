using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePetMerchantarchiveQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePetMerchantarchiveQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝宠物档案Id, 与external_pet_id 二选一
        /// </summary>
        [XmlElement("archive_id")]
        public string ArchiveId { get; set; }

        /// <summary>
        /// 商户宠物Id
        /// </summary>
        [XmlElement("external_pet_id")]
        public string ExternalPetId { get; set; }
    }
}
