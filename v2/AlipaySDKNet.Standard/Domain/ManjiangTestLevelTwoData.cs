using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ManjiangTestLevelTwoData Data Structure.
    /// </summary>
    [Serializable]
    public class ManjiangTestLevelTwoData : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("open_json")]
        public string OpenJson { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_comple_2")]
        public ManjiangTestComplexOneData TestComple2 { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("tets_level_2")]
        public string TetsLevel2 { get; set; }
    }
}
