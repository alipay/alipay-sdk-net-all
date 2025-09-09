using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupGroupcontrolQueryResponse.
    /// </summary>
    public class AlipayMerchantGroupGroupcontrolQueryResponse : AopResponse
    {
        /// <summary>
        /// 广告屏蔽配置详情
        /// </summary>
        [XmlElement("group_control_detail")]
        public GroupControlVO GroupControlDetail { get; set; }
    }
}
