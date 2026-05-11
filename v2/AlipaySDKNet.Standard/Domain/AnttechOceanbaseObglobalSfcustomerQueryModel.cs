using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfcustomerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalSfcustomerQueryModel : AopObject
    {
        /// <summary>
        /// 国家
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 完整客户名称
        /// </summary>
        [XmlElement("ep_full_name")]
        public string EpFullName { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }
    }
}
