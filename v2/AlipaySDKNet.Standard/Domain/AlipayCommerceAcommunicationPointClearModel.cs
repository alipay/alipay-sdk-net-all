using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationPointClearModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationPointClearModel : AopObject
    {
        /// <summary>
        /// 日期类型，可空，为空则为当前时间
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号, 非空且长度不能大于128个字符, 需确保值唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 积分数量，单位为个
        /// </summary>
        [XmlElement("point")]
        public long Point { get; set; }

        /// <summary>
        /// 扣减原因
        /// </summary>
        [XmlElement("trans_memo")]
        public string TransMemo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
