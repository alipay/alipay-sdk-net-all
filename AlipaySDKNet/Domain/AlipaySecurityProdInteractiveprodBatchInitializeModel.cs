using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdInteractiveprodBatchInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdInteractiveprodBatchInitializeModel : AopObject
    {
        /// <summary>
        /// 全局唯一id，标识一次任务
        /// </summary>
        [XmlElement("batch_biz_id")]
        public string BatchBizId { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 商品场景
        /// </summary>
        [XmlElement("commodity_scene")]
        public string CommodityScene { get; set; }

        /// <summary>
        /// 当前任务的数据条数
        /// </summary>
        [XmlElement("data_count")]
        public long DataCount { get; set; }

        /// <summary>
        /// csv文件下载地址，csv文件列头，为各个属性key
        /// </summary>
        [XmlElement("data_url")]
        public string DataUrl { get; set; }

        /// <summary>
        /// 扩展参数，JSON格式
        /// </summary>
        [XmlElement("ext_params")]
        public string ExtParams { get; set; }

        /// <summary>
        /// 登录系统的userId
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 登录系统的userId
        /// </summary>
        [XmlElement("operator_open_id")]
        public string OperatorOpenId { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [XmlElement("task_desc")]
        public string TaskDesc { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
