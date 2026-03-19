using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalSearchResultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalSearchResultQueryModel : AopObject
    {
        /// <summary>
        /// 账号
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 账号类型，0:支付宝/1:好大夫
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 渠道编码
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 出诊时间
        /// </summary>
        [XmlElement("consultation_hours")]
        public string ConsultationHours { get; set; }

        /// <summary>
        /// 科室ID
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 医生标签
        /// </summary>
        [XmlElement("doctor_tag")]
        public string DoctorTag { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("hos_category")]
        [XmlArrayItem("string")]
        public List<string> HosCategory { get; set; }

        /// <summary>
        /// 医院性质：public/private
        /// </summary>
        [XmlElement("hos_character")]
        public string HosCharacter { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("hos_grade")]
        [XmlArrayItem("string")]
        public List<string> HosGrade { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("hos_tag")]
        [XmlArrayItem("string")]
        public List<string> HosTag { get; set; }

        /// <summary>
        /// 医生所属医院等级：三甲/三级
        /// </summary>
        [XmlElement("hospital_grade")]
        public string HospitalGrade { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("key_list")]
        [XmlArrayItem("key_info")]
        public List<KeyInfo> KeyList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 价格，单位：元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 是 用户输入文本
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 接诊速度，单位：人/小时
        /// </summary>
        [XmlElement("reception_speed")]
        public string ReceptionSpeed { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 搜索类型
        /// </summary>
        [XmlElement("search_type")]
        public string SearchType { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [XmlElement("service")]
        public string Service { get; set; }

        /// <summary>
        /// 排序条件
        /// </summary>
        [XmlElement("sort_condition")]
        public string SortCondition { get; set; }

        /// <summary>
        /// 医生职称：主任医师、主治医师
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 用户定位城市编码
        /// </summary>
        [XmlElement("user_city_code")]
        public string UserCityCode { get; set; }

        /// <summary>
        /// 用户lbs，单位：degrees
        /// </summary>
        [XmlElement("user_latitude")]
        public string UserLatitude { get; set; }

        /// <summary>
        /// 用户lbs，单位：degrees
        /// </summary>
        [XmlElement("user_longitude")]
        public string UserLongitude { get; set; }

        /// <summary>
        /// 用户定位省份编码
        /// </summary>
        [XmlElement("user_province_code")]
        public string UserProvinceCode { get; set; }
    }
}
