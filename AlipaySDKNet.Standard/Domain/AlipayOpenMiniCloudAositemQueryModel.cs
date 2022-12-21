using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniCloudAositemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniCloudAositemQueryModel : AopObject
    {
        /// <summary>
        /// 需要进行聚合返回的字段，如需要对搜索的结果的发货地字段进行聚合，则将发货地对应的字段名称传给后段既可
        /// </summary>
        [XmlElement("aggregation_field")]
        public string AggregationField { get; set; }

        /// <summary>
        /// 类目列表，搜索结果只会包含该类目的商品，为空时代表返回所有的商品。多个条件是与的关系。
        /// </summary>
        [XmlArray("cate")]
        [XmlArrayItem("string")]
        public List<string> Cate { get; set; }

        /// <summary>
        /// 用户当前城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 客户端环境
        /// </summary>
        [XmlElement("client_env")]
        public string ClientEnv { get; set; }

        /// <summary>
        /// 用户设备id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 指定要返回的item字段，多个用","分割
        /// </summary>
        [XmlElement("ext_rep_filed")]
        public string ExtRepFiled { get; set; }

        /// <summary>
        /// "字段名":"字段值" 支持指定多个字段是与的关系 单个字段支持 AND 和 OR 操作符号 如要搜索标签为test或者ce的数据，传值的时候通过OR操作符指定:["tags:test OR ce","brand:iphone"] 如要搜索标签为test和ce的数据，传值的时候通过AND操作符指定:["tags:test AND ce"]
        /// </summary>
        [XmlArray("filters")]
        [XmlArrayItem("string")]
        public List<string> Filters { get; set; }

        /// <summary>
        /// 待提权候选集itemId列表，用于调用方指定提升特定i名次tem的范围，搜索接口将对传入的item进行打分，可为空。
        /// </summary>
        [XmlArray("item_id_list")]
        [XmlArrayItem("string")]
        public List<string> ItemIdList { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 用户唯一标识id，可以是支付宝userid、商家自定义的userid等
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 排序字段，"+"对应字段名 按字段正序，"-"对应字段名 按字段降序，支持指定多个。
        /// </summary>
        [XmlArray("orders")]
        [XmlArrayItem("string")]
        public List<string> Orders { get; set; }

        /// <summary>
        /// 当前页码，第一页是1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页的大小，取值范围是1~100
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 32 商家在蚂蚁搜索引擎创建的项目id，调用前需要找蚂蚁技术获取。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 搜索的关键词
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 可以关联到用户的标识信息，用于关联用户的特征。例如手机号、设备号、邮箱等。格式为：“类型#sha256(值）”，类型枚举有：PHONE（手机号）、DEVICE（设备号）、EMAIL（邮箱）等，具体的值是用sha256进行哈希之后的hex表示，多个标识信息用,分割
        /// </summary>
        [XmlElement("relevant_id")]
        public string RelevantId { get; set; }

        /// <summary>
        /// 标签列表，搜索结果只会包含该标签的商品，为空时代表返回所有的商品。多个条件是与的关系。
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 用户唯一标识id，可以是支付宝userid、商家自定义的userid等
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户id的类型，可选值：ALIPAY（支付宝userid）、CUSTOM（商家自定义的userid）
        /// </summary>
        [XmlElement("user_id_type")]
        public string UserIdType { get; set; }
    }
}
