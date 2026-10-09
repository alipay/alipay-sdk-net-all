using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LinkTypeListResult Data Structure.
    /// </summary>
    [Serializable]
    public class LinkTypeListResult : AopObject
    {
        /// <summary>
        /// 环节类型信息
        /// </summary>
        [XmlArray("link_type_list")]
        [XmlArrayItem("link_type_result")]
        public List<LinkTypeResult> LinkTypeList { get; set; }
    }
}
