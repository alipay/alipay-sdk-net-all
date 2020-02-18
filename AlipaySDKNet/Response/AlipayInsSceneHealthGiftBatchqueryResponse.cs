using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneHealthGiftBatchqueryResponse.
    /// </summary>
    public class AlipayInsSceneHealthGiftBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 用户从某个source领取成功的保额
        /// </summary>
        [XmlElement("gained_sum_insured_by_source")]
        public string GainedSumInsuredBySource { get; set; }

        /// <summary>
        /// 赠险领取流水列表
        /// </summary>
        [XmlArray("health_gain_flow_list")]
        [XmlArrayItem("ins_health_gain_flow_result")]
        public List<InsHealthGainFlowResult> HealthGainFlowList { get; set; }

        /// <summary>
        /// 健康险赠险险种是否已开通查询结果
        /// </summary>
        [XmlArray("health_gift_batch_already_opened_list")]
        [XmlArrayItem("ins_health_gift_batch_already_opened_result")]
        public List<InsHealthGiftBatchAlreadyOpenedResult> HealthGiftBatchAlreadyOpenedList { get; set; }

        /// <summary>
        /// 健康险赠险待领取权益，目前包含待领取保额，准入
        /// </summary>
        [XmlArray("health_gift_batch_gain_sum_insured_list")]
        [XmlArrayItem("ins_health_gift_batch_gain_sum_insured_result")]
        public List<InsHealthGiftBatchGainSumInsuredResult> HealthGiftBatchGainSumInsuredList { get; set; }

        /// <summary>
        /// 健康险赠险用户总保额查询结果
        /// </summary>
        [XmlArray("health_gift_batch_my_sum_insured_list")]
        [XmlArrayItem("ins_health_gift_batch_my_sum_insured_result")]
        public List<InsHealthGiftBatchMySumInsuredResult> HealthGiftBatchMySumInsuredList { get; set; }

        /// <summary>
        /// 用户生效赠险查询结果
        /// </summary>
        [XmlArray("health_gift_batch_valid_gift_list")]
        [XmlArrayItem("ins_health_gift_batch_valid_gift_result")]
        public List<InsHealthGiftBatchValidGiftResult> HealthGiftBatchValidGiftList { get; set; }

        /// <summary>
        /// 赠险发放流水列表
        /// </summary>
        [XmlArray("health_send_flow_list")]
        [XmlArrayItem("ins_health_send_flow_result")]
        public List<InsHealthSendFlowResult> HealthSendFlowList { get; set; }
    }
}
