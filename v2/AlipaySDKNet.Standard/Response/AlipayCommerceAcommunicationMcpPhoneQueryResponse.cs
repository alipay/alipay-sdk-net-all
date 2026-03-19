using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationMcpPhoneQueryResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationMcpPhoneQueryResponse : AopResponse
    {
        /// <summary>
        /// 话费订单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 充值面额(单位：元)
        /// </summary>
        [XmlElement("face")]
        public string Face { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 订单完成时间
        /// </summary>
        [XmlElement("gmt_finish")]
        public string GmtFinish { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 运营商中文简称
        /// </summary>
        [XmlElement("isp_abbr_cn")]
        public string IspAbbrCn { get; set; }

        /// <summary>
        /// 充值手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 归属省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 订单状态信息
        /// </summary>
        [XmlElement("status")]
        public OrderStatus Status { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
