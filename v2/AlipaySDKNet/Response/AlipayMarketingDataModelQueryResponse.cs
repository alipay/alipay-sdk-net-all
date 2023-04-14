using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingDataModelQueryResponse.
    /// </summary>
    public class AlipayMarketingDataModelQueryResponse : AopResponse
    {
        /// <summary>
        /// 模型数据。此为参数列表，输出参数为模型字段及模型结果值; 用于数据实验室算法模型对外输出  alias:列别名。此为模型字段  data:列值。此为模型数值
        /// </summary>
        [XmlArray("model_column")]
        [XmlArrayItem("model_column")]
        public List<ModelColumn> ModelColumn { get; set; }
    }
}
