using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandMccQueryResponse.
    /// </summary>
    public class AntMerchantExpandMccQueryResponse : AopResponse
    {
        /// <summary>
        /// mcc查询信息结果列表
        /// </summary>
        [XmlArray("mcc_info_list")]
        [XmlArrayItem("mcc_query_info")]
        public List<MccQueryInfo> MccInfoList { get; set; }
    }
}
