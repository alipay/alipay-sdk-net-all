using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorCreditapplyresultQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorCreditapplyresultQueryResponse : AopResponse
    {
        /// <summary>
        /// 授信申请结果
        /// </summary>
        [XmlElement("result")]
        public HonorCreditApplyResultDTO Result { get; set; }
    }
}
