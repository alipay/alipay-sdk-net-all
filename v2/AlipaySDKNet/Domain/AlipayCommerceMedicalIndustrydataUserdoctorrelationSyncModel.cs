using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataUserdoctorrelationSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataUserdoctorrelationSyncModel : AopObject
    {
        /// <summary>
        /// 用户信息同步--USER 医生信息同步-- DOCTOR
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// user  AUTH 授权后 全量同步备选信息 CANCEL 取消授权 ADDITION 增量同步备选信息 doctor  DOCTOR_INTRODUCTION 医生介绍信息 带团队信息 更新 PATIENT_EVALUATION 患者评价信息更新 DOCTOR_VISIT 医生出诊信息更新 DOCTOR_ARTICLE 医生科普信息更新 MEDICAL_RECORD 病程记录信息更新 DELETE_DOCTOR 医生下架 需要删除该医生下的被备选信息
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 医生id，biz_type为doctor时必传，元素最多50个
        /// </summary>
        [XmlArray("doctor_id_list")]
        [XmlArrayItem("string")]
        public List<string> DoctorIdList { get; set; }

        /// <summary>
        /// 用户id，biz_type为USER时必传，元素最多50个
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }

        /// <summary>
        /// 用户id，biz_type为USER时必传，元素最多50个
        /// </summary>
        [XmlArray("user_id_list_open_ids")]
        [XmlArrayItem("string")]
        public List<string> UserIdListOpenIds { get; set; }
    }
}
