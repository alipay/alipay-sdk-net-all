using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserGamecenterCoinPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGamecenterCoinPayModel : AopObject
    {
        /// <summary>
        /// 扣除游戏币数量
        /// </summary>
        [XmlElement("amt")]
        public long Amt { get; set; }

        /// <summary>
        /// 游戏开发者备注，会写到道具购买交易流水中，开发者自定义
        /// </summary>
        [XmlElement("app_remark")]
        public string AppRemark { get; set; }

        /// <summary>
        /// 扣游戏币开发者订单号，需保证全局唯一，相同的订单号不会重复扣款
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 商户app_id维度下的用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 兑换游戏道具名，开发者自定义名称
        /// </summary>
        [XmlElement("pay_item")]
        public string PayItem { get; set; }

        /// <summary>
        /// 支付宝唯一用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
