using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpscerthostingDomainproviderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseHttpscerthostingDomainproviderQueryModel : AopObject
    {
        /// <summary>
        /// 小程序云APPID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 小程序云ENVID
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }
    }
}
