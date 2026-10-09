using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePetMerchantarchiveQueryResponse.
    /// </summary>
    public class AlipayCommercePetMerchantarchiveQueryResponse : AopResponse
    {
        /// <summary>
        /// 档案详情
        /// </summary>
        [XmlElement("pet_archive_info")]
        public IndustryPetArchiveDTO PetArchiveInfo { get; set; }
    }
}
