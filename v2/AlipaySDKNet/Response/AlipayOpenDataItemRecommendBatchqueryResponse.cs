using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenDataItemRecommendBatchqueryResponse.
    /// </summary>
    public class AlipayOpenDataItemRecommendBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 推荐结果
        /// </summary>
        [XmlArray("result_obj")]
        [XmlArrayItem("rec_result_info")]
        public List<RecResultInfo> ResultObj { get; set; }
    }
}
