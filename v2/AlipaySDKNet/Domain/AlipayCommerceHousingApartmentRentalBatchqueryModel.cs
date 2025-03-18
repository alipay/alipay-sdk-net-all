using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHousingApartmentRentalBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHousingApartmentRentalBatchqueryModel : AopObject
    {
        /// <summary>
        /// 公寓id
        /// </summary>
        [XmlElement("apartment_id")]
        public string ApartmentId { get; set; }

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
