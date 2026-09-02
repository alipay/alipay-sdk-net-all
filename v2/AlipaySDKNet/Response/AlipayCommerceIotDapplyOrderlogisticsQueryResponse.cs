using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrderlogisticsQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDapplyOrderlogisticsQueryResponse : AopResponse
    {
        /// <summary>
        /// 供应链订单号内部称AO单
        /// </summary>
        [XmlElement("asset_apply_order_id")]
        public string AssetApplyOrderId { get; set; }

        /// <summary>
        /// 发货数量机具数量，单位：台
        /// </summary>
        [XmlElement("deliver_count")]
        public long DeliverCount { get; set; }

        /// <summary>
        /// 快递包裹信息，如果是多个包裹发货会有多个包裹信息
        /// </summary>
        [XmlArray("express_list")]
        [XmlArrayItem("device_apply_express_info")]
        public List<DeviceApplyExpressInfo> ExpressList { get; set; }

        /// <summary>
        /// 商户下单时传入的收货人手机号脱敏返回
        /// </summary>
        [XmlElement("receiver_mobile")]
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 下单时传入的收货人姓名脱敏返回
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }
    }
}
