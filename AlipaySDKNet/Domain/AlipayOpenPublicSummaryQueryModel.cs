using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicSummaryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicSummaryQueryModel : AopObject
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 上架：ON_LINE,下架：OFF_LINE，为空时查询全部
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
