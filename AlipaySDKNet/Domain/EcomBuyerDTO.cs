using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcomBuyerDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EcomBuyerDTO : AopObject
    {
        /// <summary>
        /// 买家联系地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 支付宝账号id
        /// </summary>
        [XmlElement("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 支付宝登陆账号
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 支付宝账号id
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 银行卡持卡人姓名:资金账号类型为银行卡时，必传
        /// </summary>
        [XmlElement("bank_card_holder_name")]
        public string BankCardHolderName { get; set; }

        /// <summary>
        /// 银行卡号: 资金账号类型为银行卡时，必传
        /// </summary>
        [XmlElement("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 银行id
        /// </summary>
        [XmlElement("bank_id")]
        public string BankId { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 资金账号类型：ALIPAY， BANK
        /// </summary>
        [XmlElement("bill_account_type")]
        public string BillAccountType { get; set; }

        /// <summary>
        /// 买家id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 买家历史365天完结父订单数
        /// </summary>
        [XmlElement("buyer_order_count")]
        public long BuyerOrderCount { get; set; }

        /// <summary>
        /// 买家历史365天完结父订单退换货率
        /// </summary>
        [XmlElement("buyer_order_refund_exchange_rate")]
        public string BuyerOrderRefundExchangeRate { get; set; }

        /// <summary>
        /// 买家标签数据
        /// </summary>
        [XmlElement("buyer_tag_data")]
        public string BuyerTagData { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 实名证件类型:RESIDENT 居民身份证
        /// </summary>
        [XmlElement("id_card_type")]
        public string IdCardType { get; set; }

        /// <summary>
        /// 买家手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 买家真实姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}
