using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignUnicardCardUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignUnicardCardUseModel : AopObject
    {
        /// <summary>
        /// 权益使用接口，商户备注扩展信息
        /// </summary>
        [XmlElement("biz_memo")]
        public string BizMemo { get; set; }

        /// <summary>
        /// 参数名：外部业务单号 应用场景：与支付宝的一个业务单号进行绑定，后续可以通过该业务单号进行查询 如何获取：接口使用方自行生成，为了数据查询的准确性，应该确保该单号的唯一性
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 权益使用交易时间，商户请求中填入交易时间。
        /// </summary>
        [XmlElement("trade_date")]
        public string TradeDate { get; set; }

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
