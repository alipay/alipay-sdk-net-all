using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestPlantConsultResponse.
    /// </summary>
    public class AlipaySocialAntforestPlantConsultResponse : AopResponse
    {
        /// <summary>
        /// 当前账户可用能量
        /// </summary>
        [XmlElement("current_energy")]
        public long CurrentEnergy { get; set; }

        /// <summary>
        /// 项目是否可兑换
        /// </summary>
        [XmlElement("project_alliable")]
        public bool ProjectAlliable { get; set; }
    }
}
