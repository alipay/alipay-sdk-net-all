using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicComptestCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicComptestCreateModel : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [XmlArray("string")]
        [XmlArrayItem("gavintest_new_levea_one")]
        public List<GavintestNewLeveaOne> String { get; set; }
    }
}
