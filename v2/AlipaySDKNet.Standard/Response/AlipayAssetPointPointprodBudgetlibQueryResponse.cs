using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetPointPointprodBudgetlibQueryResponse.
    /// </summary>
    public class AlipayAssetPointPointprodBudgetlibQueryResponse : AopResponse
    {
        /// <summary>
        /// 集分宝预算库实体模型，包含预算库编码，余额等
        /// </summary>
        [XmlElement("result")]
        public BudgetLibResult Result { get; set; }
    }
}
