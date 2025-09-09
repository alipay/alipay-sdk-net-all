using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePetMerchantarchiveCreateResponse.
    /// </summary>
    public class AlipayCommercePetMerchantarchiveCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝宠物档案Id
        /// </summary>
        [XmlElement("archive_id")]
        public string ArchiveId { get; set; }
    }
}
