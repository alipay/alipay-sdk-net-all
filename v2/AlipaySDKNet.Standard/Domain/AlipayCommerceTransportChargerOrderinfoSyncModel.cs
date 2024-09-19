using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerOrderinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerOrderinfoSyncModel : AopObject
    {
        /// <summary>
        /// 订单详情信息
        /// </summary>
        [XmlElement("site_charger_order")]
        public SiteChargerOrderDTO SiteChargerOrder { get; set; }
    }
}
