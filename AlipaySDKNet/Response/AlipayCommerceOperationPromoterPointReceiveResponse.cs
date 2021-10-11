using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationPromoterPointReceiveResponse.
    /// </summary>
    public class AlipayCommerceOperationPromoterPointReceiveResponse : AopResponse
    {
        /// <summary>
        /// 积分领取结果
        /// </summary>
        [XmlElement("point_receive_result")]
        public PointReceiveInfo PointReceiveResult { get; set; }
    }
}
