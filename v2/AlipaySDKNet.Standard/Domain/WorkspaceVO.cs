using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WorkspaceVO Data Structure.
    /// </summary>
    [Serializable]
    public class WorkspaceVO : AopObject
    {
        /// <summary>
        /// 基于云的api网关
        /// </summary>
        [XmlElement("cloudbase_api_gateway")]
        public string CloudbaseApiGateway { get; set; }

        /// <summary>
        /// 环境说明
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 展示名称
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 服务是否可调用
        /// </summary>
        [XmlElement("enable_cloud_invoke")]
        public bool EnableCloudInvoke { get; set; }

        /// <summary>
        /// 路径是否可用
        /// </summary>
        [XmlElement("enable_http")]
        public bool EnableHttp { get; set; }

        /// <summary>
        /// 环境配置id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 环境名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部ID
        /// </summary>
        [XmlElement("outside_id")]
        public string OutsideId { get; set; }

        /// <summary>
        /// 云产品id
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 云函数产品状态
        /// </summary>
        [XmlElement("product_status")]
        public string ProductStatus { get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [XmlElement("region_name")]
        public string RegionName { get; set; }

        /// <summary>
        /// 环境状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
