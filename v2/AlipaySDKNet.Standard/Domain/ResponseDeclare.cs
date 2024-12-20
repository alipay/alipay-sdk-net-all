using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResponseDeclare Data Structure.
    /// </summary>
    [Serializable]
    public class ResponseDeclare : AopObject
    {
        /// <summary>
        /// 申报的目标运行负荷
        /// </summary>
        [XmlArray("target_adjustment")]
        [XmlArrayItem("load_info_node")]
        public List<LoadInfoNode> TargetAdjustment { get; set; }
    }
}
