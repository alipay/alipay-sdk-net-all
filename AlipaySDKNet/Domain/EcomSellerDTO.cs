using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcomSellerDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EcomSellerDTO : AopObject
    {
        /// <summary>
        /// 卖家联系地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 支付宝账号id
        /// </summary>
        [XmlElement("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 支付宝账号id
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 卖家标
        /// </summary>
        [XmlElement("attributes")]
        public string Attributes { get; set; }

        /// <summary>
        /// 银行卡持卡人姓名:资金账号类型为银行卡时，必传
        /// </summary>
        [XmlElement("bank_card_holder_name")]
        public string BankCardHolderName { get; set; }

        /// <summary>
        /// 银行卡号:资金账号类型为银行卡时，必传
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
        /// 资金账号类型 （BANK/ALIPAY）
        /// </summary>
        [XmlElement("bill_account_type")]
        public string BillAccountType { get; set; }

        /// <summary>
        /// 证件号:身份证号
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 实名证件类型:RESIDENT 身份证号
        /// </summary>
        [XmlElement("id_card_type")]
        public string IdCardType { get; set; }

        /// <summary>
        /// 卖家主营类目的平台全量订单数（近30天）
        /// </summary>
        [XmlElement("main_cat_order_count_of_platform")]
        public long MainCatOrderCountOfPlatform { get; set; }

        /// <summary>
        /// 卖家主营类目的平台全量订单退换货率（近30天）
        /// </summary>
        [XmlElement("main_cat_refund_exchange_rate_of_platform")]
        public string MainCatRefundExchangeRateOfPlatform { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 卖家真实姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 卖家历史90天完结父订单数
        /// </summary>
        [XmlElement("seller_order_count")]
        public long SellerOrderCount { get; set; }

        /// <summary>
        /// 卖家历史90天完结父订单退换货率
        /// </summary>
        [XmlElement("seller_order_refund_exchange_rate")]
        public string SellerOrderRefundExchangeRate { get; set; }

        /// <summary>
        /// 卖家用户类型:OTHER 其它第三方账号
        /// </summary>
        [XmlElement("seller_user_type")]
        public string SellerUserType { get; set; }
    }
}
