using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAssistantCbumemberpackageCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAssistantCbumemberpackageCreateModel : AopObject
    {
        /// <summary>
        /// 1688侧标识B端用户的唯一身份ID
        /// </summary>
        [XmlElement("ali_id")]
        public string AliId { get; set; }

        /// <summary>
        /// 权益包指定生效时间非必填，默认不要填写，只有需要权益包不立即生效，在后续指定时间点生效的场景下需要传入。如果传入时间早于当前时间，则以当前时间进行生效。且指定的生效时间不得晚于当前时间一个月。
        /// </summary>
        [XmlElement("begin_effect_time")]
        public string BeginEffectTime { get; set; }

        /// <summary>
        /// 1688渠道以会员aliId作为公司唯一标识
        /// </summary>
        [XmlElement("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 合作伙伴侧购买使用当前的会员包的企业全称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 创建会员包是否参与营销活动，营销活动规则为季度会员包赠送15天，年度会员包赠送90天权益，活动默认开启，关闭需要显式传值false
        /// </summary>
        [XmlElement("has_activity")]
        public bool HasActivity { get; set; }

        /// <summary>
        /// 订单编号，是客户在合作伙伴侧下单时的ID，在付费、续费、增购等一个客户可以有多个付费ID，一个ID描述一次购买行为。也是退权益的最小粒度
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
        /// 企信会员产品包定制化配置.仅对product_sku为QX-ZTB-ASSISTANT-STANDARD和QX-TK-ASSISTANT-STANDARD 时生效
        /// </summary>
        [XmlElement("product_config")]
        public EpAssistantProductConfig ProductConfig { get; set; }

        /// <summary>
        /// 企信会员产品sku，由企信分配
        /// </summary>
        [XmlElement("product_sku")]
        public string ProductSku { get; set; }
    }
}
