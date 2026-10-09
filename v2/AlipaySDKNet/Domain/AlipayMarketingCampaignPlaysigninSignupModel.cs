using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPlaysigninSignupModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignPlaysigninSignupModel : AopObject
    {
        /// <summary>
        /// open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 参数名：外部业务单号 应用场景：与支付宝的一个业务单号进行绑定，后续可以通过该业务单号进行查询 如何获取：接口使用方自行生成，为了数据查询的准确性，应该确保该单号的唯一性
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 签到玩法ID
        /// </summary>
        [XmlElement("signin_play_id")]
        public string SigninPlayId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
