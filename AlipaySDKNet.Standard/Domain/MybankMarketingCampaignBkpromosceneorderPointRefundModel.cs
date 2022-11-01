using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankMarketingCampaignBkpromosceneorderPointRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankMarketingCampaignBkpromosceneorderPointRefundModel : AopObject
    {
        /// <summary>
        /// LinkedMall分配的业务ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 原始扣减积分的请求ID
        /// </summary>
        [XmlElement("deducted_request_id")]
        public string DeductedRequestId { get; set; }

        /// <summary>
        /// LinkedMall的订单ID
        /// </summary>
        [XmlElement("lm_order_id")]
        public long LmOrderId { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
