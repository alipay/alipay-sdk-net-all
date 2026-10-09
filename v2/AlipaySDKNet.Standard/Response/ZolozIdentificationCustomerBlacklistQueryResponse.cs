using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerBlacklistQueryResponse.
    /// </summary>
    public class ZolozIdentificationCustomerBlacklistQueryResponse : AopResponse
    {
        /// <summary>
        /// 详细原因
        /// </summary>
        [XmlElement("detail_reason")]
        public string DetailReason { get; set; }

        /// <summary>
        /// 黑名单过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 是否在黑名单中
        /// </summary>
        [XmlElement("in_black_list")]
        public string InBlackList { get; set; }
    }
}
