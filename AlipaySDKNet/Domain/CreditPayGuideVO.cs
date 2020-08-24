using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditPayGuideVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayGuideVO : AopObject
    {
        /// <summary>
        /// json字符串，表示引导信息
        /// </summary>
        [XmlElement("guide_param")]
        public string GuideParam { get; set; }

        /// <summary>
        /// 是否需要引导
        /// </summary>
        [XmlElement("need_guide")]
        public bool NeedGuide { get; set; }
    }
}
