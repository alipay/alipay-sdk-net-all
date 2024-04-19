using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchOrderdetailQueryResponse.
    /// </summary>
    public class AlipayOpenSearchOrderdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 申请单详情
        /// </summary>
        [XmlElement("data")]
        public SearchOrderDetailData Data { get; set; }
    }
}
