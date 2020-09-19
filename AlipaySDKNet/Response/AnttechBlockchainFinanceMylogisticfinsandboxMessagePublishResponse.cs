using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceMylogisticfinsandboxMessagePublishResponse.
    /// </summary>
    public class AnttechBlockchainFinanceMylogisticfinsandboxMessagePublishResponse : AopResponse
    {
        /// <summary>
        /// 返回值
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 额外信息，非json形式
        /// </summary>
        [XmlElement("extra_info")]
        public string ExtraInfo { get; set; }
    }
}
