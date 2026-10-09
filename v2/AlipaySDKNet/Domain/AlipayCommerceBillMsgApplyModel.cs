using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceBillMsgApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceBillMsgApplyModel : AopObject
    {
        /// <summary>
        /// 支付宝userId
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 消费金融机构在支付宝的唯一标识，接入前进行分配
        /// </summary>
        [XmlElement("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [XmlElement("msg_params")]
        public MsgParams MsgParams { get; set; }

        /// <summary>
        /// T-0 （还款日当天）T+1 （逾期1天）T+7 （逾期7天）T+14 （逾期14天）T+30 （逾期30天）
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 蚂蚁开放平台openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
