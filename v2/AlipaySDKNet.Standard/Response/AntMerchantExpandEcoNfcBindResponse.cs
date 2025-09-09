using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandEcoNfcBindResponse.
    /// </summary>
    public class AntMerchantExpandEcoNfcBindResponse : AopResponse
    {
        /// <summary>
        /// 绑定失败的具体原因
        /// </summary>
        [XmlElement("bind_fail_reason")]
        public string BindFailReason { get; set; }

        /// <summary>
        /// 绑定结果
        /// </summary>
        [XmlElement("bind_success")]
        public bool BindSuccess { get; set; }
    }
}
