using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundCouponTemplateUserCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundCouponTemplateUserCreateModel : AopObject
    {
        /// <summary>
        /// 业务场景，不同的业务场景对应不同的发放策略，加入前需和红包侧确定，现有枚举值:standard_template_grant，代表基本封面发放策略，业务侧先将要发放的红包封面模板和红包侧审核同步，当封面模板在红包侧生效后发放
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 封面兑换码，商家可以在商家平台创建封面时在发放设置中添加，添加后用户可凭该兑换码领取封面
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，给哪个用户发放红包封面
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务订单号，和用户唯一标识一起构成全局唯一，标定一次请求，给一个用户发放一个红包封面实例。
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 销售产品码，商家和支付宝签约的产品码。改接口可传值如下：GIFT_TEMPLATE 标识红包封标准产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 红包封面模板id，要发放的红包封面对应的模板id，只有业务方相关的封面模板有权限发送，需和红包侧确认相关的id；商户自己制作的红包封面对应的封面模板ID可在商家平台中查询。
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，给哪个用户发放红包封面
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
