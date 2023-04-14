using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppServicePromotemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServicePromotemplateQueryModel : AopObject
    {
        /// <summary>
        /// 展台ID
        /// </summary>
        [XmlElement("promo_booth_id")]
        public string PromoBoothId { get; set; }

        /// <summary>
        /// 展台版本
        /// </summary>
        [XmlElement("promo_booth_version")]
        public long PromoBoothVersion { get; set; }
    }
}
