using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayVoyagerMarketingRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayVoyagerMarketingRefundModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("benefit_use_infos")]
        [XmlArrayItem("benefit_use_v_o")]
        public List<BenefitUseVO> BenefitUseInfos { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 业务单号（原冻结时的 bizNo）
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 行业标识
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 正向业务单号（原 bizNo）
        /// </summary>
        [XmlElement("original_biz_no")]
        public string OriginalBizNo { get; set; }

        /// <summary>
        /// 退款金额。全款退传全额，部分退传差额
        /// </summary>
        [XmlElement("refund_amount")]
        public MultiCurrencyMoneyDTO RefundAmount { get; set; }

        /// <summary>
        /// 幂等键，三方生成唯一值
        /// </summary>
        [XmlElement("refund_request_id")]
        public string RefundRequestId { get; set; }

        /// <summary>
        /// 用户 2088 UID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
