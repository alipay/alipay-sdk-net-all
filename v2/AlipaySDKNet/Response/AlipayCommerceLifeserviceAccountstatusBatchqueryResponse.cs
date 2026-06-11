using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceAccountstatusBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceAccountstatusBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("life_service_account_list")]
        [XmlArrayItem("life_service_account_info")]
        public List<LifeServiceAccountInfo> LifeServiceAccountList { get; set; }
    }
}
