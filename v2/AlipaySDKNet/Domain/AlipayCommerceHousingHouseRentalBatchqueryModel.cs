using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHousingHouseRentalBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHousingHouseRentalBatchqueryModel : AopObject
    {
        /// <summary>
        /// 小区id
        /// </summary>
        [XmlElement("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
