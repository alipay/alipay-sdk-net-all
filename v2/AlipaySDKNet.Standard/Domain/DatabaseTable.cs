using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatabaseTable Data Structure.
    /// </summary>
    [Serializable]
    public class DatabaseTable : AopObject
    {
        /// <summary>
        /// 数据库名称
        /// </summary>
        [XmlElement("database_name")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// 表名称列表
        /// </summary>
        [XmlArray("table_name_list")]
        [XmlArrayItem("string")]
        public List<string> TableNameList { get; set; }
    }
}
