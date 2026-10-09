using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppServicePromoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServicePromoQueryModel : AopObject
    {
        /// <summary>
        /// 服务场景素材记录ID
        /// </summary>
        [XmlElement("promo_record_id")]
        public string PromoRecordId { get; set; }
    }
}
