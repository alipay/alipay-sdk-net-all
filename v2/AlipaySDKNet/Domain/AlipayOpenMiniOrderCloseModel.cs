using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderCloseModel : AopObject
    {
        /// <summary>
        /// 买家open_id；open_id和user_id二选一
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易组件订单号；order_id和out_order_id二选一
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号，创建订单请求由商户传入；order_id和out_order_id二选一
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 关闭原因编码对应的描述信息
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 取消订单的原因编码，不同业务的取消原因不同，更多原因编码枚举值请参考：https://xfpzl.yuque.com/dgw58m/apg2ie/howyv43z3piimp48#SaZq
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 买家支付宝用户ID；open_id和user_id二选一
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
