using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ColumnData Data Structure.
    /// </summary>
    [Serializable]
    public class ColumnData : AopObject
    {
        /// <summary>
        /// 该类型表示一整行数据，为字符串列表。 columns 在修改数据时使用，表示该类型表示一整行数据，具体值为字符串列表，用户传入参数时自定义具体的内容，表示删除的数据时要和已有的数据保持一致。
        /// </summary>
        [XmlArray("columns")]
        [XmlArrayItem("string")]
        public List<string> Columns { get; set; }
    }
}
