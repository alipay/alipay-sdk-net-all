using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonTaskdataQueryResponse.
    /// </summary>
    public class AlipayCommerceCommonTaskdataQueryResponse : AopResponse
    {
        /// <summary>
        /// 去重后的扫码量
        /// </summary>
        [XmlElement("deduplicate_scan_num")]
        public string DeduplicateScanNum { get; set; }

        /// <summary>
        /// 任务的激励信息
        /// </summary>
        [XmlArray("reward_info")]
        [XmlArrayItem("task_instance_reward_info_d_t_o")]
        public List<TaskInstanceRewardInfoDTO> RewardInfo { get; set; }

        /// <summary>
        /// 任务扫码量
        /// </summary>
        [XmlElement("scan_num")]
        public string ScanNum { get; set; }

        /// <summary>
        /// 任务实例id
        /// </summary>
        [XmlElement("task_instance_id")]
        public string TaskInstanceId { get; set; }

        /// <summary>
        /// 任务模板id
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }

        /// <summary>
        /// 任务交易下单量
        /// </summary>
        [XmlElement("trade_num")]
        public string TradeNum { get; set; }
    }
}
