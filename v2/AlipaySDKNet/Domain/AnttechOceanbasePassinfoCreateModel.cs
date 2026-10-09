using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbasePassinfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbasePassinfoCreateModel : AopObject
    {
        /// <summary>
        /// 通行证id，用户UID
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }
    }
}
