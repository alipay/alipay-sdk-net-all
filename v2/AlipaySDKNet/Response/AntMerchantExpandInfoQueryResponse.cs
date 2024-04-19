using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandInfoQueryResponse.
    /// </summary>
    public class AntMerchantExpandInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户基础信息返回接口
        /// </summary>
        [XmlElement("merchant_query_result")]
        public MerchantQueryResult MerchantQueryResult { get; set; }
    }
}
