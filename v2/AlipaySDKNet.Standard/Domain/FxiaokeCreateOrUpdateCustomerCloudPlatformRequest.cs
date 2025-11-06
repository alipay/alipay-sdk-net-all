using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FxiaokeCreateOrUpdateCustomerCloudPlatformRequest Data Structure.
    /// </summary>
    [Serializable]
    public class FxiaokeCreateOrUpdateCustomerCloudPlatformRequest : AopObject
    {
        /// <summary>
        /// 客户编码（唯一）
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 主属性
        /// </summary>
        [XmlElement("crm_code")]
        public string CrmCode { get; set; }

        /// <summary>
        /// 现有云平台
        /// </summary>
        [XmlElement("current_cloud_platform")]
        public string CurrentCloudPlatform { get; set; }

        /// <summary>
        /// 现有云平台数据库
        /// </summary>
        [XmlArray("current_cloud_platform_db")]
        [XmlArrayItem("string")]
        public List<string> CurrentCloudPlatformDb { get; set; }

        /// <summary>
        /// 现有数据量（GB）
        /// </summary>
        [XmlElement("current_data_size")]
        public string CurrentDataSize { get; set; }

        /// <summary>
        /// 现有数据库月消耗（元/月）
        /// </summary>
        [XmlElement("current_db_consumption")]
        public string CurrentDbConsumption { get; set; }

        /// <summary>
        /// 现有云平台总体月消耗（元/月）
        /// </summary>
        [XmlElement("current_month_consumption_total")]
        public string CurrentMonthConsumptionTotal { get; set; }

        /// <summary>
        /// 生命状态
        /// </summary>
        [XmlElement("life_status")]
        public string LifeStatus { get; set; }
    }
}
