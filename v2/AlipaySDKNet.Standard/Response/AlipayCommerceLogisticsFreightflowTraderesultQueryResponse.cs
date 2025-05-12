using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowTraderesultQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowTraderesultQueryResponse : AopResponse
    {
        /// <summary>
        /// 银行操作单号(查询时需要使用)
        /// </summary>
        [XmlElement("bank_operate_no")]
        public string BankOperateNo { get; set; }

        /// <summary>
        /// 业务幂等号(同入参中的业务幂等号一致)
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 交易完结时间 标准格式：yyyyMMddHHmmss
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 本期： ANT_MYBANK(网商银行模式)
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 合作方机构号
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 交易请求时间，标准格式：yyyyMMddHHmmss
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }

        /// <summary>
        /// 状态(成功, 失败, 处理中)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
