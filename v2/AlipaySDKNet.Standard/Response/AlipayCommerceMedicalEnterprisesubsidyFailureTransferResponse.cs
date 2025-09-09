using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalEnterprisesubsidyFailureTransferResponse.
    /// </summary>
    public class AlipayCommerceMedicalEnterprisesubsidyFailureTransferResponse : AopResponse
    {
        /// <summary>
        /// 不代表转账成功/失败，转账最终结果通过【同步转账结果】接口告知
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
