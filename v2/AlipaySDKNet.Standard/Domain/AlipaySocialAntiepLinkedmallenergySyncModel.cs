using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntiepLinkedmallenergySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntiepLinkedmallenergySyncModel : AopObject
    {
        /// <summary>
        /// 订单金额,单位分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 跳转商品链接时传递，有就透传回来，没有不用传
        /// </summary>
        [XmlElement("biz_context")]
        public string BizContext { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// LinkedMall的订单ID
        /// </summary>
        [XmlElement("lm_order_id")]
        public long LmOrderId { get; set; }

        /// <summary>
        /// 数据库变化时间戳，用户付款时间
        /// </summary>
        [XmlElement("modified_time")]
        public long ModifiedTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 1=创单开始，12=创单完成，待支付，2=已支付，4=已退款关闭，6=交易成功，8=被淘宝关闭
        /// </summary>
        [XmlElement("order_status")]
        public long OrderStatus { get; set; }

        /// <summary>
        /// 原订单状态
        /// </summary>
        [XmlElement("pre_order_status")]
        public long PreOrderStatus { get; set; }

        /// <summary>
        /// 场景码，如：antforest（蚂蚁森林）
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// sku的id
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
