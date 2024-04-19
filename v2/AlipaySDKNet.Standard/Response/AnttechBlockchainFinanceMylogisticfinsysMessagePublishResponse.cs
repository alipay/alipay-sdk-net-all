using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceMylogisticfinsysMessagePublishResponse.
    /// </summary>
    public class AnttechBlockchainFinanceMylogisticfinsysMessagePublishResponse : AopResponse
    {
        /// <summary>
        /// 返回值
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 额外信息，非json形式，如
        /// </summary>
        [XmlElement("extra_info")]
        public string ExtraInfo { get; set; }
    }
}
