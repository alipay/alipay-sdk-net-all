using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrincipalFinanceDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PrincipalFinanceDetail : AopObject
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 时间格式yyyy-MM-dd
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 现金金额，单位：元
        /// </summary>
        [XmlElement("cash_amount_format")]
        public string CashAmountFormat { get; set; }

        /// <summary>
        /// 授信金额，单位：元
        /// </summary>
        [XmlElement("credit_amount_format")]
        public string CreditAmountFormat { get; set; }

        /// <summary>
        /// 扣款金额，单位：元
        /// </summary>
        [XmlElement("cut_amount_format")]
        public string CutAmountFormat { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("principal_name")]
        public string PrincipalName { get; set; }

        /// <summary>
        /// 红包金额(计入业绩部分)，单位：元
        /// </summary>
        [XmlElement("rebate_red_packet_amount_format")]
        public string RebateRedPacketAmountFormat { get; set; }

        /// <summary>
        /// 红包金额，单位：元
        /// </summary>
        [XmlElement("red_packet_amount_format")]
        public string RedPacketAmountFormat { get; set; }

        /// <summary>
        /// 投放产品名称
        /// </summary>
        [XmlElement("scene_type_name")]
        public string SceneTypeName { get; set; }

        /// <summary>
        /// 消耗类型
        /// </summary>
        [XmlElement("sell_mode_name")]
        public string SellModeName { get; set; }
    }
}
