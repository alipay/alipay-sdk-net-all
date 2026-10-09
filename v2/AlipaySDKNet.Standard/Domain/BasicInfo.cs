using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BasicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BasicInfo : AopObject
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [XmlElement("age")]
        public long Age { get; set; }

        /// <summary>
        /// 面试完成时间
        /// </summary>
        [XmlElement("completed_time")]
        public string CompletedTime { get; set; }

        /// <summary>
        /// 完成方式
        /// </summary>
        [XmlElement("completed_type")]
        public string CompletedType { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("id_card")]
        public string IdCard { get; set; }

        /// <summary>
        /// 面试时长（秒）
        /// </summary>
        [XmlElement("interview_duration")]
        public string InterviewDuration { get; set; }

        /// <summary>
        /// 候选人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 岗位名称
        /// </summary>
        [XmlElement("position_name")]
        public string PositionName { get; set; }
    }
}
