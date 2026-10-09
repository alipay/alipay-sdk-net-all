using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceEventInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceEventInfo : AopObject
    {
        /// <summary>
        /// 开票金额（单位元）
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 回票事件外部请求号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 流程处理id
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 流程处理状态
        /// </summary>
        [XmlElement("process_status")]
        public string ProcessStatus { get; set; }

        /// <summary>
        /// 关联的任务Id列表
        /// </summary>
        [XmlArray("task_id_list")]
        [XmlArrayItem("string")]
        public List<string> TaskIdList { get; set; }
    }
}
