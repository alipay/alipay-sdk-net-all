using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCardTemplateModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardTemplateModifyModel : AopObject
    {
        /// <summary>
        /// 接口接入版本
        /// </summary>
        [XmlElement("access_version")]
        public string AccessVersion { get; set; }

        /// <summary>
        /// 业务卡号前缀，由商户指定  支付宝业务卡号生成规则：biz_no_prefix(商户指定)卡号前缀 + biz_no_suffix(实时生成）卡号后缀
        /// </summary>
        [XmlElement("biz_no_prefix")]
        public string BizNoPrefix { get; set; }

        /// <summary>
        /// 业务卡号后缀长度，与biz_no_prefix配合，扣除系统预留2位，剩下对应seq长度。在生成卡号时，若seq位数不足前置补0，若seq位数超出则以实际为准。举例：设为10，其中8位用于生成seq，可覆盖1亿用户，即使seq超过1亿，生成卡号也不报错，但总长度不得超过32位。建议按需设置合适的值，以获得长度一致的业务卡号，建议长度20，性能更好。
        /// </summary>
        [XmlElement("biz_no_suffix_len")]
        public string BizNoSuffixLen { get; set; }

        /// <summary>
        /// "卡行动点配置； 行动点，即用户可点击跳转的区块，类似按钮控件的交互； 单张卡最多定制4个行动点。"
        /// </summary>
        [XmlArray("card_action_list")]
        [XmlArrayItem("template_action_info_d_t_o")]
        public List<TemplateActionInfoDTO> CardActionList { get; set; }

        /// <summary>
        /// 卡级别配置
        /// </summary>
        [XmlArray("card_level_conf")]
        [XmlArrayItem("template_card_level_conf_d_t_o")]
        public List<TemplateCardLevelConfDTO> CardLevelConf { get; set; }

        /// <summary>
        /// 卡特定标签，只供特定业务使用，通常接入无需关注
        /// </summary>
        [XmlElement("card_spec_tag")]
        public string CardSpecTag { get; set; }

        /// <summary>
        /// 栏位信息（卡包详情页面展现的栏位）
        /// </summary>
        [XmlArray("column_info_list")]
        [XmlArrayItem("template_column_info_d_t_o")]
        public List<TemplateColumnInfoDTO> ColumnInfoList { get; set; }

        /// <summary>
        /// "字段规则列表，会员卡开卡过程中，会员卡信息的生成规则， 例如：卡有效期为开卡后两年内有效，则设置为：DATE_IN_FUTURE 注意：商家会员卡场景不支持修改该内容。 "
        /// </summary>
        [XmlArray("field_rule_list")]
        [XmlArrayItem("template_field_rule_d_t_o")]
        public List<TemplateFieldRuleDTO> FieldRuleList { get; set; }

        /// <summary>
        /// "商户动态码通知参数配置： 当write_off_type指定为商户动态码mdbarcode或mdqrcode时必填； 在此字段配置用户打开会员卡时支付宝通知商户生成动态码（发码）的通知参数，如接收通知地址等。"
        /// </summary>
        [XmlElement("mdcode_notify_conf")]
        public TemplateMdcodeNotifyConfDTO MdcodeNotifyConf { get; set; }

        /// <summary>
        /// 会员卡用户领卡配置，在门店等渠道露出领卡入口时，需要部署的商户领卡H5页面地址
        /// </summary>
        [XmlElement("open_card_conf")]
        public TemplateOpenCardConfDTO OpenCardConf { get; set; }

        /// <summary>
        /// 付费外卡配置。只供特定业务使用，通常接入无需关注
        /// </summary>
        [XmlElement("paid_outer_card_conf")]
        public PaidOuterCardTemplateConfDTO PaidOuterCardConf { get; set; }

        /// <summary>
        /// 卡模板投放渠道
        /// </summary>
        [XmlArray("pub_channels")]
        [XmlArrayItem("pub_channel_d_t_o")]
        public List<PubChannelDTO> PubChannels { get; set; }

        /// <summary>
        /// 请求 ID，商户自定义且需确保每次请求唯一。
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 会员卡上架门店 id（支付宝门店id），即发放会员卡的商家门店id。不传则保持创建模板时信息。 注意：不支持删除已有shop_id，仅支持新增。
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// spi应用id，为实现spi.alipay.user.opencard.get接口的app_id。若是第三方代理模式，可以设置成服务商的 APPID 或者是商家自己的 APPID； 若不是第三方代理模式，只能设置商家自己的 APPID。
        /// </summary>
        [XmlElement("spi_app_id")]
        public string SpiAppId { get; set; }

        /// <summary>
        /// "权益信息， 1、在卡包的卡详情页面会自动添加权益栏位，展现会员卡特权， 2、如果添加门店渠道，则可在门店页展现会员卡的权益"
        /// </summary>
        [XmlArray("template_benefit_info")]
        [XmlArrayItem("template_benefit_info_d_t_o")]
        public List<TemplateBenefitInfoDTO> TemplateBenefitInfo { get; set; }

        /// <summary>
        /// 入会表单配置，包括入会表单的字段，入会弹层承接小程序appId等
        /// </summary>
        [XmlElement("template_form_config")]
        public TemplateFormConfig TemplateFormConfig { get; set; }

        /// <summary>
        /// 会员卡模板id。调用alipay.marketing.card.template.create（会员卡模板创建接口）创建模板后同步返回。
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板样式信息
        /// </summary>
        [XmlElement("template_style_info")]
        public TemplateStyleInfoDTO TemplateStyleInfo { get; set; }

        /// <summary>
        /// 卡包详情页面中展现出的卡码（可用于扫码核销）  (1) 静态码 qrcode: 二维码，扫码得商户开卡传入的external_card_no barcode: 条形码，扫码得商户开卡传入的external_card_no  (2) 动态码-支付宝生成码值(动态码会在2分钟左右后过期) dqrcode: 动态二维码，扫码得到的码值可配合会员卡查询接口使用 dbarcode: 动态条形码，扫码得到的码值可配合会员卡查询接口使用  (3) 动态码-商家自主生成码值（码值、时效性都由商户控制） mdqrcode: 商户动态二维码，扫码得商户自主传入的码值 mdbarcode: 商户动态条码，扫码得商户自主传入的码值。 如需使用商户动态码，请联系支付宝技术支持获取相关文档。
        /// </summary>
        [XmlElement("write_off_type")]
        public string WriteOffType { get; set; }
    }
}
