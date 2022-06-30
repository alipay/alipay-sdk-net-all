using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NimitzColumn Data Structure.
    /// </summary>
    [Serializable]
    public class NimitzColumn : AopObject
    {
        /// <summary>
        /// 列数据
        /// </summary>
        [XmlArray("cells")]
        [XmlArrayItem("nimitz_cell")]
        public List<NimitzCell> Cells { get; set; }

        /// <summary>
        /// 列数据类型
        /// </summary>
        [XmlElement("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// 列名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
