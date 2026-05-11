using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OutBusinessItems Data Structure.
    /// </summary>
    [Serializable]
    public class OutBusinessItems : AopObject
    {
        /// <summary>
        /// 服务项名称
        /// </summary>
        [XmlElement("out_business_name")]
        public string OutBusinessName { get; set; }

        /// <summary>
        /// 服务项订单唯一标识
        /// </summary>
        [XmlElement("out_business_no")]
        public string OutBusinessNo { get; set; }

        /// <summary>
        /// 服务项实收价格单位：分
        /// </summary>
        [XmlElement("out_business_sale_price")]
        public string OutBusinessSalePrice { get; set; }

        /// <summary>
        /// 履约单id
        /// </summary>
        [XmlElement("out_custom_no")]
        public string OutCustomNo { get; set; }

        /// <summary>
        /// 冲销原单据的结算单据号
        /// </summary>
        [XmlElement("out_settle_no")]
        public string OutSettleNo { get; set; }

        /// <summary>
        /// 冲销行为对应的唯一单据号
        /// </summary>
        [XmlElement("out_writeoff_no")]
        public string OutWriteoffNo { get; set; }

        /// <summary>
        /// 门店上的主体id
        /// </summary>
        [XmlElement("to_subject_id")]
        public string ToSubjectId { get; set; }

        /// <summary>
        /// 门店上的主体类型
        /// </summary>
        [XmlElement("to_subject_type")]
        public string ToSubjectType { get; set; }

        /// <summary>
        /// 冲销金额单位：分
        /// </summary>
        [XmlElement("writeoff_price")]
        public string WriteoffPrice { get; set; }

        /// <summary>
        /// 冲销时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("writeoff_time")]
        public string WriteoffTime { get; set; }
    }
}
