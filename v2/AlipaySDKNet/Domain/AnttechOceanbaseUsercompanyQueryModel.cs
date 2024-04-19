using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseUsercompanyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseUsercompanyQueryModel : AopObject
    {
        /// <summary>
        /// 通行证编码
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }
    }
}
