using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GfacConsolidationEntryLineDTO Data Structure.
    /// </summary>
    [Serializable]
    public class GfacConsolidationEntryLineDTO : AopObject
    {
        /// <summary>
        /// 业务单据号组合字段，一个业务事件可能关联多业务单据信息（如应收核销应付，关联应收单与应付单），采用组合字段，包括单据类型及其主键ID
        /// </summary>
        [XmlElement("biz_bill_nos_map")]
        public string BizBillNosMap { get; set; }

        /// <summary>
        /// 并账业务要素，扩展的多维业务要素信息（需与核算具体约定）
        /// </summary>
        [XmlElement("biz_elements")]
        public string BizElements { get; set; }

        /// <summary>
        /// （必填）借贷方向：借D、贷C
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// （必填）是否财会分录 和isMaEntry不能同时为false
        /// </summary>
        [XmlElement("is_fa_entry")]
        public bool IsFaEntry { get; set; }

        /// <summary>
        /// （必填）是否管会分录 和isFaEntry不能同时为false
        /// </summary>
        [XmlElement("is_ma_entry")]
        public bool IsMaEntry { get; set; }

        /// <summary>
        /// （必填）凭证行描述（长度限制：240个字节，中文3个字节）
        /// </summary>
        [XmlElement("line_desc")]
        public string LineDesc { get; set; }

        /// <summary>
        /// （必填）凭证行号（幂等维度3）
        /// </summary>
        [XmlElement("line_no")]
        public string LineNo { get; set; }

        /// <summary>
        /// 管会COA类型（管会分录行必填）
        /// </summary>
        [XmlElement("ma_coa_type")]
        public string MaCoaType { get; set; }

        /// <summary>
        /// 管会多维COA组合串，分隔符为. 管会分录必填
        /// </summary>
        [XmlElement("ma_segments_str")]
        public string MaSegmentsStr { get; set; }

        /// <summary>
        /// （必填）原币金额，单位元（注意精度，精度和币种单位有差异时会导致失败）
        /// </summary>
        [XmlElement("orig_amount")]
        public string OrigAmount { get; set; }

        /// <summary>
        /// 多维COA组合串，分隔符为. （财会分录必填）
        /// </summary>
        [XmlElement("segments_str")]
        public string SegmentsStr { get; set; }

        /// <summary>
        /// 本币金额，单位元（注意精度，精度和币种单位有差异时会导致失败）（使用用户汇率及本币信息时必填）
        /// </summary>
        [XmlElement("sob_amount")]
        public string SobAmount { get; set; }

        /// <summary>
        /// 科目编码（财会分录行必填）
        /// </summary>
        [XmlElement("title_code")]
        public string TitleCode { get; set; }
    }
}
