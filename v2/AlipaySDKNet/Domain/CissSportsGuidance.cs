using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CissSportsGuidance Data Structure.
    /// </summary>
    [Serializable]
    public class CissSportsGuidance : AopObject
    {
        /// <summary>
        /// 注意事项
        /// </summary>
        [XmlElement("attention")]
        public string Attention { get; set; }

        /// <summary>
        /// 练习强度
        /// </summary>
        [XmlElement("exercise_intensity")]
        public string ExerciseIntensity { get; set; }

        /// <summary>
        /// 练习要点
        /// </summary>
        [XmlElement("exercise_points")]
        public string ExercisePoints { get; set; }

        /// <summary>
        /// 练习名称
        /// </summary>
        [XmlElement("exercise_type")]
        public string ExerciseType { get; set; }

        /// <summary>
        /// 运动类型ID
        /// </summary>
        [XmlElement("exercise_type_id")]
        public string ExerciseTypeId { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
