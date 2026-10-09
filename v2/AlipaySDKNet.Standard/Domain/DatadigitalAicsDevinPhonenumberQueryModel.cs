using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAicsDevinPhonenumberQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAicsDevinPhonenumberQueryModel : AopObject
    {
        /// <summary>
        /// 业务场景描述
        /// </summary>
        [XmlElement("business_scene_desc")]
        public string BusinessSceneDesc { get; set; }

        /// <summary>
        /// 查询结束时间（毫秒时间戳）
        /// </summary>
        [XmlElement("gmt_end")]
        public long GmtEnd { get; set; }

        /// <summary>
        /// 查询起始时间（毫秒时间戳）
        /// </summary>
        [XmlElement("gmt_start")]
        public long GmtStart { get; set; }

        /// <summary>
        /// 当前页码，默认1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数，默认10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 电话号码（筛选）
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        [XmlElement("phone_usage")]
        public string PhoneUsage { get; set; }

        /// <summary>
        /// 路由类型
        /// </summary>
        [XmlElement("route_type")]
        public long RouteType { get; set; }

        /// <summary>
        /// 路由值
        /// </summary>
        [XmlElement("route_value")]
        public string RouteValue { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("route_values")]
        [XmlArrayItem("string")]
        public List<string> RouteValues { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
