using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseUserIdentityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseUserIdentityQueryModel : AopObject
    {
        /// <summary>
        /// 通行证id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }
    }
}
