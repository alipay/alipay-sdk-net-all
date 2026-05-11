using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalFulfillmentListQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalFulfillmentListQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("fulfillment_info_list")]
        [XmlArrayItem("fulfillment_info_v_o")]
        public List<FulfillmentInfoVO> FulfillmentInfoList { get; set; }
    }
}
