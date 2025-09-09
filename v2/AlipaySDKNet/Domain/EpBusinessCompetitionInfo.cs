using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpBusinessCompetitionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpBusinessCompetitionInfo : AopObject
    {
        /// <summary>
        /// 线索来源
        /// </summary>
        [XmlElement("clue_source")]
        public string ClueSource { get; set; }

        /// <summary>
        /// 招投标公告数
        /// </summary>
        [XmlElement("clue_total")]
        public long ClueTotal { get; set; }

        /// <summary>
        /// 经营状态
        /// </summary>
        [XmlElement("manager_state")]
        public string ManagerState { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 注册资本
        /// </summary>
        [XmlElement("register_capital")]
        public string RegisterCapital { get; set; }

        /// <summary>
        /// 成立日期
        /// </summary>
        [XmlElement("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 识别关系
        /// </summary>
        [XmlElement("relation")]
        public string Relation { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("tyshxydm")]
        public string Tyshxydm { get; set; }
    }
}
