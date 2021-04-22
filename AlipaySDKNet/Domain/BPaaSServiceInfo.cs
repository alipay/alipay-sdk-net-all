using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BPaaSServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BPaaSServiceInfo : AopObject
    {
        /// <summary>
        /// 服务demo下载地址
        /// </summary>
        [XmlElement("demo_link")]
        public string DemoLink { get; set; }

        /// <summary>
        /// 服务文档地址
        /// </summary>
        [XmlElement("doc_link")]
        public string DocLink { get; set; }

        /// <summary>
        /// 是否需要签约
        /// </summary>
        [XmlElement("if_sign")]
        public bool IfSign { get; set; }

        /// <summary>
        /// 开发类型，枚举值 public \  direct
        /// </summary>
        [XmlElement("open_type")]
        public string OpenType { get; set; }

        /// <summary>
        /// 服务code
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务类型 "PAY", "支付账单" "FLOW_REALIZE", "流量变现" "USER_OPERATE", "用户运营" "CONTENT_OPERATE", "内容运营" "DATE_SERVICE", "数据服务" "FINANCE_SERVICE", "金融服务" "MANAGERMENT", "经营管理" "OTHER", "其他"
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 服务版本
        /// </summary>
        [XmlElement("service_version")]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// 服务简介
        /// </summary>
        [XmlElement("slogan")]
        public string Slogan { get; set; }
    }
}
