using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceProdtestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceProdtestQueryModel : AopObject
    {
        /// <summary>
        /// date测试
        /// </summary>
        [XmlElement("date_test")]
        public string DateTest { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("test_array")]
        [XmlArrayItem("api_scheame_one")]
        public List<ApiScheameOne> TestArray { get; set; }
    }
}
