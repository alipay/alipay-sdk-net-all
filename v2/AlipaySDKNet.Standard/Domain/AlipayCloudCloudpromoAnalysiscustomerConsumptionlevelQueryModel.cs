using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysiscustomerConsumptionlevelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAnalysiscustomerConsumptionlevelQueryModel : AopObject
    {
        /// <summary>
        /// 经营分析、经营概况模块公用入参
        /// </summary>
        [XmlElement("common_request")]
        public OpenApiAnalysisCommonRequest CommonRequest { get; set; }

        /// <summary>
        /// 消费层级区间粒度，用于查看各个层级的消费数据和占比
        /// </summary>
        [XmlElement("trade_level_granularity")]
        public string TradeLevelGranularity { get; set; }
    }
}
