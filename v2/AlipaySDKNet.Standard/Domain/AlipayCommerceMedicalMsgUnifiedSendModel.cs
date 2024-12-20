using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMsgUnifiedSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMsgUnifiedSendModel : AopObject
    {
        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝uid 2088开头的16位纯数字，小程序场景下获取用户ID请参考：用户授权; 其它场景下获取用户ID请参考：网页授权获取用户信息;
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// api服务名 alipay.medical.nosubscribe.ordermsg.send 免订阅订单 alipay.medical.nosubscribe.msg.send 免订阅服务
        /// </summary>
        [XmlElement("api_service")]
        public string ApiService { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("ext_params")]
        public string ExtParams { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("merchant_order_status")]
        public string MerchantOrderStatus { get; set; }

        /// <summary>
        /// 消息渠道
        /// </summary>
        [XmlElement("message_channel")]
        public string MessageChannel { get; set; }

        /// <summary>
        /// 订单创建时间，时间格式为：yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单修改时间，时间格式为：yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("order_modified_time")]
        public string OrderModifiedTime { get; set; }

        /// <summary>
        /// 商户订单id，请保持唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部订单类型
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 模板码，支付宝侧定义
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 用户证件号
        /// </summary>
        [XmlElement("user_card_no")]
        public string UserCardNo { get; set; }

        /// <summary>
        /// 用户证件类型 目前仅支持身份证
        /// </summary>
        [XmlElement("user_card_type")]
        public string UserCardType { get; set; }
    }
}
