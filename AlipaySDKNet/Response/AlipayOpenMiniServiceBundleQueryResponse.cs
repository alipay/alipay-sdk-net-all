using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniServiceBundleQueryResponse.
    /// </summary>
    public class AlipayOpenMiniServiceBundleQueryResponse : AopResponse
    {
        /// <summary>
        /// 子服务信息
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("multi_bundle_app_service_result")]
        public List<MultiBundleAppServiceResult> DataList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 数据总数量
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
