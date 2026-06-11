using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalActivityModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalActivityModifyModel : AopObject
    {
        /// <summary>
        /// 活动信息
        /// </summary>
        [XmlElement("activity_desc")]
        public string ActivityDesc { get; set; }
    }
}
