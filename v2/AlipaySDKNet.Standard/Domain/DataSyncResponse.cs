using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DataSyncResponse Data Structure.
    /// </summary>
    [Serializable]
    public class DataSyncResponse : AopObject
    {
        /// <summary>
        /// 推送批次号
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 处理失败的记录数
        /// </summary>
        [XmlElement("failed_num")]
        public long FailedNum { get; set; }

        /// <summary>
        /// 待重试的数据列表
        /// </summary>
        [XmlArray("retry_data_list")]
        [XmlArrayItem("retry_data_item")]
        public List<RetryDataItem> RetryDataList { get; set; }

        /// <summary>
        /// 处理成功的记录数
        /// </summary>
        [XmlElement("success_num")]
        public long SuccessNum { get; set; }

        /// <summary>
        /// 处理的记录总数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
