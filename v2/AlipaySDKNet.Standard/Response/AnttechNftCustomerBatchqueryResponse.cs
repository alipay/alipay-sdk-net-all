using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftCustomerBatchqueryResponse.
    /// </summary>
    public class AnttechNftCustomerBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 用户资产列表
        /// </summary>
        [XmlArray("asset_list")]
        [XmlArrayItem("user_asset")]
        public List<UserAsset> AssetList { get; set; }

        /// <summary>
        /// 页码，查询时传入
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 页长，查询时传入
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 请求消息id，全链路唯一标记，建议打印，排查问题需提供
        /// </summary>
        [XmlElement("req_msg_id")]
        public string ReqMsgId { get; set; }

        /// <summary>
        /// 列表总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
