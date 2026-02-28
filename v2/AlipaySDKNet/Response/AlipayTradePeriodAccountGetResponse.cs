using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradePeriodAccountGetResponse.
    /// </summary>
    public class AlipayTradePeriodAccountGetResponse : AopResponse
    {
        /// <summary>
        /// 表示境内商家结算的卡编号
        /// </summary>
        [XmlElement("alipay_card_id")]
        public string AlipayCardId { get; set; }

        /// <summary>
        /// 表示境内商家结算中的卡号
        /// </summary>
        [XmlElement("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 表示境内商家结算的卡机构
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 用于垫资打款的外表卡号
        /// </summary>
        [XmlElement("overdraft_out_card_no")]
        public string OverdraftOutCardNo { get; set; }

        /// <summary>
        /// 表示境内商家结算产品的到账时间字段
        /// </summary>
        [XmlElement("postponed_time")]
        public string PostponedTime { get; set; }

        /// <summary>
        /// 表示境内商家结算协议里的结算汇总方式字段
        /// </summary>
        [XmlElement("settle_way")]
        public string SettleWay { get; set; }
    }
}
