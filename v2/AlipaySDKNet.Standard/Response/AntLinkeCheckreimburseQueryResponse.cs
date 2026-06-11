using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntLinkeCheckreimburseQueryResponse.
    /// </summary>
    public class AntLinkeCheckreimburseQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("subscription_reimbursement_list")]
        [XmlArrayItem("subscription_reimbursement_v_o")]
        public List<SubscriptionReimbursementVO> SubscriptionReimbursementList { get; set; }
    }
}
