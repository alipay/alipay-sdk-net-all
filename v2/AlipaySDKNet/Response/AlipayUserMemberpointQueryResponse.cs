using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMemberpointQueryResponse.
    /// </summary>
    public class AlipayUserMemberpointQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝用户的蚂蚁会员积分余额
        /// </summary>
        [XmlElement("point")]
        public long Point { get; set; }
    }
}
