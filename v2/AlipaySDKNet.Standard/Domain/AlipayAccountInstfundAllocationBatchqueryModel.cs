using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountInstfundAllocationBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountInstfundAllocationBatchqueryModel : AopObject
    {
        /// <summary>
        /// 最晚执行时间，单位秒
        /// </summary>
        [XmlElement("max_gmt_execute_time")]
        public string MaxGmtExecuteTime { get; set; }

        /// <summary>
        /// 最早执行时间，单位秒
        /// </summary>
        [XmlElement("min_gmt_execute_time")]
        public string MinGmtExecuteTime { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小，单位条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 执行结果状态，SUCCESS/FAIL
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
