using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TableSchema Data Structure.
    /// </summary>
    [Serializable]
    public class TableSchema : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("columns")]
        [XmlArrayItem("column_definition")]
        public List<ColumnDefinition> Columns { get; set; }

        /// <summary>
        /// 表注释
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
