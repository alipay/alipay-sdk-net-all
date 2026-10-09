using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitServingTarget Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitServingTarget : AopObject
    {
        /// <summary>
        /// 定向城市信息。
        /// </summary>
        [XmlElement("city")]
        public RecruitServingTargetCity City { get; set; }
    }
}
