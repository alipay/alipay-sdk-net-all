using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechAiCvUaIdentifyResponse.
    /// </summary>
    public class AnttechAiCvUaIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 服务访问机器
        /// </summary>
        [XmlElement("host")]
        public string Host { get; set; }

        /// <summary>
        /// 具体错误码参考模型服务提供者
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 模型预测结果，jsonstring，具体参考模型服务提供者的样例输出
        /// </summary>
        [XmlElement("result_map")]
        public string ResultMap { get; set; }

        /// <summary>
        /// 模型结果信息
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 非0表示模型inference有异常
        /// </summary>
        [XmlElement("ret")]
        public string Ret { get; set; }

        /// <summary>
        /// 当次调用是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
