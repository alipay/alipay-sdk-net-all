using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAgentVersionPreviewModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAgentVersionPreviewModel : AopObject
    {
        /// <summary>
        /// 智能体版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 智能体投放的客户端类型。支持如下客户端：支小宝、web服务
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 包含体验、正式二个参数枚举值可选
        /// </summary>
        [XmlElement("environment")]
        public string Environment { get; set; }
    }
}
