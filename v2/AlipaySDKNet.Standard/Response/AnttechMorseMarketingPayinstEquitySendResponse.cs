using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingPayinstEquitySendResponse.
    /// </summary>
    public class AnttechMorseMarketingPayinstEquitySendResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁侧返回的唯一标识
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 发放成功后生成的发放凭证号
        /// </summary>
        [XmlElement("send_order_id")]
        public string SendOrderId { get; set; }

        /// <summary>
        /// 是否发放成功
        /// </summary>
        [XmlElement("send_success")]
        public bool SendSuccess { get; set; }
    }
}
