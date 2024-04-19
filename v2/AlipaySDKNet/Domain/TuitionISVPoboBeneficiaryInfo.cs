using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionISVPoboBeneficiaryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionISVPoboBeneficiaryInfo : AopObject
    {
        /// <summary>
        /// 收款人名称，留学场景下位学校名称，比如University of Oxford
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 网址、留学缴费VCC场景表示的是学校缴费网址
        /// </summary>
        [XmlElement("website")]
        public string Website { get; set; }
    }
}
