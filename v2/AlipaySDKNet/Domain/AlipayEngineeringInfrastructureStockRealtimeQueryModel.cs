using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEngineeringInfrastructureStockRealtimeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEngineeringInfrastructureStockRealtimeQueryModel : AopObject
    {
        /// <summary>
        /// 查询天数
        /// </summary>
        [XmlElement("day")]
        public long Day { get; set; }

        /// <summary>
        /// 非必传。用于增量查询，表示需要 的最早的分时点时间。 当start小于最近day天的分时点的 最小时间时，start无效，返回最 近day天的分时点。 当start大禹最近day天的分时点的 最大时间时，返回分时点列表为 空。
        /// </summary>
        [XmlElement("start")]
        public string Start { get; set; }

        /// <summary>
        /// 标的代码
        /// </summary>
        [XmlElement("symbol")]
        public string Symbol { get; set; }
    }
}
