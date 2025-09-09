using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePetMerchantarchiveDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePetMerchantarchiveDeleteModel : AopObject
    {
        /// <summary>
        /// 支付宝宠物档案Id
        /// </summary>
        [XmlElement("archive_id")]
        public string ArchiveId { get; set; }

        /// <summary>
        /// 商户宠物Id，与archive_id 二选一
        /// </summary>
        [XmlElement("external_pet_id")]
        public string ExternalPetId { get; set; }
    }
}
