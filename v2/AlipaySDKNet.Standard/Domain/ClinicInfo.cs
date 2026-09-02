using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ClinicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ClinicInfo : AopObject
    {
        /// <summary>
        /// 期望就诊结束时间
        /// </summary>
        [XmlElement("appointment_end_time")]
        public string AppointmentEndTime { get; set; }

        /// <summary>
        /// 期望就诊开始时间
        /// </summary>
        [XmlElement("appointment_start_time")]
        public string AppointmentStartTime { get; set; }

        /// <summary>
        /// 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("appointment_time")]
        public string AppointmentTime { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 就诊城市
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 就诊类别
        /// </summary>
        [XmlElement("clinic_category")]
        public string ClinicCategory { get; set; }

        /// <summary>
        /// 当前所在城市
        /// </summary>
        [XmlElement("current_city")]
        public string CurrentCity { get; set; }

        /// <summary>
        /// 就诊科室
        /// </summary>
        [XmlElement("department")]
        public string Department { get; set; }

        /// <summary>
        /// 区县编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 就诊区县
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 期望就诊专家
        /// </summary>
        [XmlElement("expert")]
        public string Expert { get; set; }

        /// <summary>
        /// 医院详细地址
        /// </summary>
        [XmlElement("hospital_address")]
        public string HospitalAddress { get; set; }

        /// <summary>
        /// 就诊医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 多个URL列表
        /// </summary>
        [XmlArray("medical_record_url_list")]
        [XmlArrayItem("string")]
        public List<string> MedicalRecordUrlList { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 就诊省份
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }
    }
}
