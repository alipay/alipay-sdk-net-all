using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectTiansuoQueryResponse.
    /// </summary>
    public class AntMerchantExpandIndirectTiansuoQueryResponse : AopResponse
    {
        /// <summary>
        /// 间连商户pid和对应名称信息
        /// </summary>
        [XmlArray("indirect_isv_info")]
        [XmlArrayItem("indirect_isv_info")]
        public List<IndirectIsvInfo> IndirectIsvInfo { get; set; }
    }
}
