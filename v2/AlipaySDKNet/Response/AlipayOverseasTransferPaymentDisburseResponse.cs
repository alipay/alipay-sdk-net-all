using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTransferPaymentDisburseResponse.
    /// </summary>
    public class AlipayOverseasTransferPaymentDisburseResponse : AopResponse
    {
        /// <summary>
        /// 透传信息
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 批量结果返回
        /// </summary>
        [XmlElement("transaction_results")]
        public string TransactionResults { get; set; }
    }
}
