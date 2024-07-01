using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderAftersaleSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderAftersaleSyncModel : AopObject
    {
        /// <summary>
        /// 操作code
        /// </summary>
        [XmlElement("action_code")]
        public string ActionCode { get; set; }

        /// <summary>
        /// 交易组件售后单id
        /// </summary>
        [XmlElement("aftersale_id")]
        public string AftersaleId { get; set; }

        /// <summary>
        /// 售后审核原因。
        /// </summary>
        [XmlElement("audit_reason")]
        public string AuditReason { get; set; }

        /// <summary>
        /// 商家售后审核状态
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 物流信息，action_code为203时必填
        /// </summary>
        [XmlArray("logistics_list")]
        [XmlArrayItem("aftersale_logistics_info_d_t_o")]
        public List<AftersaleLogisticsInfoDTO> LogisticsList { get; set; }

        /// <summary>
        /// 商家地址
        /// </summary>
        [XmlElement("merchant_address_info")]
        public AftersaleAddressInfoDTO MerchantAddressInfo { get; set; }

        /// <summary>
        /// 商家实际同意退款的金额（元）
        /// </summary>
        [XmlElement("merchant_agree_refund_amount")]
        public string MerchantAgreeRefundAmount { get; set; }

        /// <summary>
        /// 买家open_id；open_id和user_id二选一
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号，创建订单时由商户传入
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 退货寄送方式 action_code为201时可选填入, 不传入的情况下使用商家自行接入的售后物流能力。
        /// </summary>
        [XmlElement("return_delivery_type")]
        public string ReturnDeliveryType { get; set; }

        /// <summary>
        /// 买家支付宝用户id，小程序场景下获取用户ID请参考：<a href="https://opendocs.alipay.com/mini/05dxgc?pathHash=1a3ecb13">用户授权</a>; 其它场景下获取用户ID请参考：<a href="https://opendocs.alipay.com/open/284/web">网页授权获取用户信息</a>。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
