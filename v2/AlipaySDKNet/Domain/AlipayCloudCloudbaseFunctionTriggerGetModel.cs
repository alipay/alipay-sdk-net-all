using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionTriggerGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseFunctionTriggerGetModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 云函数名称
        /// </summary>
        [XmlElement("function_name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// 触发器类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
