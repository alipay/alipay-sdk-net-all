using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAgentVersionDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAgentVersionDetailQueryModel : AopObject
    {
        /// <summary>
        /// 智能体开发包版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 智能体投放的客户端类型。支持如下客户端：支小宝、web服务
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }
    }
}
