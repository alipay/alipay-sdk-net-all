using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApprovalTripDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApprovalTripDTO : AopObject
    {
        /// <summary>
        /// 行程对应到达日期
        /// </summary>
        [XmlElement("apply_finish_time")]
        public string ApplyFinishTime { get; set; }

        /// <summary>
        /// 行程对应出发日期
        /// </summary>
        [XmlElement("apply_start_time")]
        public string ApplyStartTime { get; set; }

        /// <summary>
        /// 目的地城市信息
        /// </summary>
        [XmlElement("destination")]
        public ApprovalCityDTO Destination { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        [XmlElement("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 出发地城市信息
        /// </summary>
        [XmlElement("origin")]
        public ApprovalCityDTO Origin { get; set; }

        /// <summary>
        /// 行程模式，可选值： PLANE-飞机； TRAIN-火车； HOTEL-酒店
        /// </summary>
        [XmlElement("trip_mode")]
        public string TripMode { get; set; }

        /// <summary>
        /// 行程类型，可选值： 单程：SINGLE； 往返：RETURN； 多程：MULTI； 默认为 SINGLE
        /// </summary>
        [XmlElement("trip_way")]
        public string TripWay { get; set; }
    }
}
