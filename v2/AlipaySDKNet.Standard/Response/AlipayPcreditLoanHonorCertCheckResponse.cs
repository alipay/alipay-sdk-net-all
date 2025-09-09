using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorCertCheckResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorCertCheckResponse : AopResponse
    {
        /// <summary>
        /// 校验结果, true-一致, false-不一致
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
