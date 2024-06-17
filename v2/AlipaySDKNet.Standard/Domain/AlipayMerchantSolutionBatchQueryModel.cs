using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantSolutionBatchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantSolutionBatchQueryModel : AopObject
    {
        /// <summary>
        /// 提报成功后，支付宝侧生成的提报批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 外部批次号，在外部系统中唯一标识一个提报批次
        /// </summary>
        [XmlElement("out_batch_no")]
        public string OutBatchNo { get; set; }
    }
}
