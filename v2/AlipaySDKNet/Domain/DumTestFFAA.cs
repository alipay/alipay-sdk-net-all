using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DumTestFFAA Data Structure.
    /// </summary>
    [Serializable]
    public class DumTestFFAA : AopObject
    {
        /// <summary>
        /// 商家侧小程序商品ID，指商家提报给小程序商品库的商品。当前接口的extend_params.trade_component_order_id字段不为空时该字段必填，且与交易组件订单参数保持一致。了解小程序商品请参考：<a  href="https://opendocs.alipay.com/mini/06uila?pathHash=63b6fba7">https://opendocs.alipay.com/mini/06uila?pathHash=63b6fba7</a>
        /// </summary>
        [XmlElement("field_a")]
        public string FieldA { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
