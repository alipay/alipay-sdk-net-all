using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserPrivilegerecordQueryResponse.
    /// </summary>
    public class AlipayUserPrivilegerecordQueryResponse : AopResponse
    {
        /// <summary>
        /// 特权使用状态
        /// </summary>
        [XmlElement("privilege_usage_status")]
        public string PrivilegeUsageStatus { get; set; }

        /// <summary>
        /// 特权对应的凭证码
        /// </summary>
        [XmlElement("voucher_code")]
        public string VoucherCode { get; set; }
    }
}
