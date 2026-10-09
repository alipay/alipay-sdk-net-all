using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitEnrollRuleData Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitEnrollRuleData : AopObject
    {
        /// <summary>
        /// 招商方案可提报的券的规则列表，不同的券有不同的规则。
        /// </summary>
        [XmlArray("recruit_voucher_rules")]
        [XmlArrayItem("recruit_voucher_rule")]
        public List<RecruitVoucherRule> RecruitVoucherRules { get; set; }

        /// <summary>
        /// 素材的要求，json字符串，使用时需要把此字符串解析成json对象。 field：提报的字段key label：字段说明 required：是否必填 type：字段类型。包含：图片（IMAGE）、文本（TEXT）、数据源（DATASOURCE）等 rules：字段约束规则   图片（IMAGE）：     image_size：图片宽高，单位是PX     file_type：图片类型     file_size：表示图片大小的最大值，单位是KB     image_aspect_ratio: 图片宽高比例   文本（TEXT）：     unicode_length：文本长度，单位为Byte   数据源（DATASOURCE）：     unicode_length：文本长度，单位为Byte
        /// </summary>
        [XmlElement("schema")]
        public string Schema { get; set; }
    }
}
