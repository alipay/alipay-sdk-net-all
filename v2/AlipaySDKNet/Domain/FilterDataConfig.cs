using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FilterDataConfig Data Structure.
    /// </summary>
    [Serializable]
    public class FilterDataConfig : AopObject
    {
        /// <summary>
        /// 条件数据列表
        /// </summary>
        [XmlArray("options")]
        [XmlArrayItem("filter_child_data_config")]
        public List<FilterChildDataConfig> Options { get; set; }
    }
}
