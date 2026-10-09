using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaasEbankInstInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SaasEbankInstInfo : AopObject
    {
        /// <summary>
        /// 银行机构编码
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 银行机构LOGO图片URL，可用于对客展示机构列表
        /// </summary>
        [XmlElement("inst_logo_url")]
        public string InstLogoUrl { get; set; }

        /// <summary>
        /// 银行机构名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }
    }
}
