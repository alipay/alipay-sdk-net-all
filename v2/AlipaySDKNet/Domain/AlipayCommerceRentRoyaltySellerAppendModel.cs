using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentRoyaltySellerAppendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentRoyaltySellerAppendModel : AopObject
    {
        /// <summary>
        /// 16位纯数字，小程序场景下获取用户ID请参考：用户授权; 其它场景下获取用户ID请参考：网页授权获取用户信息;其中buyer_id与buyer_open_id不能同时为空
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝用户唯一标识
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 执行场景为支付发生在资商订单确认前
        /// </summary>
        [XmlElement("execute_scene")]
        public string ExecuteScene { get; set; }

        /// <summary>
        /// 交易组件的业务订单Id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 填入当前期数
        /// </summary>
        [XmlElement("period")]
        public long Period { get; set; }

        /// <summary>
        /// 分账计划类型
        /// </summary>
        [XmlElement("royalty_type")]
        public string RoyaltyType { get; set; }

        /// <summary>
        /// 填入当前阶段数
        /// </summary>
        [XmlElement("stage")]
        public long Stage { get; set; }
    }
}
