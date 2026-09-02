using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseSourceuidPidQueryResponse.
    /// </summary>
    public class AnttechOceanbaseSourceuidPidQueryResponse : AopResponse
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("alipay_virtual_id")]
        public string AlipayVirtualId { get; set; }

        /// <summary>
        /// 来源uid
        /// </summary>
        [XmlElement("source_uid")]
        public string SourceUid { get; set; }
    }
}
