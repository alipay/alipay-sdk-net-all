using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysisoverviewPidtrendQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAnalysisoverviewPidtrendQueryModel : AopObject
    {
        /// <summary>
        /// 经营分析、经营概况模块公用入参
        /// </summary>
        [XmlElement("common_request")]
        public OpenApiAnalysisCommonRequest CommonRequest { get; set; }

        /// <summary>
        /// 商户pid，查看商户pid的趋势数据，pid必传。
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }
    }
}
