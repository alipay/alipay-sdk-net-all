using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelDoctorscheduleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalLargermodelDoctorscheduleQueryModel : AopObject
    {
        /// <summary>
        /// 来源渠道，健康管家渠道码：HEALTH_BUTLER_REGISTER 安诊儿： AN_ZHEN_ER_REGISTER 挂号频道： CHANNEL_SEARCH_REGISTER
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 灵知医生id
        /// </summary>
        [XmlElement("doctor_inner_id")]
        public string DoctorInnerId { get; set; }

        /// <summary>
        /// 降级兜底标记： 默认：false true: 若query召回不到，走兜底召回策略 false: 不使用兜底召回策略
        /// </summary>
        [XmlElement("downgrade_flag")]
        public bool DowngradeFlag { get; set; }

        /// <summary>
        /// 筛选项
        /// </summary>
        [XmlElement("filter_item")]
        public FilterItem FilterItem { get; set; }

        /// <summary>
        /// 浙江省xxx医院
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

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
        /// 用户意图识别指定的出诊时间
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
        /// 标准科室名称
        /// </summary>
        [XmlElement("univ_department_name")]
        public string UnivDepartmentName { get; set; }

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
