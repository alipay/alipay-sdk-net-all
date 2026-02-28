using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalDoctorRecommendQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalDoctorRecommendQueryModel : AopObject
    {
        /// <summary>
        /// 渠道编码
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 国家标准编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 排除的好大夫doctorid
        /// </summary>
        [XmlArray("exclude_doctor_id")]
        [XmlArrayItem("string")]
        public List<string> ExcludeDoctorId { get; set; }

        /// <summary>
        /// 实验组名称
        /// </summary>
        [XmlElement("experiment_name")]
        public string ExperimentName { get; set; }

        /// <summary>
        /// 好大夫标准二级科室名称
        /// </summary>
        [XmlElement("hdf_department_name")]
        public string HdfDepartmentName { get; set; }

        /// <summary>
        /// 好大夫疾病名称
        /// </summary>
        [XmlElement("hdf_disease_name")]
        public string HdfDiseaseName { get; set; }

        /// <summary>
        /// 好大夫医生标签id列表
        /// </summary>
        [XmlArray("hdf_tag_code")]
        [XmlArrayItem("string")]
        public List<string> HdfTagCode { get; set; }

        /// <summary>
        /// 推荐医生数量
        /// </summary>
        [XmlElement("limit")]
        public long Limit { get; set; }

        /// <summary>
        /// 是否补充病例信息
        /// </summary>
        [XmlElement("need_case")]
        public bool NeedCase { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 是否接受手术治疗
        /// </summary>
        [XmlElement("operation")]
        public bool Operation { get; set; }

        /// <summary>
        /// 患者年龄，单位为天，如10岁，可以传3650。
        /// </summary>
        [XmlElement("patient_age")]
        public long PatientAge { get; set; }

        /// <summary>
        /// 患者性别
        /// </summary>
        [XmlElement("patient_sex")]
        public string PatientSex { get; set; }

        /// <summary>
        /// 患者是否怀孕
        /// </summary>
        [XmlElement("pregnant_receive")]
        public bool PregnantReceive { get; set; }

        /// <summary>
        /// 价格范围单位元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 国家标准编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 医生职称列表
        /// </summary>
        [XmlArray("title")]
        [XmlArrayItem("string")]
        public List<string> Title { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
