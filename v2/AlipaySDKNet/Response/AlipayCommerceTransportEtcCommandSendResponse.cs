using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcCommandSendResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcCommandSendResponse : AopResponse
    {
        /// <summary>
        /// SUCCESS：订单申请成功； FAIL:申请失败
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 其他业务异常信息描述
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }
    }
}
