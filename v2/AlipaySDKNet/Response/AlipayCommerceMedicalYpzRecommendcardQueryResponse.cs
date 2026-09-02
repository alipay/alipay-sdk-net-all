using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalYpzRecommendcardQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalYpzRecommendcardQueryResponse : AopResponse
    {
        /// <summary>
        /// 阿福带下载卡
        /// </summary>
        [XmlElement("afu_download_card")]
        public YpzAfuDownloadCardOne AfuDownloadCard { get; set; }

        /// <summary>
        /// 云陪诊云配药卡
        /// </summary>
        [XmlElement("cloud_dispense_medicine_card")]
        public YpzCloudDispenseMedicineCardOne CloudDispenseMedicineCard { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("cloud_dispense_medicine_home_card")]
        [XmlArrayItem("ypz_cloud_dispense_medicine_home_card_one")]
        public List<YpzCloudDispenseMedicineHomeCardOne> CloudDispenseMedicineHomeCard { get; set; }

        /// <summary>
        /// 投放类型
        /// </summary>
        [XmlElement("delivery_type")]
        public string DeliveryType { get; set; }

        /// <summary>
        /// 医生智能体推荐卡
        /// </summary>
        [XmlElement("doctor_agent_card")]
        public YpzDoctorAgentCardOne DoctorAgentCard { get; set; }

        /// <summary>
        /// 线下陪诊卡
        /// </summary>
        [XmlElement("med_accompany_card")]
        public YpzMedAccompanyCardOne MedAccompanyCard { get; set; }

        /// <summary>
        /// NPS卡
        /// </summary>
        [XmlElement("nps_card")]
        public YpzNpsCardOne NpsCard { get; set; }

        /// <summary>
        /// 线下物料卡
        /// </summary>
        [XmlElement("offline_qr_code_card")]
        public YpzOfflineQrCodeCardOne OfflineQrCodeCard { get; set; }

        /// <summary>
        /// 个性化推荐卡
        /// </summary>
        [XmlElement("qa_card")]
        public YpzQaCardOne QaCard { get; set; }
    }
}
