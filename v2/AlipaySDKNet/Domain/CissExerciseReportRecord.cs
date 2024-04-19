using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CissExerciseReportRecord Data Structure.
    /// </summary>
    [Serializable]
    public class CissExerciseReportRecord : AopObject
    {
        /// <summary>
        /// 测试项评估
        /// </summary>
        [XmlElement("evaluate")]
        public string Evaluate { get; set; }

        /// <summary>
        /// 测试项级别
        /// </summary>
        [XmlElement("grade")]
        public string Grade { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 项目code，100表示总分
        /// </summary>
        [XmlElement("item_code")]
        public long ItemCode { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 测试项得分
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 测试项结果
        /// </summary>
        [XmlElement("test_value")]
        public string TestValue { get; set; }

        /// <summary>
        /// 测试值单位
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
