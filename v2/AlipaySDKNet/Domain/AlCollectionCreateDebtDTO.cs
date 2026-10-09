using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlCollectionCreateDebtDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AlCollectionCreateDebtDTO : AopObject
    {
        /// <summary>
        /// 法催案件信息：包括 结算附件、合同、附件
        /// </summary>
        [XmlArray("files")]
        [XmlArrayItem("collection_file_d_t_o")]
        public List<CollectionFileDTO> Files { get; set; }

        /// <summary>
        /// 截止统计日期
        /// </summary>
        [XmlElement("overdue_end_date")]
        public string OverdueEndDate { get; set; }

        /// <summary>
        /// 开始逾期日期
        /// </summary>
        [XmlElement("overdue_start_date")]
        public string OverdueStartDate { get; set; }

        /// <summary>
        /// 逾期情况说明
        /// </summary>
        [XmlElement("overdue_statement")]
        public string OverdueStatement { get; set; }

        /// <summary>
        /// 逾期金额(元)
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
