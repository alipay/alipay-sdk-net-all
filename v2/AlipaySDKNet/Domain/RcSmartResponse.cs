using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RcSmartResponse Data Structure.
    /// </summary>
    [Serializable]
    public class RcSmartResponse : AopObject
    {
        /// <summary>
        /// 返回的提示信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 返回的结果编码。 其中FAIL和RATE_LIMIT可支持更换requestId重新发起 枚举 成功：SUCCESS 失败：FAIl 幂等：DUP_SUCESS 降级：DEGRADE 限流：RATE_LIMIT
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
