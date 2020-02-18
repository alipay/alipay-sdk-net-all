using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenDesCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenDesCreateModel : AopObject
    {
        /// <summary>
        /// 21
        /// </summary>
        [XmlArray("des")]
        [XmlArrayItem("gavintest_new_levea_one")]
        public List<GavintestNewLeveaOne> Des { get; set; }

        /// <summary>
        /// 订单
        /// </summary>
        [XmlArray("test")]
        [XmlArrayItem("boolean")]
        public List<bool> Test { get; set; }
    }
}
