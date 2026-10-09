using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantQipanCommoninsightQueryResponse.
    /// </summary>
    public class AlipayMerchantQipanCommoninsightQueryResponse : AopResponse
    {
        /// <summary>
        /// 人群洞察分析数据，包含高tgi显著性特征
        /// </summary>
        [XmlElement("portraits_data_tgi")]
        public PortraitsDataTgiVO PortraitsDataTgi { get; set; }
    }
}
