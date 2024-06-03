using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupGroupinstanceinfoQueryResponse.
    /// </summary>
    public class AlipayMerchantGroupGroupinstanceinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 群详情
        /// </summary>
        [XmlElement("group_instance_info")]
        public GroupInstanceInfoVO GroupInstanceInfo { get; set; }
    }
}
