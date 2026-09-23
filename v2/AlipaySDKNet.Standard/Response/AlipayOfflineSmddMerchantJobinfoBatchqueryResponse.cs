using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSmddMerchantJobinfoBatchqueryResponse.
    /// </summary>
    public class AlipayOfflineSmddMerchantJobinfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("merchant_job_info")]
        public List<MerchantJobInfo> DataList { get; set; }
    }
}
