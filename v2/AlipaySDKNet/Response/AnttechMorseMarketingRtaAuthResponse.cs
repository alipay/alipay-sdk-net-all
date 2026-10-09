using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingRtaAuthResponse.
    /// </summary>
    public class AnttechMorseMarketingRtaAuthResponse : AopResponse
    {
        /// <summary>
        /// 预授权成功的活动id列表
        /// </summary>
        [XmlArray("auth_campaign_ids")]
        [XmlArrayItem("string")]
        public List<string> AuthCampaignIds { get; set; }

        /// <summary>
        /// 业务唯一标识，标识本次查询的唯一识别号，用于问题定位
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
