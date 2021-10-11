using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechAiCvUaIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechAiCvUaIdentifyModel : AopObject
    {
        /// <summary>
        /// 路由规则、超时时间等模型单次pv的配置，默认可不填，具体值参考模型服务提供者
        /// </summary>
        [XmlElement("attributes")]
        public string Attributes { get; set; }

        /// <summary>
        /// 模方平台应用id,用作访问权限控制
        /// </summary>
        [XmlElement("m_app_id")]
        public string MAppId { get; set; }

        /// <summary>
        /// 模型调用参数jsonstring,具体传参值参考模方服务提供者
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 模型服务code
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 具体值需要参考模型服务提供者
        /// </summary>
        [XmlElement("uri")]
        public string Uri { get; set; }
    }
}
