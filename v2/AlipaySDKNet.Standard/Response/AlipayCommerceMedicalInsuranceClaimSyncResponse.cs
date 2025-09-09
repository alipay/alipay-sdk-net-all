using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceClaimSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceClaimSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝理赔报案号
        /// </summary>
        [XmlElement("ant_claim_no")]
        public string AntClaimNo { get; set; }
    }
}
