using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpAeprepayContractSignResponse.
    /// </summary>
    public class ZhimaCreditEpAeprepayContractSignResponse : AopResponse
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 签约失败原因码。成功时为空
        /// </summary>
        [XmlElement("failed_code")]
        public string FailedCode { get; set; }

        /// <summary>
        /// 签约失败原因描述。成功时为空
        /// </summary>
        [XmlElement("failed_message")]
        public string FailedMessage { get; set; }
    }
}
