using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeFinanceAdvanceApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeFinanceAdvanceApplyModel : AopObject
    {
        /// <summary>
        /// 垫资申请金额，单位元，精确到小数点后2位
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务时间，即接入方认为的垫资申请的业务预期时间
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 扩展字段，会用于保司or其他机构审核用
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部订单号，接入方的业务单据唯一id
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 外部请求号，幂等字段
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 结算单号，预下单时通过ext_info返回
        /// </summary>
        [XmlElement("settlement_no")]
        public string SettlementNo { get; set; }
    }
}
