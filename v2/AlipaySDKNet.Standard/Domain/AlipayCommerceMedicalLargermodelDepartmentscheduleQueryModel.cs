using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelDepartmentscheduleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalLargermodelDepartmentscheduleQueryModel : AopObject
    {
        /// <summary>
        /// 来源渠道 健康管家渠道码：HEALTH_BUTLER_REGISTER 安诊儿：AN_ZHEN_ER_REGISTER 挂号频道：CHANNEL_SEARCH_REGISTER
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 意图识别城市编码列表
        /// </summary>
        [XmlArray("city_code_list")]
        [XmlArrayItem("string")]
        public List<string> CityCodeList { get; set; }

        /// <summary>
        /// 意图识别区域编码列表
        /// </summary>
        [XmlArray("district_code_list")]
        [XmlArrayItem("string")]
        public List<string> DistrictCodeList { get; set; }

        /// <summary>
        /// 降级兜底标记： 默认：false true: 若query召回不到，走兜底召回策略 false: 不使用兜底召回策略
        /// </summary>
        [XmlElement("downgrade_flag")]
        public bool DowngradeFlag { get; set; }

        /// <summary>
        /// {}
        /// </summary>
        [XmlElement("extract_item_score_info")]
        public ExtractItemScoreInfo ExtractItemScoreInfo { get; set; }

        /// <summary>
        /// {}
        /// </summary>
        [XmlElement("filter_item")]
        public FilterItem FilterItem { get; set; }

        /// <summary>
        /// 意图识别医院级别列表
        /// </summary>
        [XmlArray("hos_grade_list")]
        [XmlArrayItem("string")]
        public List<string> HosGradeList { get; set; }

        /// <summary>
        /// 针对医院机构搜索意图
        /// </summary>
        [XmlArray("hos_institution_code_list")]
        [XmlArrayItem("string")]
        public List<string> HosInstitutionCodeList { get; set; }

        /// <summary>
        /// 意图识别医院名称列表
        /// </summary>
        [XmlArray("hos_name_list")]
        [XmlArrayItem("string")]
        public List<string> HosNameList { get; set; }

        /// <summary>
        /// 针对单医院院区搜索意图
        /// </summary>
        [XmlArray("hos_uniq_code_list")]
        [XmlArrayItem("string")]
        public List<string> HosUniqCodeList { get; set; }

        /// <summary>
        /// LBS纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// LBS精度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 分页key
        /// </summary>
        [XmlElement("page_key")]
        public string PageKey { get; set; }

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
        /// 意图识别省份编码列表
        /// </summary>
        [XmlArray("province_code_list")]
        [XmlArrayItem("string")]
        public List<string> ProvinceCodeList { get; set; }

        /// <summary>
        /// 用户输入文本
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// {"startDate":"2025-03-28","endDate":"2025-03-29"}
        /// </summary>
        [XmlElement("register_date")]
        public RegisterDate RegisterDate { get; set; }

        /// <summary>
        /// 场景编码，枚举值 管家APP: HEALTH_BUTLER_APP  管家小程序：HEALTH_BUTLER 安诊儿APP: AN_ZHEN_ER_APP 安诊儿小程序 AN_ZHEN_ER 挂号频道小程序 CHANNEL_SEARCH
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 回传缓存的key
        /// </summary>
        [XmlElement("second_page_key")]
        public string SecondPageKey { get; set; }

        /// <summary>
        /// 意图识别标准科室名称列表
        /// </summary>
        [XmlArray("univ_department_name_list")]
        [XmlArrayItem("string")]
        public List<string> UnivDepartmentNameList { get; set; }

        /// <summary>
        /// 用户定位城市编码
        /// </summary>
        [XmlElement("user_city_code")]
        public string UserCityCode { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户定位省份编码
        /// </summary>
        [XmlElement("user_province_code")]
        public string UserProvinceCode { get; set; }
    }
}
