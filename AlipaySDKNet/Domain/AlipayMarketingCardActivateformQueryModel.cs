using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCardActivateformQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardActivateformQueryModel : AopObject
    {
        /// <summary>
        /// 开放表单信息查询业务类型，可选类型如下： MEMBER_CARD ：商户会员卡开卡
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 查询用户表单提交信息的请求id。 网页移动应用：将于auth_code 一起通过alipay.marketing.card.activateurl.apply(获取会员卡领卡投放链接)接口callback地址回传。 小程序应用：将于 auth_code 一起通过 my.addCardAuth 接口 success 回调返回。  注意：auth_code（用户授权码）用于换取用户授权令牌 accessToken，后续调用接口需传入accessToken。
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 会员卡模板id。使用会员卡模板创建接口(alipay.marketing.card.template.create)返回的结果
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
