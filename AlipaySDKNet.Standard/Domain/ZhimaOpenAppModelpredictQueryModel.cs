using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaOpenAppModelpredictQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaOpenAppModelpredictQueryModel : AopObject
    {
        /// <summary>
        /// 模型标识，具体走哪个预测平台及模型
        /// </summary>
        [XmlElement("model")]
        public string Model { get; set; }

        /// <summary>
        /// 用于模型预测的样本数据，可能是json格式
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }
    }
}
