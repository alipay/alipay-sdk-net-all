using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayVoyagerMarketingFreezeResponse.
    /// </summary>
    public class AlipayVoyagerMarketingFreezeResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("benefit_use_infos")]
        [XmlArrayItem("benefit_use_v_o")]
        public List<BenefitUseVO> BenefitUseInfos { get; set; }

        /// <summary>
        /// 冻结单号，后续核销/退款必传
        /// </summary>
        [XmlElement("freeze_order_id")]
        public string FreezeOrderId { get; set; }

        /// <summary>
        /// 业务结果信息
        /// </summary>
        [XmlElement("result")]
        public ResultInfoDTO Result { get; set; }
    }
}
