using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchOrderDetailDataServiceItems Data Structure.
    /// </summary>
    [Serializable]
    public class SearchOrderDetailDataServiceItems : AopObject
    {
        /// <summary>
        /// 服务工单详情area_codes
        /// </summary>
        [XmlElement("area_codes")]
        public string AreaCodes { get; set; }

        /// <summary>
        /// carrier_code
        /// </summary>
        [XmlElement("carrier_code")]
        public string CarrierCode { get; set; }

        /// <summary>
        /// 服务工单数据carrier_list
        /// </summary>
        [XmlElement("carrier_list")]
        public string CarrierList { get; set; }

        /// <summary>
        /// 服务工单category_attribute_value
        /// </summary>
        [XmlElement("category_attribute_value")]
        public string CategoryAttributeValue { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("category_ids")]
        public string CategoryIds { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// img地址
        /// </summary>
        [XmlElement("img")]
        public string Img { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [XmlElement("key_word")]
        public string KeyWord { get; set; }

        /// <summary>
        /// 关键词列表
        /// </summary>
        [XmlElement("key_word_list")]
        public string KeyWordList { get; set; }

        /// <summary>
        /// logo图片地址
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("parent_service_code")]
        public string ParentServiceCode { get; set; }

        /// <summary>
        /// 服务工单详情region
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// serv_search_catalogs
        /// </summary>
        [XmlElement("serv_search_catalogs")]
        public string ServSearchCatalogs { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [XmlElement("serv_search_keywords")]
        public string ServSearchKeywords { get; set; }

        /// <summary>
        /// 2020112321000021082348
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务结束时间
        /// </summary>
        [XmlElement("service_time_end")]
        public string ServiceTimeEnd { get; set; }

        /// <summary>
        /// 服务开始时间
        /// </summary>
        [XmlElement("service_time_start")]
        public string ServiceTimeStart { get; set; }

        /// <summary>
        /// 服务短描述
        /// </summary>
        [XmlElement("short_desc")]
        public string ShortDesc { get; set; }

        /// <summary>
        /// 应用标识
        /// </summary>
        [XmlElement("spec_code")]
        public string SpecCode { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
