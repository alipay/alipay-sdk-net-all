using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ManjiangTestComplexOneData Data Structure.
    /// </summary>
    [Serializable]
    public class ManjiangTestComplexOneData : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sss")]
        public string Sss { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ssssd")]
        public long Ssssd { get; set; }

        /// <summary>
        /// 4
        /// </summary>
        [XmlElement("test_level_one")]
        public string TestLevelOne { get; set; }
    }
}
