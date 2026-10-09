using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCareerOpenbaseIntentionBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCareerOpenbaseIntentionBatchqueryModel : AopObject
    {
        /// <summary>
        /// 平台批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 外部批次号
        /// </summary>
        [XmlElement("out_batch_no")]
        public string OutBatchNo { get; set; }

        /// <summary>
        /// 调用方提供的外部业务号，长度为1至64位，仅支持英文字母和数字。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
