using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpSceneFulfillmentlistSyncResponse.
    /// </summary>
    public class ZhimaCreditEpSceneFulfillmentlistSyncResponse : AopResponse
    {
        /// <summary>
        /// 履约同步结果列表
        /// </summary>
        [XmlArray("fulfillment_result_list")]
        [XmlArrayItem("fulfillment_result")]
        public List<FulfillmentResult> FulfillmentResultList { get; set; }
    }
}
