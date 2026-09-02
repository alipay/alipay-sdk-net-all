using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInquiryHospitalSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInquiryHospitalSyncModel : AopObject
    {
        /// <summary>
        /// 院区类型
        /// </summary>
        [XmlElement("campus_type")]
        public string CampusType { get; set; }

        /// <summary>
        /// 市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 数据版本号
        /// </summary>
        [XmlElement("data_version")]
        public string DataVersion { get; set; }

        /// <summary>
        /// 区编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 区名称
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 医院地址
        /// </summary>
        [XmlElement("hospital_address")]
        public string HospitalAddress { get; set; }

        /// <summary>
        /// 医院分类
        /// </summary>
        [XmlElement("hospital_category")]
        public string HospitalCategory { get; set; }

        /// <summary>
        /// 三方医院编码
        /// </summary>
        [XmlElement("hospital_id")]
        public string HospitalId { get; set; }

        /// <summary>
        /// 医院简介
        /// </summary>
        [XmlElement("hospital_introduce")]
        public string HospitalIntroduce { get; set; }

        /// <summary>
        /// 医院等级
        /// </summary>
        [XmlElement("hospital_level")]
        public string HospitalLevel { get; set; }

        /// <summary>
        /// 医院 logo
        /// </summary>
        [XmlElement("hospital_logo")]
        public string HospitalLogo { get; set; }

        /// <summary>
        /// 三方医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 医院状态
        /// </summary>
        [XmlElement("hospital_status")]
        public string HospitalStatus { get; set; }

        /// <summary>
        /// 医院电话
        /// </summary>
        [XmlElement("hospital_telephone")]
        public string HospitalTelephone { get; set; }

        /// <summary>
        /// 医院类型
        /// </summary>
        [XmlElement("hospital_type")]
        public string HospitalType { get; set; }

        /// <summary>
        /// 服务商编码
        /// </summary>
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 医院纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 医院经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 平台编码
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 省编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 医院特色
        /// </summary>
        [XmlElement("special")]
        public string Special { get; set; }
    }
}
