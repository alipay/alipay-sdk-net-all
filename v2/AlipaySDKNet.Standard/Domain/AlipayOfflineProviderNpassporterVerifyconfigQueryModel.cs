using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNpassporterVerifyconfigQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNpassporterVerifyconfigQueryModel : AopObject
    {
        /// <summary>
        /// 活动code
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 活动解决方案code
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }

        /// <summary>
        /// 核身配置Id
        /// </summary>
        [XmlElement("verify_config_id")]
        public string VerifyConfigId { get; set; }
    }
}
