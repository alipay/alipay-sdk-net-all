using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignUnicardExcodeCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignUnicardExcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 城市码，具体的城市码与城市的映射关系需要联系支付宝研发人员确定，可能与公开数据有所出入。
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 支付宝内部生成的兑换码，商家可用该兑换码作为商品出售，用户用兑换码可来支付宝兑换权益。
        /// </summary>
        [XmlElement("exchange_code")]
        public string ExchangeCode { get; set; }

        /// <summary>
        /// 生成兑换码的过期时间
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 如果无法生成兑换码，此字段列出无法生成的原因。 取值范围（字段中返回文字描述）： 1. NOT_OPEN_CITY：不在活动城市 2. SOLD_OUT：库存已售罄 3. ACTIVITY_NOT_START：活动未开始 4. ACTIVITY_ENDED：活动已结束
        /// </summary>
        [XmlElement("fail_cause")]
        public string FailCause { get; set; }
    }
}
