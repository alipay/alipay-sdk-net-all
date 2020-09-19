using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppAppcontentPoiSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppAppcontentPoiSyncModel : AopObject
    {
        /// <summary>
        /// 具体地址的描述
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 支付宝端内小程序地址
        /// </summary>
        [XmlElement("alipay_url")]
        public string AlipayUrl { get; set; }

        /// <summary>
        /// 高德标准的POI ID
        /// </summary>
        [XmlElement("amap_poi_id")]
        public string AmapPoiId { get; set; }

        /// <summary>
        /// 应用内容属性
        /// </summary>
        [XmlArray("attributes")]
        [XmlArrayItem("attribute")]
        public List<Attribute> Attributes { get; set; }

        /// <summary>
        /// 业务来源，如“社区生活”。 商户申请/调试接口过程中，由支付宝侧业务接口人分配确认。
        /// </summary>
        [XmlElement("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 业务唯一ID，APPID视角下唯一。支付宝侧会通过biz_source + appId + biz_unique_id作为联合主键，进行相应的创建或者更新操作。
        /// </summary>
        [XmlElement("biz_unique_id")]
        public string BizUniqueId { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("contact_tele")]
        public string ContactTele { get; set; }

        /// <summary>
        /// 维度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// poi的logo/头像
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 具体的地点名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 逗号分隔的图片数组，最多5个
        /// </summary>
        [XmlArray("photos")]
        [XmlArrayItem("string")]
        public List<string> Photos { get; set; }
    }
}
