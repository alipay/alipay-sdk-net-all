using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApiScheameOne Data Structure.
    /// </summary>
    [Serializable]
    public class ApiScheameOne : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("test_a")]
        public string TestA { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("test_b")]
        [XmlArrayItem("api_scheame_two")]
        public List<ApiScheameTwo> TestB { get; set; }
    }
}
