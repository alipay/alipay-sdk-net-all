using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantQipanCrowdQueryResponse.
    /// </summary>
    public class AlipayMerchantQipanCrowdQueryResponse : AopResponse
    {
        /// <summary>
        /// 商家人群信息
        /// </summary>
        [XmlElement("crowd_info")]
        public QipanMerchantCrowd CrowdInfo { get; set; }
    }
}
