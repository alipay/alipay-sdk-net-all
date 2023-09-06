using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestEggypartyQueryResponse.
    /// </summary>
    public class AlipaySocialAntforestEggypartyQueryResponse : AopResponse
    {
        /// <summary>
        /// 公益林用户总浇水能量克数
        /// </summary>
        [XmlElement("total_water_energy")]
        public string TotalWaterEnergy { get; set; }

        /// <summary>
        /// 公益林总浇水次数
        /// </summary>
        [XmlElement("total_water_times")]
        public string TotalWaterTimes { get; set; }
    }
}
