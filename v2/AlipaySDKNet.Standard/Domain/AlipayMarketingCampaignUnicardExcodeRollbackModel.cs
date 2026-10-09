using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignUnicardExcodeRollbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignUnicardExcodeRollbackModel : AopObject
    {
        /// <summary>
        /// 支付宝内部生成的兑换码，商家可用该兑换码作为商品出售，用户用兑换码可来支付宝兑换权益。
        /// </summary>
        [XmlElement("exchange_code")]
        public string ExchangeCode { get; set; }

        /// <summary>
        /// 参数名：外部业务单号 应用场景：与支付宝的一个业务单号进行绑定，后续可以通过该业务单号进行查询 如何获取：接口使用方自行生成，为了数据查询的准确性，应该确保该单号的唯一性
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
