using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoContractsLoanInfoSyncResponse.
    /// </summary>
    public class AlipayEcoContractsLoanInfoSyncResponse : AopResponse
    {
        /// <summary>
        /// true代表同步成功,false代表同步失败
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
