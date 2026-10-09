using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcApplyorderSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcApplyorderSignModel : AopObject
    {
        /// <summary>
        /// 外部宿主商户（ISV）的appid
        /// </summary>
        [XmlElement("agent_appid")]
        public string AgentAppid { get; set; }

        /// <summary>
        /// 外部宿主商户（ISV）的pid
        /// </summary>
        [XmlElement("agent_pid")]
        public string AgentPid { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 蚂蚁会员统一ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 发行方ID
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 签约完成后的承接页链接（宿主原页面）
        /// </summary>
        [XmlElement("sign_return_url")]
        public string SignReturnUrl { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 是否同步到车档案标识
        /// </summary>
        [XmlElement("vehicle_info_sync_flag")]
        public bool VehicleInfoSyncFlag { get; set; }
    }
}
