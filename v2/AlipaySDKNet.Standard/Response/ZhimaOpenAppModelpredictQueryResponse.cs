using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaOpenAppModelpredictQueryResponse.
    /// </summary>
    public class ZhimaOpenAppModelpredictQueryResponse : AopResponse
    {
        /// <summary>
        /// 模型预测的结果
        /// </summary>
        [XmlElement("resp")]
        public string Resp { get; set; }
    }
}
