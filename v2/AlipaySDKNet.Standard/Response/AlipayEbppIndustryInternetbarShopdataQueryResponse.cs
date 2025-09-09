using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryInternetbarShopdataQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryInternetbarShopdataQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("shop_activity_data")]
        [XmlArrayItem("internetbar_shop_activity_data")]
        public List<InternetbarShopActivityData> ShopActivityData { get; set; }

        /// <summary>
        /// 总数据量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
