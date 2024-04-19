using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcTransBillQueryResponse.
    /// </summary>
    public class AlipayCommerceEcTransBillQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝转账订单号
        /// </summary>
        [XmlElement("alipay_trans_order_id")]
        public string AlipayTransOrderId { get; set; }

        /// <summary>
        /// 订单金额,精确到两位小数（元）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_trans_type")]
        public string BizTransType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 完结时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 单据状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
