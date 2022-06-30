using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NimitzTable Data Structure.
    /// </summary>
    [Serializable]
    public class NimitzTable : AopObject
    {
        /// <summary>
        /// Nimitz 数据列
        /// </summary>
        [XmlArray("columns")]
        [XmlArrayItem("nimitz_column")]
        public List<NimitzColumn> Columns { get; set; }
    }
}
