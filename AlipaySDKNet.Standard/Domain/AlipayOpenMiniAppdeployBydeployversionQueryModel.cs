using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAppdeployBydeployversionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAppdeployBydeployversionQueryModel : AopObject
    {
        /// <summary>
        /// 客户端标识
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 发布标识
        /// </summary>
        [XmlElement("deploy_version")]
        public string DeployVersion { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
