using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainTradeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainTradeCreateModel : AopObject
    {
        /// <summary>
        /// 买家会员信息
        /// </summary>
        [XmlElement("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 根据具体的场景， 将需要的字段转为json串
        /// </summary>
        [XmlElement("c_repay_plan")]
        public string CRepayPlan { get; set; }

        /// <summary>
        /// 渠道，枚举如下：TMGXBL：天猫供销保理，TYZBL：通用自保理，TMZBL：天猫自保理，DSCYFRZ：大搜车预付融资，CNBILL：菜鸟电票，RZZL： 融资租赁
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 保理场景： 账款到期支付日期， 融租场景： 放款申请单最后一次扣款/还款时间 融租用例： 当前时间: 2021年4月 还款日: 每月20号 分期期数: 12 则计算: 2021.04.20 加 12个月，得出: 2022.04.20 00:00:00
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 由具体业务决定填充内容，JSON格式
        /// </summary>
        [XmlElement("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// 根据文档要求的字段，转json字符串
        /// </summary>
        [XmlElement("file_link")]
        public string FileLink { get; set; }

        /// <summary>
        /// 外部订单号，格式：机构ipRoleId_外部订单号 融租场景:  融租平台IpRoleId_预授权编号(直付通签约号zhifutong_ar_no)
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("out_order_title")]
        public string OutOrderTitle { get; set; }

        /// <summary>
        /// 买家付款账户信息
        /// </summary>
        [XmlElement("pay_account")]
        public Account PayAccount { get; set; }

        /// <summary>
        /// 卖家收款账户信息
        /// </summary>
        [XmlElement("rcv_account")]
        public Account RcvAccount { get; set; }

        /// <summary>
        /// 幂等编号，用于幂等控制，格式：机构ipRoleId_yyyymmddhhmmss_8位uniqId
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("sale_pd_code")]
        public string SalePdCode { get; set; }

        /// <summary>
        /// 卖家会员信息
        /// </summary>
        [XmlElement("seller")]
        public Member Seller { get; set; }

        /// <summary>
        /// 交易金额（单位：元），只支持两位小数点的正数
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// FACTORING：保理，PREPAYMENT：预付融资，CREDITPAY：信任付，PREPAYBILL：电票预付 LEASING: 融租
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
