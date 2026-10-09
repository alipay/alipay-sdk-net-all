using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodItemQueryResponse.
    /// </summary>
    public class AlipayInsSceneInsserviceprodItemQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("health_service_item")]
        public List<HealthServiceItem> DataList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 当前页的数据条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询商品的总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
