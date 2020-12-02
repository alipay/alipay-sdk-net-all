using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationUserPointQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationUserPointQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户当前可用积分
        /// </summary>
        [XmlElement("current_point")]
        public long CurrentPoint { get; set; }

        /// <summary>
        /// 用户累计总积分
        /// </summary>
        [XmlElement("total_point")]
        public long TotalPoint { get; set; }
    }
}
