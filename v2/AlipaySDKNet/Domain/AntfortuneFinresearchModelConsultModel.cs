using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchModelConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchModelConsultModel : AopObject
    {
        /// <summary>
        /// 模型code指定了需要流式调用的模型
        /// </summary>
        [XmlElement("model_code")]
        public string ModelCode { get; set; }

        /// <summary>
        /// qa模型入参，一般为一段文本。
        /// </summary>
        [XmlElement("model_input")]
        public string ModelInput { get; set; }

        /// <summary>
        /// 服务标识用于鉴权以及服务定向
        /// </summary>
        [XmlElement("service_key")]
        public string ServiceKey { get; set; }
    }
}
