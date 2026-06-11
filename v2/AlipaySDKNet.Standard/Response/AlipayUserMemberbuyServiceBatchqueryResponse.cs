using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMemberbuyServiceBatchqueryResponse.
    /// </summary>
    public class AlipayUserMemberbuyServiceBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("service_info_list")]
        [XmlArrayItem("mini_app_service_batch_query_result")]
        public List<MiniAppServiceBatchQueryResult> ServiceInfoList { get; set; }
    }
}
