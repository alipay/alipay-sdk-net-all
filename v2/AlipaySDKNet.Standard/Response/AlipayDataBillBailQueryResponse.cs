using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataBillBailQueryResponse.
    /// </summary>
    public class AlipayDataBillBailQueryResponse : AopResponse
    {
        /// <summary>
        /// 保证金明细列表，最多返回5000条
        /// </summary>
        [XmlArray("detail_list")]
        [XmlArrayItem("bail_detail_result")]
        public List<BailDetailResult> DetailList { get; set; }
    }
}
