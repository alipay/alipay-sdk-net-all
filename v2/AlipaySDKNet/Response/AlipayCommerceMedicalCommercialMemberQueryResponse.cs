using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialMemberQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalCommercialMemberQueryResponse : AopResponse
    {
        /// <summary>
        /// 权益订单id，支付宝侧用户对商户某一权益的唯一订单子单id。该订单记录了用户的核销次数与总次数，以及订单状态
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 权益总次数，-1代表不限次
        /// </summary>
        [XmlElement("count")]
        public string Count { get; set; }

        /// <summary>
        /// 用户权益的结束过期时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// exist用于在商户查询某一用户是否具备会员资格时，返回的最终结果，true为具备资格，false为不具备。
        /// </summary>
        [XmlElement("exist")]
        public bool Exist { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户在支付宝支付后，医疗行业生成的唯一订单id。在履约通知接口会传递给商户，并且在会员卡权益新增时，商户需要识别用户并绑定当前生效订单id与商户侧用户可使用的权益
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// out_product_id为外部商户侧的权益唯一id，用于标记外部用户的权益
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }

        /// <summary>
        /// 用户权益的开始生效时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 权益已核销次数
        /// </summary>
        [XmlElement("usage_count")]
        public string UsageCount { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
