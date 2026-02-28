using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationTagClaimAddResponse.
    /// </summary>
    public class AlipayCommerceOperationTagClaimAddResponse : AopResponse
    {
        /// <summary>
        /// 实际添加的点餐线圈成功数量，如果为0表示无可添加的线圈
        /// </summary>
        [XmlElement("success_count")]
        public long SuccessCount { get; set; }
    }
}
