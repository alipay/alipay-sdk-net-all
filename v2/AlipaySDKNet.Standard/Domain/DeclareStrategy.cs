using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeclareStrategy Data Structure.
    /// </summary>
    [Serializable]
    public class DeclareStrategy : AopObject
    {
        /// <summary>
        /// 建议调节量
        /// </summary>
        [XmlArray("declare_adjustment")]
        [XmlArrayItem("load_info_node")]
        public List<LoadInfoNode> DeclareAdjustment { get; set; }

        /// <summary>
        /// 建议申报负荷
        /// </summary>
        [XmlArray("declare_load")]
        [XmlArrayItem("load_info_node")]
        public List<LoadInfoNode> DeclareLoad { get; set; }
    }
}
