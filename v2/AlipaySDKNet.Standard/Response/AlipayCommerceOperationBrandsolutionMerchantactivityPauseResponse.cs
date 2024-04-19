using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationBrandsolutionMerchantactivityPauseResponse.
    /// </summary>
    public class AlipayCommerceOperationBrandsolutionMerchantactivityPauseResponse : AopResponse
    {
        /// <summary>
        /// 批量修改结果
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("enrolled_merchant_result")]
        public List<EnrolledMerchantResult> Data { get; set; }
    }
}
