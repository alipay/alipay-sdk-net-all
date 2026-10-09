using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockGrayTrafficCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockGrayTrafficCheckModel : AopObject
    {
        /// <summary>
        /// 实际发往灰度环境的组件/应用名清单，由发布单各组件所选发布环境推得
        /// </summary>
        [XmlArray("applications")]
        [XmlArrayItem("string")]
        public List<string> Applications { get; set; }

        /// <summary>
        /// 机构标识
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }
    }
}
