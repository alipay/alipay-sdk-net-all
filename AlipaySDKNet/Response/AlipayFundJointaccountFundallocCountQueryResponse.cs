using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountFundallocCountQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountFundallocCountQueryResponse : AopResponse
    {
        /// <summary>
        /// 自动攒计划的调拨汇总金额（单位为元，必须大于0且最多小数点后两位）
        /// </summary>
        [XmlElement("alloc_amount")]
        public string AllocAmount { get; set; }

        /// <summary>
        /// 自动攒计划的调拨次数
        /// </summary>
        [XmlElement("alloc_times")]
        public long AllocTimes { get; set; }
    }
}
