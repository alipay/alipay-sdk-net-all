using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantSolutionBatchCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantSolutionBatchCancelModel : AopObject
    {
        /// <summary>
        /// 解决方案数据退出中，提报的文件信息
        /// </summary>
        [XmlArray("file_info")]
        [XmlArrayItem("alipay_solution_file")]
        public List<AlipaySolutionFile> FileInfo { get; set; }

        /// <summary>
        /// 外部批次号，在外部系统中唯一标识一个提报批次
        /// </summary>
        [XmlElement("out_batch_no")]
        public string OutBatchNo { get; set; }

        /// <summary>
        /// 标识唯一的解决方案
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
