using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignAppBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdcampaignAppBatchqueryModel : AopObject
    {
        /// <summary>
        /// 选择的创意交互动作类型需从接口获取，该字段类型从前置模版配置接口获取当前创意可提交的落地页类型 alipay.data.dataservice.adcampaign.actionandtemplate.query
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 商家tag
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }
    }
}
