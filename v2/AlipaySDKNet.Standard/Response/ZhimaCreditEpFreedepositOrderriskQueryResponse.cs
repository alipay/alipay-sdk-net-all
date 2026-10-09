using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpFreedepositOrderriskQueryResponse.
    /// </summary>
    public class ZhimaCreditEpFreedepositOrderriskQueryResponse : AopResponse
    {
        /// <summary>
        /// 风控结果
        /// </summary>
        [XmlElement("decision")]
        public string Decision { get; set; }

        /// <summary>
        /// 芝麻业务流水号
        /// </summary>
        [XmlElement("lease_order_no")]
        public string LeaseOrderNo { get; set; }

        /// <summary>
        /// 商户业务流水号，请确保每次业务唯一
        /// </summary>
        [XmlElement("merchant_lease_order_no")]
        public string MerchantLeaseOrderNo { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }
    }
}
