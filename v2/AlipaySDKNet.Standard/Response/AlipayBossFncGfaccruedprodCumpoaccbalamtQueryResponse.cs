using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfaccruedprodCumpoaccbalamtQueryResponse.
    /// </summary>
    public class AlipayBossFncGfaccruedprodCumpoaccbalamtQueryResponse : AopResponse
    {
        /// <summary>
        /// po的累计余额信息
        /// </summary>
        [XmlElement("result_data")]
        public PoCumAccruedBalanceAmtDTO ResultData { get; set; }
    }
}
