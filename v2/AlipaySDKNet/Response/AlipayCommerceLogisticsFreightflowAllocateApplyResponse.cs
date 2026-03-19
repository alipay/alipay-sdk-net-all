using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowAllocateApplyResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowAllocateApplyResponse : AopResponse
    {
        /// <summary>
        /// 和入参中的biz_no一致，查询调拨结果时需要使用
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// mode为网商时为网商返回的操作单号，查询调拨结果时需要使用
        /// </summary>
        [XmlElement("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 当mode为网商银行时： SUCCESS(受理成功)，FAIL(受理失败)，UNKNOWN(受理未知) SUCCESS代表受理成功，后续通过查询接口拿到最终的处理结果 FAIL代表受理失败 UNKNOWN代表结果未知，不能判断为受理成功或者失败   浦发银行暂不支持调拨功能
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
