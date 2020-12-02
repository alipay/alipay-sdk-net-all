using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransOrderCloseResponse.
    /// </summary>
    public class AlipayFundTransOrderCloseResponse : AopResponse
    {
        /// <summary>
        /// 支付宝转账单据号，查询失败不返回。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 关单了
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
