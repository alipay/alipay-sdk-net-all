using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniCloudAosshopQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniCloudAosshopQueryModel : AopObject
    {
        /// <summary>
        /// 用户唯一标识id，可以是支付宝userid、商家自定义的userid，目前是用户user_id的映射
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
        public long PageSize { get; set; }

        /// <summary>
        /// 商家在蚂蚁搜索引擎创建的项目id，调用前需要找蚂蚁技术获取。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 搜索的关键词
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

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
