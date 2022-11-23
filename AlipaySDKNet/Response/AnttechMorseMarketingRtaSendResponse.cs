using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingRtaSendResponse.
    /// </summary>
    public class AnttechMorseMarketingRtaSendResponse : AopResponse
    {
        /// <summary>
        /// 业务唯一标识，标识本次查询的唯一识别号，用于问题定位
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 活动id描述具体给用户发奖的活动
        /// </summary>
        [XmlElement("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 发奖订单号
        /// </summary>
        [XmlElement("send_order_id")]
        public string SendOrderId { get; set; }

        /// <summary>
        /// 发奖订单时间
        /// </summary>
        [XmlElement("send_order_time")]
        public string SendOrderTime { get; set; }

        /// <summary>
        /// 发放流水状态
        /// </summary>
        [XmlElement("send_status")]
        public string SendStatus { get; set; }
    }
}
