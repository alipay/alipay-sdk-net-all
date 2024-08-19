using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskPointaccountQueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskPointaccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 积分余额，单位个
        /// </summary>
        [XmlElement("available_amount")]
        public long AvailableAmount { get; set; }

        /// <summary>
        /// 验证测试积分数量，单位个
        /// </summary>
        [XmlElement("test_amount")]
        public long TestAmount { get; set; }
    }
}
