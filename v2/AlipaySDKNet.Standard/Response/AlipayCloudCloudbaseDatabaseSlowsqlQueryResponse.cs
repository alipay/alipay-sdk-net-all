using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseDatabaseSlowsqlQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseDatabaseSlowsqlQueryResponse : AopResponse
    {
        /// <summary>
        /// 指标数据 （数据样例）{    {     "metrics": "{\"tags\":{},\"values\":[[1709636400000,\"1.0\"],[1709636940000,\"0.0\"],[1709637000000,\"0.0\"]]}" } tags 代表维度 values代表时间戳和监控值
        /// </summary>
        [XmlElement("metrics")]
        public string Metrics { get; set; }
    }
}
