using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionOrderfundTransferResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionOrderfundTransferResponse : AopResponse
    {
        /// <summary>
        /// 行业受理划拨请求的生成操作单号
        /// </summary>
        [XmlElement("operate_no")]
        public string OperateNo { get; set; }
    }
}
