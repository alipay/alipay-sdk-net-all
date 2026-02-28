using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalDoctoragentapprovalApproveResponse.
    /// </summary>
    public class AlipayCommerceMedicalDoctoragentapprovalApproveResponse : AopResponse
    {
        /// <summary>
        /// 处理结果
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
