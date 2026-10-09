using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentAftersaleOrderVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentAftersaleOrderVO : AopObject
    {
        /// <summary>
        /// 支付宝售后单ID
        /// </summary>
        [XmlElement("aftersale_id")]
        public string AftersaleId { get; set; }

        /// <summary>
        /// 售后单状态
        /// </summary>
        [XmlElement("aftersale_status")]
        public string AftersaleStatus { get; set; }

        /// <summary>
        /// 售后类型
        /// </summary>
        [XmlElement("aftersale_type")]
        public string AftersaleType { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 售后单是否完结
        /// </summary>
        [XmlElement("finished")]
        public bool Finished { get; set; }

        /// <summary>
        /// 售后单操作记录列表
        /// </summary>
        [XmlArray("operation_records")]
        [XmlArrayItem("rent_aftersale_operation_record_v_o")]
        public List<RentAftersaleOperationRecordVO> OperationRecords { get; set; }

        /// <summary>
        /// 商户外部售后单号
        /// </summary>
        [XmlElement("out_aftersale_id")]
        public string OutAftersaleId { get; set; }

        /// <summary>
        /// 发起来源
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }
    }
}
