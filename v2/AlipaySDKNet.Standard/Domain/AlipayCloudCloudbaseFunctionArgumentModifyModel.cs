using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionArgumentModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseFunctionArgumentModifyModel : AopObject
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
        /// 参数数据
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 云函数名称
        /// </summary>
        [XmlElement("function_name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// 参数名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
