using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScoreRangeInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ScoreRangeInfoDTO : AopObject
    {
        /// <summary>
        /// 最大品类卖力值，填写规则：0～100之间的整数或小数，小数位最多6位
        /// </summary>
        [XmlElement("category_score_max")]
        public string CategoryScoreMax { get; set; }

        /// <summary>
        /// 最小品类卖力值，填写规则：0～100之间的整数或小数，小数位最多6位
        /// </summary>
        [XmlElement("category_score_min")]
        public string CategoryScoreMin { get; set; }

        /// <summary>
        /// 最大热力值，填写规则：0～100之间的整数或小数，小数位最多6位
        /// </summary>
        [XmlElement("crowd_score_max")]
        public string CrowdScoreMax { get; set; }

        /// <summary>
        /// 最小热力值，填写规则：0～100之间的整数或小数，小数位最多6位
        /// </summary>
        [XmlElement("crowd_score_min")]
        public string CrowdScoreMin { get; set; }

        /// <summary>
        /// 热力值类型（多选一），用于热力值范围筛选，对应crowd_score_min和crowd_score_max范围
        /// </summary>
        [XmlElement("crowd_score_type")]
        public string CrowdScoreType { get; set; }

        /// <summary>
        /// 最大卖力值，填写规则：0～100之间的整数或小数，小数位最多6位
        /// </summary>
        [XmlElement("sale_score_max")]
        public string SaleScoreMax { get; set; }

        /// <summary>
        /// 最小卖力值，填写规则：0～100之间的整数或小数，小数位最多6位
        /// </summary>
        [XmlElement("sale_score_min")]
        public string SaleScoreMin { get; set; }
    }
}
