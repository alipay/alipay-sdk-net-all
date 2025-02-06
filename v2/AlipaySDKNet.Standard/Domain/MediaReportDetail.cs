using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MediaReportDetail Data Structure.
    /// </summary>
    [Serializable]
    public class MediaReportDetail : AopObject
    {
        /// <summary>
        /// 广告位id，如：2023xxxxxxx
        /// </summary>
        [XmlElement("ad_pos_id")]
        public string AdPosId { get; set; }

        /// <summary>
        /// 广告位名称
        /// </summary>
        [XmlElement("ad_pos_name")]
        public string AdPosName { get; set; }

        /// <summary>
        /// 广告位类型
        /// </summary>
        [XmlElement("ad_pos_type")]
        public string AdPosType { get; set; }

        /// <summary>
        /// 广告位类型名称
        /// </summary>
        [XmlElement("ad_pos_type_name")]
        public string AdPosTypeName { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [XmlElement("application_id")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// 点击pv
        /// </summary>
        [XmlElement("click")]
        public long Click { get; set; }

        /// <summary>
        /// 点击率
        /// </summary>
        [XmlElement("click_rate")]
        public string ClickRate { get; set; }

        /// <summary>
        /// 组件被展现的总次数
        /// </summary>
        [XmlElement("component_exposure")]
        public long ComponentExposure { get; set; }

        /// <summary>
        /// 资源位维度预估cpm,千次曝光收入
        /// </summary>
        [XmlElement("cpm")]
        public string Cpm { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 分润前预估广告收入，单位：元
        /// </summary>
        [XmlElement("es_income")]
        public string EsIncome { get; set; }

        /// <summary>
        /// 曝光pv
        /// </summary>
        [XmlElement("exposure")]
        public long Exposure { get; set; }

        /// <summary>
        /// 展位码列表
        /// </summary>
        [XmlElement("space_code_list")]
        public string SpaceCodeList { get; set; }
    }
}
