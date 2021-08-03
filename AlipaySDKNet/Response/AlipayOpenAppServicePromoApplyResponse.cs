using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppServicePromoApplyResponse.
    /// </summary>
    public class AlipayOpenAppServicePromoApplyResponse : AopResponse
    {
        /// <summary>
        /// 服务场景素材记录ID
        /// </summary>
        [XmlElement("promo_record_id")]
        public string PromoRecordId { get; set; }
    }
}
