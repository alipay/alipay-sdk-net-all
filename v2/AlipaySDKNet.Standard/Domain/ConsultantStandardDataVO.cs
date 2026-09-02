using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsultantStandardDataVO Data Structure.
    /// </summary>
    [Serializable]
    public class ConsultantStandardDataVO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("percentile_data")]
        [XmlArrayItem("reference_data_item")]
        public List<ReferenceDataItem> PercentileData { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("special_data")]
        [XmlArrayItem("reference_data_item")]
        public List<ReferenceDataItem> SpecialData { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("thresholds")]
        [XmlArrayItem("reference_data_item")]
        public List<ReferenceDataItem> Thresholds { get; set; }
    }
}
