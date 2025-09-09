using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppBainaPrizeVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppBainaPrizeVerifyModel : AopObject
    {
        /// <summary>
        /// 从下单url的extJosn参数中获取，key=activityId，此接口带回
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 下单商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品价格，单位为元
        /// </summary>
        [XmlElement("item_price")]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 用户下单lm侧订单号
        /// </summary>
        [XmlElement("lm_order_id")]
        public string LmOrderId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 请求编号，编号相同则认为为同一请求，幂等使用
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 下单该商品需要的资格数
        /// </summary>
        [XmlElement("point")]
        public long Point { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
