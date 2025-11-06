using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VaccinationHistory Data Structure.
    /// </summary>
    [Serializable]
    public class VaccinationHistory : AopObject
    {
        /// <summary>
        /// 疫苗名称
        /// </summary>
        [XmlElement("vaccines_name")]
        public string VaccinesName { get; set; }

        /// <summary>
        /// 接种日期
        /// </summary>
        [XmlElement("vaccines_time")]
        public string VaccinesTime { get; set; }
    }
}
