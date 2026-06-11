using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfpartnerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalSfpartnerQueryModel : AopObject
    {
        /// <summary>
        /// 伙伴完整名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 伙伴名称，用于模糊查询
        /// </summary>
        [XmlElement("ep_name_keyword")]
        public string EpNameKeyword { get; set; }
    }
}
