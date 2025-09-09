using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayContentCommercialMerchantQueryResponse.
    /// </summary>
    public class AlipayContentCommercialMerchantQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回操作人列表
        /// </summary>
        [XmlArray("operator_data")]
        [XmlArrayItem("operator_data")]
        public List<OperatorData> OperatorData { get; set; }
    }
}
