using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YunTaskRankStatistic Data Structure.
    /// </summary>
    [Serializable]
    public class YunTaskRankStatistic : AopObject
    {
        /// <summary>
        /// 排名（数字越小，排名越前）
        /// </summary>
        [XmlElement("biz_rank")]
        public long BizRank { get; set; }

        /// <summary>
        /// 业务值
        /// </summary>
        [XmlElement("biz_value")]
        public long BizValue { get; set; }

        /// <summary>
        /// 主体Id
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 排名主体类型
        /// </summary>
        [XmlElement("principal_type")]
        public string PrincipalType { get; set; }
    }
}
