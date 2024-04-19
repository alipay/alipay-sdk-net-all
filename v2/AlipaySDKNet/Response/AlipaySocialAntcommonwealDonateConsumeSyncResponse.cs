using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntcommonwealDonateConsumeSyncResponse.
    /// </summary>
    public class AlipaySocialAntcommonwealDonateConsumeSyncResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 成功/失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
