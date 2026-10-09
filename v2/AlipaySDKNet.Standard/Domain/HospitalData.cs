using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HospitalData Data Structure.
    /// </summary>
    [Serializable]
    public class HospitalData : AopObject
    {
        /// <summary>
        /// 国家重点科室
        /// </summary>
        [XmlElement("country_key_department")]
        public string CountryKeyDepartment { get; set; }

        /// <summary>
        /// 医院地址
        /// </summary>
        [XmlElement("hospital_addr")]
        public string HospitalAddr { get; set; }

        /// <summary>
        /// 医院别名
        /// </summary>
        [XmlElement("hospital_alias")]
        public string HospitalAlias { get; set; }

        /// <summary>
        /// 医院所在城市
        /// </summary>
        [XmlElement("hospital_city")]
        public string HospitalCity { get; set; }

        /// <summary>
        /// 医院所在城市区划
        /// </summary>
        [XmlElement("hospital_district")]
        public string HospitalDistrict { get; set; }

        /// <summary>
        /// 医院等级
        /// </summary>
        [XmlElement("hospital_grade")]
        public string HospitalGrade { get; set; }

        /// <summary>
        /// 医院id
        /// </summary>
        [XmlElement("hospital_id")]
        public string HospitalId { get; set; }

        /// <summary>
        /// 医院纬度
        /// </summary>
        [XmlElement("hospital_lat")]
        public string HospitalLat { get; set; }

        /// <summary>
        /// 医院经度
        /// </summary>
        [XmlElement("hospital_lgt")]
        public string HospitalLgt { get; set; }

        /// <summary>
        /// png格式的医院logo
        /// </summary>
        [XmlElement("hospital_logo")]
        public string HospitalLogo { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 医院标签
        /// </summary>
        [XmlElement("hospital_optag")]
        public string HospitalOptag { get; set; }

        /// <summary>
        /// 医院所在省份
        /// </summary>
        [XmlElement("hospital_province")]
        public string HospitalProvince { get; set; }

        /// <summary>
        /// 医疗定点机构编号
        /// </summary>
        [XmlElement("hospital_standard_code")]
        public string HospitalStandardCode { get; set; }

        /// <summary>
        /// 医院对公电话
        /// </summary>
        [XmlElement("hospital_tel")]
        public string HospitalTel { get; set; }

        /// <summary>
        /// 医院类型
        /// </summary>
        [XmlElement("hospital_type")]
        public string HospitalType { get; set; }

        /// <summary>
        /// 医院放号时间
        /// </summary>
        [XmlElement("hospital_work_time")]
        public string HospitalWorkTime { get; set; }

        /// <summary>
        /// 特色科室
        /// </summary>
        [XmlElement("key_department")]
        public string KeyDepartment { get; set; }

        /// <summary>
        /// 省级重点科室
        /// </summary>
        [XmlElement("province_key_department")]
        public string ProvinceKeyDepartment { get; set; }
    }
}
