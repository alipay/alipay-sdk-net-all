using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankCrowdInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankCrowdInfo : AopObject
    {
        /// <summary>
        /// 人群编码
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }

        /// <summary>
        /// 人群名称
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }
    }
}
