using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingTicketstubPurchaseSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingTicketstubPurchaseSyncModel : AopObject
    {
        /// <summary>
        /// 用户购票的操作信息 核销 APPLY 退款 EXPIRE 注意：部分退款的场景需要业务方自己去识别，只有全部退款才发起退款的请求
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 请求流水号,32位UUID，幂等键
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 购票者信息，非必填，可以获取用户证件信息的情况下提供
        /// </summary>
        [XmlElement("buyer_info")]
        public string BuyerInfo { get; set; }

        /// <summary>
        /// 外部订单号，票务系统的购票的订单号ID
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单生成时间
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 支付宝分配的场景编码，用于识别活动场景及区域等信息 格式:城市_票务系统_年份
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 票根的额外信息
        /// </summary>
        [XmlElement("stub_info")]
        public string StubInfo { get; set; }

        /// <summary>
        /// 每个票根场次Code（全局唯一），该Code由支付宝提供，更新场次也会使用该Code
        /// </summary>
        [XmlElement("venue_code")]
        public string VenueCode { get; set; }
    }
}
