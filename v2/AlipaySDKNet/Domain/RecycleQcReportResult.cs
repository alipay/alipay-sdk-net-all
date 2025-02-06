using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleQcReportResult Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleQcReportResult : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("image_id_list")]
        [XmlArrayItem("string")]
        public List<string> ImageIdList { get; set; }

        /// <summary>
        /// 文案
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
