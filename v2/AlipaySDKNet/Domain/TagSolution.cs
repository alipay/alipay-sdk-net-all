using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TagSolution Data Structure.
    /// </summary>
    [Serializable]
    public class TagSolution : AopObject
    {
        /// <summary>
        /// 处理方案CODE
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 方案描叙
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否需要备注
        /// </summary>
        [XmlElement("need_notes")]
        public bool NeedNotes { get; set; }
    }
}
