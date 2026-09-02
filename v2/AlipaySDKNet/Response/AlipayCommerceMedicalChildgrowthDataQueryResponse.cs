using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalChildgrowthDataQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalChildgrowthDataQueryResponse : AopResponse
    {
        /// <summary>
        /// ConsultantChildInfoVO 儿童基本信息（档案为空时为 null）
        /// </summary>
        [XmlElement("child_info")]
        public ConsultantChildInfoVO ChildInfo { get; set; }

        /// <summary>
        /// 扩展信息 JSON，预留字段，默认 "{}"
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("growth_records")]
        [XmlArrayItem("consultant_growth_record_v_o")]
        public List<ConsultantGrowthRecordVO> GrowthRecords { get; set; }

        /// <summary>
        /// 最新 AI 解读（无有效解读时为 null）
        /// </summary>
        [XmlElement("latest_interpret")]
        public ConsultantInterpretVO LatestInterpret { get; set; }

        /// <summary>
        /// 国标曲线数据：百分位（P3/P25/P50/P75/P90，0-18岁按月龄合并）+ BMI 特殊界值（7-18岁消瘦/肥胖）+ BMI 界值（THRESHOLD）
        /// </summary>
        [XmlElement("national_standard")]
        public ConsultantStandardDataVO NationalStandard { get; set; }
    }
}
