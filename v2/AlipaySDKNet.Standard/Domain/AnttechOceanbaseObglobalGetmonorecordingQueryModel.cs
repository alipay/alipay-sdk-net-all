using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalGetmonorecordingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalGetmonorecordingQueryModel : AopObject
    {
        /// <summary>
        /// 通话ID
        /// </summary>
        [XmlElement("contact_id")]
        public string ContactId { get; set; }
    }
}
