using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInstserviceCpataskQueryResponse.
    /// </summary>
    public class AlipayEbppInstserviceCpataskQueryResponse : AopResponse
    {
        /// <summary>
        /// 该值是CPA任务投放全链路进行唯一归因的标记，广告主侧后续广告数据回传也需要携带该字段进行任务定位。
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 任务投放的广告链接
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }
    }
}
