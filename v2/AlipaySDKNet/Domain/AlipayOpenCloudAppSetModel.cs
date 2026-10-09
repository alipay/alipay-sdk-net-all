using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenCloudAppSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenCloudAppSetModel : AopObject
    {
        /// <summary>
        /// 环境调用状态
        /// </summary>
        [XmlElement("cloud_call_status")]
        public string CloudCallStatus { get; set; }

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
        /// 云环境中调用的应用ID
        /// </summary>
        [XmlElement("invoke_app_id")]
        public string InvokeAppId { get; set; }
    }
}
