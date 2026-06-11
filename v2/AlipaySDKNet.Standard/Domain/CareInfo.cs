using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CareInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CareInfo : AopObject
    {
        /// <summary>
        /// 床头卡照片URL
        /// </summary>
        [XmlArray("bed_card_photo_url_list")]
        [XmlArrayItem("string")]
        public List<string> BedCardPhotoUrlList { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 住院科室
        /// </summary>
        [XmlElement("department")]
        public string Department { get; set; }

        /// <summary>
        /// 区县名称
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// true/false
        /// </summary>
        [XmlElement("external_caregiver")]
        public bool ExternalCaregiver { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("hospital_address")]
        public string HospitalAddress { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 本次住院日期
        /// </summary>
        [XmlElement("inpatient_date")]
        public string InpatientDate { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 服务天数
        /// </summary>
        [XmlElement("service_days")]
        public string ServiceDays { get; set; }

        /// <summary>
        /// 入院服务开始时间
        /// </summary>
        [XmlElement("service_start_time")]
        public string ServiceStartTime { get; set; }
    }
}
