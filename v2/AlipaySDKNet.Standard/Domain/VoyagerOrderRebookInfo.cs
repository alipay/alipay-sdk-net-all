using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoyagerOrderRebookInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoyagerOrderRebookInfo : AopObject
    {
        /// <summary>
        /// 改签后人航段信息集合
        /// </summary>
        [XmlArray("after_rebook")]
        [XmlArrayItem("voyager_segment_of_passengers_info")]
        public List<VoyagerSegmentOfPassengersInfo> AfterRebook { get; set; }

        /// <summary>
        /// 改签前人航段信息集合
        /// </summary>
        [XmlArray("before_rebook")]
        [XmlArrayItem("voyager_segment_of_passengers_info")]
        public List<VoyagerSegmentOfPassengersInfo> BeforeRebook { get; set; }
    }
}
