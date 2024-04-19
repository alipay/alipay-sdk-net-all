using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossBaseAntauthorizeMultiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseAntauthorizeMultiQueryModel : AopObject
    {
        /// <summary>
        /// 基于多维度授权查询的参数
        /// </summary>
        [XmlElement("query")]
        public MultiDimAuthAmountQuery Query { get; set; }

        /// <summary>
        /// 接口查询信息，包含调用接口的系统、人的域账号、调用类型
        /// </summary>
        [XmlElement("query_info")]
        public QueryInfo QueryInfo { get; set; }
    }
}
