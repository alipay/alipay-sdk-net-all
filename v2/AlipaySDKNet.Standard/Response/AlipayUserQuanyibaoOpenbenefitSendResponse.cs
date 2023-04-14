using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserQuanyibaoOpenbenefitSendResponse.
    /// </summary>
    public class AlipayUserQuanyibaoOpenbenefitSendResponse : AopResponse
    {
        /// <summary>
        /// 权益宝权益发放的业务号，与入参中third_biz_no关联且唯一
        /// </summary>
        [XmlElement("send_biz_no")]
        public string SendBizNo { get; set; }

        /// <summary>
        /// 标识权益的发放状态，process是中间态，表示可重试，FAILED和SUCCESS表示终态
        /// </summary>
        [XmlElement("send_status")]
        public string SendStatus { get; set; }
    }
}
