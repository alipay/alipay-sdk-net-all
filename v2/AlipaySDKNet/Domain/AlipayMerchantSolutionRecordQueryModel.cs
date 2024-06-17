using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantSolutionRecordQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantSolutionRecordQueryModel : AopObject
    {
        /// <summary>
        /// 要查询的数据，上传的数据可以标识唯一一条数据记录。如有多条记录，返回最新状态。
        /// </summary>
        [XmlArray("record_data")]
        [XmlArrayItem("alipay_solution_record")]
        public List<AlipaySolutionRecord> RecordData { get; set; }

        /// <summary>
        /// 标识唯一的解决方案
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
