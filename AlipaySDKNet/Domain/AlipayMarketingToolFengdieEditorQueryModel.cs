using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieEditorQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolFengdieEditorQueryModel : AopObject
    {
        /// <summary>
        /// H5应用的唯一id，通过<a href="https://opendocs.alipay.com/apis/api_5/alipay.marketing.tool.fengdie.activity.create">alipay.marketing.tool.fengdie.activity.create</a>接口获得。
        /// </summary>
        [XmlElement("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// 在凤蝶编辑器中点击“发布”按钮后，如果发布成功则跳转到该地址
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
