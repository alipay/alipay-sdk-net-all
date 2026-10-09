using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayVoyagerMarketingCampaignqueryResponse.
    /// </summary>
    public class AlipayVoyagerMarketingCampaignqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("campaign_infos")]
        [XmlArrayItem("voyager_campaign_info")]
        public List<VoyagerCampaignInfo> CampaignInfos { get; set; }

        /// <summary>
        /// 埋点反馈的城市
        /// </summary>
        [XmlElement("feedback_city_code")]
        public string FeedbackCityCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("feedback_ext_info_list")]
        [XmlArrayItem("string")]
        public List<string> FeedbackExtInfoList { get; set; }

        /// <summary>
        /// 业务结果信息
        /// </summary>
        [XmlElement("result")]
        public ResultInfoDTO Result { get; set; }
    }
}
