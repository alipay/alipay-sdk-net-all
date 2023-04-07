using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenCloudAppQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenCloudAppQueryModel : AopObject
    {
        /// <summary>
        /// 云id
        /// </summary>
        [XmlElement("cloud_id")]
        public string CloudId { get; set; }

        /// <summary>
        /// 云环境id
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [XmlElement("invoke_app_id")]
        public string InvokeAppId { get; set; }
    }
}
