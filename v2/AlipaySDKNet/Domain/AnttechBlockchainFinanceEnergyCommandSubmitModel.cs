using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceEnergyCommandSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceEnergyCommandSubmitModel : AopObject
    {
        /// <summary>
        /// 设备指令内容
        /// </summary>
        [XmlElement("command_content")]
        public CommandContent CommandContent { get; set; }

        /// <summary>
        /// 设备实体ID
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 设备指令功能类型
        /// </summary>
        [XmlElement("function_type")]
        public string FunctionType { get; set; }

        /// <summary>
        /// 可信价值服务中心产品的合约码，由蚂蚁业务同学完成签约后给到商户
        /// </summary>
        [XmlElement("product_agreement_code")]
        public string ProductAgreementCode { get; set; }

        /// <summary>
        /// 业务幂等键，用户调用时需要保证不同请求requestId唯一。
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否定时日程
        /// </summary>
        [XmlElement("scheduler_flag")]
        public string SchedulerFlag { get; set; }

        /// <summary>
        /// 定时日程为“是”时必填
        /// </summary>
        [XmlElement("scheduler_time")]
        public string SchedulerTime { get; set; }
    }
}
