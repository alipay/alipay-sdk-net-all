using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserQuanyibaoPointdeductSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserQuanyibaoPointdeductSubmitModel : AopObject
    {
        /// <summary>
        /// 权益宝业务号，对一笔兑换业务的唯一标识，可以用来做幂等
        /// </summary>
        [XmlElement("alipay_biz_no")]
        public string AlipayBizNo { get; set; }

        /// <summary>
        /// 支付宝侧用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 扣减状态，权益宝会根据该状态推进后续流程，SUCCESS表示积分扣减成功，FAILED表示扣减失败，PROCESS表示未知，还在处理中
        /// </summary>
        [XmlElement("deduct_status")]
        public string DeductStatus { get; set; }

        /// <summary>
        /// 扣减扩展信息,如透传字段，备注信息等，可以放到扩展信息中
        /// </summary>
        [XmlArray("ext_info_list")]
        [XmlArrayItem("q_y_b_map_info")]
        public List<QYBMapInfo> ExtInfoList { get; set; }

        /// <summary>
        /// 商户app_id维度下的用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号，与权益宝业务号唯一对应
        /// </summary>
        [XmlElement("third_biz_no")]
        public string ThirdBizNo { get; set; }

        /// <summary>
        /// 外部用户账户id
        /// </summary>
        [XmlElement("third_user_id")]
        public string ThirdUserId { get; set; }
    }
}
