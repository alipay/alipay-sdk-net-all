using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTradeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTradeCreateModel : AopObject
    {
        /// <summary>
        /// 购买数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public EduTradeExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 缴费过期时间
        /// </summary>
        [XmlElement("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 实际支付时间
        /// </summary>
        [XmlElement("gmt_paytime")]
        public string GmtPaytime { get; set; }

        /// <summary>
        /// 支付宝内部商品编号
        /// </summary>
        [XmlElement("good_id")]
        public string GoodId { get; set; }

        /// <summary>
        /// 外部账单编号
        /// </summary>
        [XmlElement("isv_order_no")]
        public string IsvOrderNo { get; set; }

        /// <summary>
        /// 实际支付金额，单位元，两位小数
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 二级商户
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 订单来源：   2-钉钉   3-支课堂
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 交易单名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 账单总金额，单位元，两位小数
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 订单状态  1-待支付  3-已支付  6-已关闭
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 标价币种
        /// </summary>
        [XmlElement("trans_currency")]
        public string TransCurrency { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
