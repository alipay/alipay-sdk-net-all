using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEnergyReceiveSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEnergyReceiveSendModel : AopObject
    {
        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝用户uid;
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 绿色能量发放归属的商户信息。 说明： 如果该复杂对象不填。则默认为该绿色能量发放的归属者是调用者本人。 如果填写，则认为该绿色能量发放的归属者是该商户。  限制:服务商身份接入时必传
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public BelongMerchantInfoDTO BelongMerchantInfo { get; set; }

        /// <summary>
        /// 能量领取时间
        /// </summary>
        [XmlElement("get_time")]
        public string GetTime { get; set; }

        /// <summary>
        /// 需要发放能量的商品码; 如果不传，则按照整笔订单的环保类型进行发放
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 每批次调用的数据需要生成record_id,基于该字段做幂等校验，冲突返回错误ORDER_DUPLICATE
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 订单所对应的支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
