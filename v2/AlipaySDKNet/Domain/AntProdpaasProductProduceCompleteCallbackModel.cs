using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntProdpaasProductProduceCompleteCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntProdpaasProductProduceCompleteCallbackModel : AopObject
    {
        /// <summary>
        /// 是否异常反馈，如果该字段为 Y , 则其余必填字段可不填.如果供应商由于客关原因，认为该任务无法正常完成, 则可以通过完成反馈接口异常完结。
        /// </summary>
        [XmlElement("abnormal_feedback")]
        public string AbnormalFeedback { get; set; }

        /// <summary>
        /// 异常完结反馈原因
        /// </summary>
        [XmlElement("abnormal_reason")]
        public string AbnormalReason { get; set; }

        /// <summary>
        /// 实际已完成生产数量，可以为0.
        /// </summary>
        [XmlElement("actual_amount")]
        public long ActualAmount { get; set; }

        /// <summary>
        /// 供应链需求生产实际完成时间
        /// </summary>
        [XmlElement("actual_end_time")]
        public string ActualEndTime { get; set; }

        /// <summary>
        /// 验码附件信息
        /// </summary>
        [XmlArray("appendix_urls")]
        [XmlArrayItem("supplier_appendix_url")]
        public List<SupplierAppendixUrl> AppendixUrls { get; set; }

        /// <summary>
        /// 是否最后一个批次, Y/N (默认为Y)
        /// </summary>
        [XmlElement("batch_flag")]
        public string BatchFlag { get; set; }

        /// <summary>
        /// 批次号, 用于生产分批反馈完成.批次号由供应商自行定义,只能用于标识当前反馈指令的某一个批次。批次号和批次列表不可同时为空。
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 批次列表数据。批次号和批次列表不可同时为空。
        /// </summary>
        [XmlArray("batchs")]
        [XmlArrayItem("supplier_produce_batch")]
        public List<SupplierProduceBatch> Batchs { get; set; }

        /// <summary>
        /// 附加参数集合
        /// </summary>
        [XmlArray("extend_pros")]
        [XmlArrayItem("supplier_item_attr_field")]
        public List<SupplierItemAttrField> ExtendPros { get; set; }

        /// <summary>
        /// 是否最后一个批次, Y/N (默认为Y)
        /// </summary>
        [XmlElement("last_batch_flag")]
        public string LastBatchFlag { get; set; }

        /// <summary>
        /// 计划生产完成时间, 如果是批次反馈，该参数为供应商计划全部完成的时间.
        /// </summary>
        [XmlElement("plan_end_time")]
        public string PlanEndTime { get; set; }

        /// <summary>
        /// 计划生产开始时间,如果是批次反馈，该参数是供应商计划生产开始时间.
        /// </summary>
        [XmlElement("plan_start_time")]
        public string PlanStartTime { get; set; }

        /// <summary>
        /// 生产指令编号
        /// </summary>
        [XmlElement("produce_order_code")]
        public string ProduceOrderCode { get; set; }
    }
}
