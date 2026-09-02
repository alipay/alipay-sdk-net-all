using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReverseContentData Data Structure.
    /// </summary>
    [Serializable]
    public class ReverseContentData : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("record_list")]
        [XmlArrayItem("record")]
        public List<Record> RecordList { get; set; }
    }
}
