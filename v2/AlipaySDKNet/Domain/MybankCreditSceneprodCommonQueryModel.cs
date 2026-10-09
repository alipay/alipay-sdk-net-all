using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSceneprodCommonQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSceneprodCommonQueryModel : AopObject
    {
        /// <summary>
        /// 网商申请号
        /// </summary>
        [XmlElement("app_seq_no")]
        public string AppSeqNo { get; set; }

        /// <summary>
        /// 代偿数据查询，不同查询场景示例数据不同，可同时包含多个场景查询。
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 代偿数据查询场景
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 机构编码，机构接入场景金融平台时分配，固定值
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 产品编码，场景金融平台给机构提供的产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 本次请求流水号，全局唯一
        /// </summary>
        [XmlElement("seq_no")]
        public string SeqNo { get; set; }
    }
}
