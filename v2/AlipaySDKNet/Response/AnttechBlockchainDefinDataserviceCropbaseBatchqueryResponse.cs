using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceCropbaseBatchqueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinDataserviceCropbaseBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 农作物基础信息列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("crops_complex_info")]
        public List<CropsComplexInfo> DataList { get; set; }

        /// <summary>
        /// 页码，默认0
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总量
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
