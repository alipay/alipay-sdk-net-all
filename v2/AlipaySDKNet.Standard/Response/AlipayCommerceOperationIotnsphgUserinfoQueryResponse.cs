using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationIotnsphgUserinfoQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationIotnsphgUserinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝用户绑定的手机号 。
        /// </summary>
        [XmlElement("binded_mobile")]
        public string BindedMobile { get; set; }
    }
}
