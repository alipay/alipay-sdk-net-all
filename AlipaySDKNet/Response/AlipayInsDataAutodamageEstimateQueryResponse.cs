using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsDataAutodamageEstimateQueryResponse.
    /// </summary>
    public class AlipayInsDataAutodamageEstimateQueryResponse : AopResponse
    {
        /// <summary>
        /// 商业险保单号
        /// </summary>
        [XmlElement("commercial_policy_no")]
        public string CommercialPolicyNo { get; set; }

        /// <summary>
        /// 交强险
        /// </summary>
        [XmlElement("compulsory_policy_no")]
        public string CompulsoryPolicyNo { get; set; }

        /// <summary>
        /// 发动机号
        /// </summary>
        [XmlElement("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 定损结果详情列表
        /// </summary>
        [XmlArray("estimate_detail_list")]
        [XmlArrayItem("ins_data_autodamage_estimate_result_detail_model")]
        public List<InsDataAutodamageEstimateResultDetailModel> EstimateDetailList { get; set; }

        /// <summary>
        /// 定损单号
        /// </summary>
        [XmlElement("estimate_no")]
        public string EstimateNo { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [XmlElement("frame_no")]
        public string FrameNo { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("license_no")]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 车型厂牌
        /// </summary>
        [XmlElement("model_brand")]
        public string ModelBrand { get; set; }

        /// <summary>
        /// 报案号
        /// </summary>
        [XmlElement("report_no")]
        public string ReportNo { get; set; }

        /// <summary>
        /// 查勘号
        /// </summary>
        [XmlElement("survey_no")]
        public string SurveyNo { get; set; }
    }
}
