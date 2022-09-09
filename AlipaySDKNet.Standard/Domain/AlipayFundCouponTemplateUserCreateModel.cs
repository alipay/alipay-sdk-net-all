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
        /// 业务场景，不同的业务场景对应不同的发放策略，加入前需和红包侧确定，现有枚举值:standard_template_grant，代表基本皮肤发放策略，业务侧先将要发放的红包皮肤模板和红包侧审核同步，当皮肤模板在红包侧上线后发放
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 外部业务订单号，和user_id一起构成全局唯一，标定一次请求，给一个用户发放一个皮肤实例。
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 销售产品码，商家和支付宝签约的产品码。改接口可传值如下：GIFT_TEMPLATE 标识红包封标准产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 红包皮肤模板id，要发放的红包皮肤对应的模板id，只有业务方相关的皮肤模板有权限发送，需和红包侧确认相关的id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，给哪个用户发放红包皮肤
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
