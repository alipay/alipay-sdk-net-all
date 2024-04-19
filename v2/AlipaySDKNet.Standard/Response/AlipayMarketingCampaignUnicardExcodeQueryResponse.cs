using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignUnicardExcodeQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignUnicardExcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 兑换码是否可以兑换
        /// </summary>
        [XmlElement("can_exchange")]
        public bool CanExchange { get; set; }

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
        /// 联营卡卡号。 用户在C端开通的联营卡后分配的卡号，目前一个周期的卡号是唯一的，且卡号会对应确定的卡模板id。
        /// </summary>
        [XmlElement("exchange_code")]
        public string ExchangeCode { get; set; }

        /// <summary>
        /// 兑换码过期时间
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 兑换码生成时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 参数名：外部业务单号 应用场景：与支付宝的一个业务单号进行绑定，后续可以通过该业务单号进行查询 如何获取：接口使用方自行生成，为了数据查询的准确性，应该确保该单号的唯一性
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 兑换码状态 取值范围： 1. UNUSED：可使用 2. USED：已使用 3. EXPIRED：已过期 4. INVALID：已失效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 兑换码不可兑换的原因 取值范围： 1. 活动已经结束 2. 兑换码已失效 3. 兑换码已过期 4. 兑换码已使用 5. 兑换码不存在
        /// </summary>
        [XmlElement("un_exchange_cause")]
        public string UnExchangeCause { get; set; }
    }
}
