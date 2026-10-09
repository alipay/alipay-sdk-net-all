using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayVoyagerMarketingUnfreezeResponse.
    /// </summary>
    public class AlipayVoyagerMarketingUnfreezeResponse : AopResponse
    {
        /// <summary>
        /// 业务结果信息
        /// </summary>
        [XmlElement("result")]
        public ResultInfoDTO Result { get; set; }

        /// <summary>
        /// 解冻单号,UNFREEZE20260813001
        /// </summary>
        [XmlElement("unfreeze_order_id")]
        public string UnfreezeOrderId { get; set; }
    }
}
