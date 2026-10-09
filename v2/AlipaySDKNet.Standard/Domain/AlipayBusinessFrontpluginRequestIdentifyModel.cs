using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBusinessFrontpluginRequestIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessFrontpluginRequestIdentifyModel : AopObject
    {
        /// <summary>
        /// 操作用户登录账号
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作用户主账号
        /// </summary>
        [XmlElement("operator_master_id")]
        public string OperatorMasterId { get; set; }

        /// <summary>
        /// 操作用户类型
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 前端插件输入参数
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 前端插件唯一标识ID
        /// </summary>
        [XmlElement("plugin_id")]
        public string PluginId { get; set; }

        /// <summary>
        /// 服务唯一标识ID
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
