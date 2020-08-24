using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceInfo : AopObject
    {
        /// <summary>
        /// 支付宝端内地址
        /// </summary>
        [XmlElement("alipay_url")]
        public string AlipayUrl { get; set; }

        /// <summary>
        /// 服务审核状态
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 服务简介
        /// </summary>
        [XmlElement("detail_desc")]
        public string DetailDesc { get; set; }

        /// <summary>
        /// 服务颗粒度
        /// </summary>
        [XmlElement("granularity_type")]
        public string GranularityType { get; set; }

        /// <summary>
        /// 服务关键词
        /// </summary>
        [XmlArray("key_words")]
        [XmlArrayItem("string")]
        public List<string> KeyWords { get; set; }

        /// <summary>
        /// logo的CDN地址
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 服务主状态
        /// </summary>
        [XmlElement("major_status")]
        public string MajorStatus { get; set; }

        /// <summary>
        /// 服务归属的小程序ID
        /// </summary>
        [XmlElement("ref_app_id")]
        public string RefAppId { get; set; }

        /// <summary>
        /// 服务归属的父服务编码
        /// </summary>
        [XmlElement("ref_service_code")]
        public string RefServiceCode { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务简单描述
        /// </summary>
        [XmlElement("simple_desc")]
        public string SimpleDesc { get; set; }

        /// <summary>
        /// 服务提供方ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 服务提供方类型
        /// </summary>
        [XmlElement("supplier_type")]
        public string SupplierType { get; set; }
    }
}
