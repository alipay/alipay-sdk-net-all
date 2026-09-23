using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalTradeDirectCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalTradeDirectCreateModel : AopObject
    {
        /// <summary>
        /// 蚂蚁健康用户的openId
        /// </summary>
        [XmlElement("aq_open_id")]
        public string AqOpenId { get; set; }

        /// <summary>
        /// 支付成功回跳地址
        /// </summary>
        [XmlElement("call_back_url")]
        public string CallBackUrl { get; set; }

        /// <summary>
        /// 渠道业务场景
        /// </summary>
        [XmlElement("ch_info")]
        public string ChInfo { get; set; }

        /// <summary>
        /// 业务使用的支付产品，需要联系支付宝业务人员获取
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 发起创单时间
        /// </summary>
        [XmlElement("gmt_out_create")]
        public string GmtOutCreate { get; set; }

        /// <summary>
        /// 订单超时时间
        /// </summary>
        [XmlElement("gmt_time_expire")]
        public string GmtTimeExpire { get; set; }

        /// <summary>
        /// 支付宝用户openId和蚂蚁健康openId不能都为空
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部交易单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 场景信息
        /// </summary>
        [XmlElement("scene_info")]
        public string SceneInfo { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 直付通场景传入的二级商户信息
        /// </summary>
        [XmlElement("sub_merchant")]
        public SubMerchantInfo SubMerchant { get; set; }

        /// <summary>
        /// 服务类型下的字类型
        /// </summary>
        [XmlElement("sub_service_type")]
        public string SubServiceType { get; set; }

        /// <summary>
        /// 订单总标题
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单总金额，单位是元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝用户Id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
