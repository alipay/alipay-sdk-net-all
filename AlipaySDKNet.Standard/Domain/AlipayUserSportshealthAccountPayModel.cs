using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserSportshealthAccountPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserSportshealthAccountPayModel : AopObject
    {
        /// <summary>
        /// 账户流水明细描述，会展示在用户运动币明细列表中
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部渠道
        /// </summary>
        [XmlElement("out_biz_channel")]
        public string OutBizChannel { get; set; }

        /// <summary>
        /// 外部业务号,用于幂等使用
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付运动币数量
        /// </summary>
        [XmlElement("pay_amount")]
        public long PayAmount { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
