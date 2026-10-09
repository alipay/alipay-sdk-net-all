using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarUnionmemberAccountQueryResponse.
    /// </summary>
    public class AlipayEcoMycarUnionmemberAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 权益凭证ID，无凭证类权益的情况下为空
        /// </summary>
        [XmlArray("benefit_ids")]
        [XmlArrayItem("string")]
        public List<string> BenefitIds { get; set; }

        /// <summary>
        /// 车生活联名会员的会员卡号，入会时生成，同步商户时传给商户
        /// </summary>
        [XmlElement("biz_card_no")]
        public string BizCardNo { get; set; }

        /// <summary>
        /// 入会时间
        /// </summary>
        [XmlElement("open_date")]
        public string OpenDate { get; set; }

        /// <summary>
        /// 商户侧与当前会员身份关联的业务ID（入会时传入，商户查询时原样返回）
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 商户侧的用户ID（入会时传入，商户查询时原样返回）
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 会员状态（已入会/未入会）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [XmlElement("valid_date")]
        public string ValidDate { get; set; }
    }
}
