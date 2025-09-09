using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeBatchFinishQueryResponse.
    /// </summary>
    public class AlipayTradeBatchFinishQueryResponse : AopResponse
    {
        /// <summary>
        /// 关账汇总的查询返回列表，单个关账查询结果的处理规则如下：如查询不存在，则不返回；如单个查询异常，也会过滤不返回；
        /// </summary>
        [XmlArray("batch_list")]
        [XmlArrayItem("batch_finish_info")]
        public List<BatchFinishInfo> BatchList { get; set; }
    }
}
