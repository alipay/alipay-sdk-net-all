using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsMarketingInscouponTriggerResponse.
    /// </summary>
    public class AlipayInsMarketingInscouponTriggerResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("trigger_result")]
        [XmlArrayItem("key_value_d_t_o")]
        public List<KeyValueDTO> TriggerResult { get; set; }
    }
}
