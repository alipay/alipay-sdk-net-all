using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignAppleActivityConsultResponse.
    /// </summary>
    public class AlipayMarketingCampaignAppleActivityConsultResponse : AopResponse
    {
        /// <summary>
        /// 活动参与状态 可参与/不可参与
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 苹果绑定状态+已绑定/未绑定
        /// </summary>
        [XmlElement("bind_status")]
        public string BindStatus { get; set; }

        /// <summary>
        /// 错误码 系统异常code 系统返回
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述 错误码对应的文字描述 系统返回
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 操作成功标识【true：成功；false：失败】
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
