using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignSeriesappcompilationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdcampaignSeriesappcompilationQueryModel : AopObject
    {
        /// <summary>
        /// 营销目标编码;缺失透传 null(Service 内按默认 status=0 处理) 
        /// </summary>
        [XmlElement("market_target_code")]
        public string MarketTargetCode { get; set; }

        /// <summary>
        /// 委托人 ID;非法值→SYSTEM_ERROR
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("series_app_id")]
        public string SeriesAppId { get; set; }
    }
}
