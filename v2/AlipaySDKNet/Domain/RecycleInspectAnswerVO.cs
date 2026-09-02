using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleInspectAnswerVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleInspectAnswerVO : AopObject
    {
        /// <summary>
        /// 答案的类型
        /// </summary>
        [XmlElement("answer_type")]
        public string AnswerType { get; set; }

        /// <summary>
        /// 答案内容
        /// </summary>
        [XmlElement("answer_value")]
        public string AnswerValue { get; set; }

        /// <summary>
        /// 答案内容校验是否通过
        /// </summary>
        [XmlElement("check_pass")]
        public bool CheckPass { get; set; }

        /// <summary>
        /// 答案内容校验结果编码
        /// </summary>
        [XmlElement("check_result_code")]
        public string CheckResultCode { get; set; }

        /// <summary>
        /// 答案内容校验结果描述
        /// </summary>
        [XmlElement("check_result_msg")]
        public string CheckResultMsg { get; set; }
    }
}
