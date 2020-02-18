using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceIotAdvertiserAdBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 投放计划列表数组
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("creation_plan_data")]
        public List<CreationPlanData> Result { get; set; }

        /// <summary>
        /// 计划总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
