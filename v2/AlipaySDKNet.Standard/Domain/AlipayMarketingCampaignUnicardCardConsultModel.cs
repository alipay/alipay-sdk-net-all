using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignUnicardCardConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignUnicardCardConsultModel : AopObject
    {
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
        /// 支付宝分配给每个用户的用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
