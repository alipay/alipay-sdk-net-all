using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAllocTransferQueryResponse.
    /// </summary>
    public class AlipayFundAllocTransferQueryResponse : AopResponse
    {
        /// <summary>
        /// 分佣的转账时间
        /// </summary>
        [XmlElement("alloc_time")]
        public string AllocTime { get; set; }

        /// <summary>
        /// 分佣金额或退款金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 正向分佣：PAY； 逆向退分佣：REVERSE
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 分佣凭证单号
        /// </summary>
        [XmlElement("certification_no")]
        public string CertificationNo { get; set; }

        /// <summary>
        /// 凭证类型，用来确定certification_no代表的具体业务语义
        /// </summary>
        [XmlElement("certification_type")]
        public string CertificationType { get; set; }

        /// <summary>
        /// 分佣单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 正向分佣请求的外部单号 或 逆向退分佣请求的外部单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 转账状态：FINISHED - 成功
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
