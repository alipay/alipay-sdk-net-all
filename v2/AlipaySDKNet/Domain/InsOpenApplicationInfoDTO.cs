using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsOpenApplicationInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsOpenApplicationInfoDTO : AopObject
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [XmlElement("application_id")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [XmlElement("application_type")]
        public string ApplicationType { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
