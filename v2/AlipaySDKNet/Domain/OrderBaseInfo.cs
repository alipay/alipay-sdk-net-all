using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderBaseInfo : AopObject
    {
        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 商户在创单阶段传入的订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 交易组件订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单创建时刻的场域来源
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }
    }
}
