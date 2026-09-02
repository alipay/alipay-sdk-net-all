using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAssistantMembershippackageCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAssistantMembershippackageCreateModel : AopObject
    {
        /// <summary>
        /// 权益包指定生效时间非必填，默认不要填写，只有需要权益包不立即生效，在后续指定时间点生效的场景下需要传入。如果传入时间早于当前时间，则以当前时间进行生效。且指定的生效时间不得晚于当前时间一个月。
        /// </summary>
        [XmlElement("begin_effect_time")]
        public string BeginEffectTime { get; set; }

        /// <summary>
        /// 合作伙伴侧购买使用当前的会员包的企业编号，传递对应的corpid即可，建议传递corpid，但是如果没有有统一社会信用代码，也可以传递统一社会信用代码或者可以唯一标识一家企业的标识.
        /// </summary>
        [XmlElement("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 合作伙伴侧购买使用当前的会员包的企业全称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 企信侧默认开启营销活动，如购买权益时长满一年送90天，不参与活动要显式设置为false
        /// </summary>
        [XmlElement("has_activity")]
        public bool HasActivity { get; set; }

        /// <summary>
        /// 订单编号，是客户在合作伙伴侧下单时的ID，在付费、续费、增购等一个客户可以有多个付费ID，一个ID描述一次购买行为。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 唯一键，幂等控制，同一个id不允许多次购买
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 企信会员产品码，由企信分配
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 企信会员产品包定制化配置.仅对product_sku为QX-ZTB-ASSISTANT-STANDARD和QX-TK-ASSISTANT-STANDARD 是生效
        /// </summary>
        [XmlElement("product_config")]
        public EpAssistantProductConfig ProductConfig { get; set; }

        /// <summary>
        /// 企信会员产品包，由企信分配
        /// </summary>
        [XmlElement("product_sku")]
        public string ProductSku { get; set; }
    }
}
