using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderLogisticsinfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderLogisticsinfoModifyModel : AopObject
    {
        /// <summary>
        /// 物流信息
        /// </summary>
        [XmlArray("logistics_list")]
        [XmlArrayItem("logistics_order_modify_d_t_o")]
        public List<LogisticsOrderModifyDTO> LogisticsList { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号，创建订单请求由商户传入
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
