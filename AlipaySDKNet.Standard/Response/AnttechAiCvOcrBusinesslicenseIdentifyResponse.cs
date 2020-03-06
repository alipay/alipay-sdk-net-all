using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechAiCvOcrBusinesslicenseIdentifyResponse.
    /// </summary>
    public class AnttechAiCvOcrBusinesslicenseIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 算法错误信息
        /// </summary>
        [XmlElement("algo_msg")]
        public string AlgoMsg { get; set; }

        /// <summary>
        /// 算法异常错误码
        /// </summary>
        [XmlElement("algo_ret")]
        public long AlgoRet { get; set; }

        /// <summary>
        /// 框架错误信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 算法结果,JSON String
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 框架inference服务错误码，0为正常
        /// </summary>
        [XmlElement("ret")]
        public long Ret { get; set; }
    }
}
