using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScoreDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ScoreDetailInfo : AopObject
    {
        /// <summary>
        /// 子维度分数
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 子维度编码
        /// </summary>
        [XmlElement("score_code")]
        public string ScoreCode { get; set; }

        /// <summary>
        /// 服务效果
        /// </summary>
        [XmlElement("score_name")]
        public string ScoreName { get; set; }
    }
}
