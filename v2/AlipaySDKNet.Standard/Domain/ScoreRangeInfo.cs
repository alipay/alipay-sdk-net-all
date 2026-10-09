using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScoreRangeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ScoreRangeInfo : AopObject
    {
        /// <summary>
        /// 最大品类卖力值范围区间，对应0-100分
        /// </summary>
        [XmlElement("category_score_max")]
        public long CategoryScoreMax { get; set; }

        /// <summary>
        /// 最小品类卖力值范围区间，对应0-100分
        /// </summary>
        [XmlElement("category_score_min")]
        public long CategoryScoreMin { get; set; }

        /// <summary>
        /// 最大热力值范围区间，对应0-100分
        /// </summary>
        [XmlElement("crowd_score_max")]
        public long CrowdScoreMax { get; set; }

        /// <summary>
        /// 最小热力值范围区间，对应0-100分
        /// </summary>
        [XmlElement("crowd_score_min")]
        public long CrowdScoreMin { get; set; }

        /// <summary>
        /// 热力值类型（多选一），用于热力值范围筛选，对应crowd_score_min和crowd_score_max范围
        /// </summary>
        [XmlElement("crowd_score_type")]
        public string CrowdScoreType { get; set; }

        /// <summary>
        /// 最大卖力值范围区间，对应0-100分
        /// </summary>
        [XmlElement("sale_score_max")]
        public long SaleScoreMax { get; set; }

        /// <summary>
        /// 最小卖力值范围区间，对应0-100分
        /// </summary>
        [XmlElement("sale_score_min")]
        public long SaleScoreMin { get; set; }
    }
}
