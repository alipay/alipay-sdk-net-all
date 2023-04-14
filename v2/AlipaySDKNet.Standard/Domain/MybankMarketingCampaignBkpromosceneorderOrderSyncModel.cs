using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankMarketingCampaignBkpromosceneorderOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankMarketingCampaignBkpromosceneorderOrderSyncModel : AopObject
    {
        /// <summary>
        /// 该单金额
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 子单标志, 为1表示子单 (一单一品，主子单标志均为1)
        /// </summary>
        [XmlElement("detail_flag")]
        public long DetailFlag { get; set; }

        /// <summary>
        /// 商品列表，订单创建的时候才有值，列表的长度为1，只有一个商品
        /// </summary>
        [XmlElement("item_list")]
        public string ItemList { get; set; }

        /// <summary>
        /// 当前变更的订单号，如果一单一品那么主子订单号一致
        /// </summary>
        [XmlElement("lm_order_id")]
        public long LmOrderId { get; set; }

        /// <summary>
        /// 主单标志，为1表示主单
        /// </summary>
        [XmlElement("main_flag")]
        public long MainFlag { get; set; }

        /// <summary>
        /// 主订单号
        /// </summary>
        [XmlElement("main_lm_order_id")]
        public long MainLmOrderId { get; set; }

        /// <summary>
        /// 变化时间
        /// </summary>
        [XmlElement("modified_time")]
        public long ModifiedTime { get; set; }

        /// <summary>
        /// 当前订单状态
        /// </summary>
        [XmlElement("order_status")]
        public long OrderStatus { get; set; }

        /// <summary>
        /// 原订单状态
        /// </summary>
        [XmlElement("pre_order_status")]
        public long PreOrderStatus { get; set; }

        /// <summary>
        /// 请求标识
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
