using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalOrderRefundApproveResponse.
    /// </summary>
    public class AlipayCommerceMedicalOrderRefundApproveResponse : AopResponse
    {
        /// <summary>
        /// 返回信息true/false
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
