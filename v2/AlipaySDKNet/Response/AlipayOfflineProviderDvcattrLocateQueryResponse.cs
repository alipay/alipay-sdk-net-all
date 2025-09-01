using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderDvcattrLocateQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderDvcattrLocateQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备辅助室内定位数据列表
        /// </summary>
        [XmlArray("dvc_attr_for_locate")]
        [XmlArrayItem("dvc_attr_for_locate")]
        public List<DvcAttrForLocate> DvcAttrForLocate { get; set; }

        /// <summary>
        /// 页数，和入参保持一致
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 分页大小，和入参保持一致
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 列表总数量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
