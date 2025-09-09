using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyCommunitySaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyCommunitySaveModel : AopObject
    {
        /// <summary>
        /// 执行动作 新增：ADD 更新：UPDATE
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

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
        /// 项目ID,新增时非必填，更新时与外部项目ID二选一
        /// </summary>
        [XmlElement("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [XmlElement("community_name")]
        public string CommunityName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("contact_number")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// 自定义配置
        /// </summary>
        [XmlElement("custom_config")]
        public CustomConfigVO CustomConfig { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

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
        /// 是否启用消控室 true|false true:创建消控室 false:删除消控室
        /// </summary>
        [XmlElement("enable_monitor_room")]
        public bool EnableMonitorRoom { get; set; }

        /// <summary>
        /// 位置授权配置
        /// </summary>
        [XmlElement("location_auth_config")]
        public LocationAuthConfigVO LocationAuthConfig { get; set; }

        /// <summary>
        /// 外部项目ID，新增时必填，更新时与项目ID二选一
        /// </summary>
        [XmlElement("out_community_id")]
        public string OutCommunityId { get; set; }

        /// <summary>
        /// 一方报事配置
        /// </summary>
        [XmlElement("patrol_report_config")]
        public SavePatrolReportConfigVO PatrolReportConfig { get; set; }

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
        /// 门禁视频配置 enableMonitorRoom=true必填
        /// </summary>
        [XmlElement("visitor_config")]
        public VisitorConfigVO VisitorConfig { get; set; }
    }
}
