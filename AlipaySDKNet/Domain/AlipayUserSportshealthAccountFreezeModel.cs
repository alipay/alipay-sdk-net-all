using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserSportshealthAccountFreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserSportshealthAccountFreezeModel : AopObject
    {
        /// <summary>
        /// 账户流水明细描述，会展示在用户运动币明细列表中
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID,必填
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部渠道,合作业务可联系运动运营配置
        /// </summary>
        [XmlElement("out_biz_channel")]
        public string OutBizChannel { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 冻结支付运动币数量
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
