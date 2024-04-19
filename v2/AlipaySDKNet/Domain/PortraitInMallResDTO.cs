using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PortraitInMallResDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PortraitInMallResDTO : AopObject
    {
        /// <summary>
        /// 居住人口
        /// </summary>
        [XmlElement("live_user")]
        public PopulationDTO LiveUser { get; set; }

        /// <summary>
        /// 常驻人口
        /// </summary>
        [XmlElement("settled_user")]
        public PopulationDTO SettledUser { get; set; }

        /// <summary>
        /// 工作人口
        /// </summary>
        [XmlElement("work_user")]
        public PopulationDTO WorkUser { get; set; }
    }
}
