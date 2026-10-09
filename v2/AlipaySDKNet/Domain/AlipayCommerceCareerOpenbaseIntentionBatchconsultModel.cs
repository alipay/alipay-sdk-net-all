using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCareerOpenbaseIntentionBatchconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCareerOpenbaseIntentionBatchconsultModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("batch_details")]
        [XmlArrayItem("career_open_base_intention_ladar_batch_detail")]
        public List<CareerOpenBaseIntentionLadarBatchDetail> BatchDetails { get; set; }

        /// <summary>
        /// 外部批次号，需要保证全局唯一，相同 out_batch_no 重复提交批次会被拒绝。
        /// </summary>
        [XmlElement("out_batch_no")]
        public string OutBatchNo { get; set; }
    }
}
