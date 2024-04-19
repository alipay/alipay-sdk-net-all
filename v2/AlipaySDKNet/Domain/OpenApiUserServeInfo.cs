using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiUserServeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiUserServeInfo : AopObject
    {
        /// <summary>
        /// 人员等级
        /// </summary>
        [XmlElement("ability_grade")]
        public string AbilityGrade { get; set; }

        /// <summary>
        /// 并发数
        /// </summary>
        [XmlElement("service_capacity")]
        public long ServiceCapacity { get; set; }
    }
}
