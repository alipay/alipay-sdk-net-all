using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EvalueateItem Data Structure.
    /// </summary>
    [Serializable]
    public class EvalueateItem : AopObject
    {
        /// <summary>
        /// 评估指标列表
        /// </summary>
        [XmlArray("evaluate_indicates")]
        [XmlArrayItem("evaluate_indicate")]
        public List<EvaluateIndicate> EvaluateIndicates { get; set; }

        /// <summary>
        /// 评测标准
        /// </summary>
        [XmlElement("evaluate_standard")]
        public string EvaluateStandard { get; set; }

        /// <summary>
        /// 评估类型
        /// </summary>
        [XmlElement("evaluate_type")]
        public string EvaluateType { get; set; }

        /// <summary>
        /// 评估车型图片
        /// </summary>
        [XmlElement("evalueate_model_img")]
        public string EvalueateModelImg { get; set; }

        /// <summary>
        /// 评估报告图片
        /// </summary>
        [XmlElement("evalueate_report_img")]
        public string EvalueateReportImg { get; set; }

        /// <summary>
        /// 商户车型id
        /// </summary>
        [XmlElement("isv_model_id")]
        public string IsvModelId { get; set; }

        /// <summary>
        /// 商户车型名称
        /// </summary>
        [XmlElement("isv_model_name")]
        public string IsvModelName { get; set; }

        /// <summary>
        /// 商户车系id
        /// </summary>
        [XmlElement("isv_series_id")]
        public string IsvSeriesId { get; set; }

        /// <summary>
        /// 商户车系名称
        /// </summary>
        [XmlElement("isv_series_name")]
        public string IsvSeriesName { get; set; }
    }
}
