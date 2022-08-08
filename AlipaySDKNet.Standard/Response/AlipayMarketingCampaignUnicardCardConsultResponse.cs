using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignUnicardCardConsultResponse.
    /// </summary>
    public class AlipayMarketingCampaignUnicardCardConsultResponse : AopResponse
    {
        /// <summary>
        /// 联营卡卡状态 取值范围： 1. VALID：已生效 2. EXPIRED：已过期 3. REFUNDED：已退卡 4. NOT_OPEN：未开卡
        /// </summary>
        [XmlElement("card_status")]
        public string CardStatus { get; set; }

        /// <summary>
        /// 联营卡-卡模板id。 限制： 1. 卡模板id和PID目前是一对一的关系； 2. 卡模板id与C端页面一一对应； 3. 同一个商户只能查询和操作自己的卡模板id
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 城市码，具体的城市码与城市的映射关系需要联系支付宝研发人员确定，可能与公开数据有所出入。
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 如果用户可开卡，则直接返回SUCCESS 如果该用户不可开卡，此字段列出不可开卡的原因。 取值范围（字段中返回文字描述）： 1. NOT_OPEN_CITY：不在活动城市 2. SOLD_OUT：库存已售罄 3. ACTIVITY_NOT_START：活动未开始 4. ACTIVITY_ENDED：活动已结束
        /// </summary>
        [XmlElement("consult_result_code")]
        public string ConsultResultCode { get; set; }

        /// <summary>
        /// 当前用户当前周期的联营卡过期时间
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 用户有生效中的卡，返回卡下的满减券信息。
        /// </summary>
        [XmlArray("fix_voucher_infos")]
        [XmlArrayItem("uni_card_fix_voucher_info")]
        public List<UniCardFixVoucherInfo> FixVoucherInfos { get; set; }

        /// <summary>
        /// 联营卡售价 单位为人民币，元。 限制联营卡售价为一个周期的卡售价。 比如9.9元每月
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 联营卡子状态 需要通过卡子状态去进一步细化表达联营卡状态 取值范围： 1. OPENNING：开卡中（父状态为NOT_OPEN) 2. REFUNDING：退卡中（父状态为REFUNDED）
        /// </summary>
        [XmlElement("sub_card_status")]
        public string SubCardStatus { get; set; }

        /// <summary>
        /// 联营卡卡号。 用户在C端开通的联营卡后分配的卡号，目前一个周期的卡号是唯一的，且卡号会对应确定的卡模板id。
        /// </summary>
        [XmlElement("uni_card_no")]
        public string UniCardNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
