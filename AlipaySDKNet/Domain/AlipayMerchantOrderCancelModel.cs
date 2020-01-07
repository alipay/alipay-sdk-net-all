using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantOrderCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderCancelModel : AopObject
    {
        /// <summary>
        /// 业务场景，某些场景下操作的不是用户本身的订单，而是用户所在群体的订单的情况下，必传
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 下单时候的买家id
        /// </summary>
        [XmlElement("buyer")]
        public UserIdentity Buyer { get; set; }

        /// <summary>
        /// 退款扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("order_ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 下单并支付的时候返回的订单号，与外部请求号两者之间必须传一个
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 创建订单时传入的外部请求号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
