using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCreditbankTrainingQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCreditbankTrainingQueryResponse : AopResponse
    {
        /// <summary>
        /// 培训记录
        /// </summary>
        [XmlArray("training")]
        [XmlArrayItem("credit_bank_training")]
        public List<CreditBankTraining> Training { get; set; }
    }
}
