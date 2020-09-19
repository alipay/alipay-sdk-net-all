using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTransferInstitutionpaymentQueryResponse.
    /// </summary>
    public class AlipayOverseasTransferInstitutionpaymentQueryResponse : AopResponse
    {
        /// <summary>
        /// 透传保留字段，json map格式
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 学校缴费项列表List<PaymemtDetail>
        /// </summary>
        [XmlArray("payment_details")]
        [XmlArrayItem("string")]
        public List<string> PaymentDetails { get; set; }
    }
}
