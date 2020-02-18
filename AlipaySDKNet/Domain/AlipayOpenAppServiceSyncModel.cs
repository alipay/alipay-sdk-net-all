using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServiceSyncModel : AopObject
    {
        /// <summary>
        /// 服务地址
        /// </summary>
        [XmlArray("address")]
        [XmlArrayItem("service_address_simple_v_o")]
        public List<ServiceAddressSimpleVO> Address { get; set; }

        /// <summary>
        /// 服务属性
        /// </summary>
        [XmlElement("attributes")]
        public ServiceAttributeSimpleVO Attributes { get; set; }

        /// <summary>
        /// 外部提供的能够标示这个服务的唯一id，如果spec+biz_id在我们库里面存在，我们会做服务的更新操作
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 服务所属类目id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 时间戳，平台会基于时间戳做并发控制
        /// </summary>
        [XmlElement("date_timestamp")]
        public long DateTimestamp { get; set; }

        /// <summary>
        /// 服务粒度
        /// </summary>
        [XmlElement("granularity_type")]
        public string GranularityType { get; set; }

        /// <summary>
        /// 服务的logo图片
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 服务区域
        /// </summary>
        [XmlArray("region")]
        [XmlArrayItem("service_region_simple_v_o")]
        public List<ServiceRegionSimpleVO> Region { get; set; }

        /// <summary>
        /// 同步服务所属的小程序appId
        /// </summary>
        [XmlElement("service_app_id")]
        public string ServiceAppId { get; set; }

        /// <summary>
        /// 服务联系人
        /// </summary>
        [XmlArray("service_contact")]
        [XmlArrayItem("service_contact_simple_v_o")]
        public List<ServiceContactSimpleVO> ServiceContact { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [XmlElement("simple_desc")]
        public string SimpleDesc { get; set; }

        /// <summary>
        /// 服务规格，平台定义，接入时跟平台申请
        /// </summary>
        [XmlElement("spec_code")]
        public string SpecCode { get; set; }

        /// <summary>
        /// 服务的url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
