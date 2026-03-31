using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAlipaymemberPointQueryResponse.
    /// </summary>
    public class AlipayUserAlipaymemberPointQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户积分余额
        /// </summary>
        [XmlElement("point_balance")]
        public long PointBalance { get; set; }
    }
}
