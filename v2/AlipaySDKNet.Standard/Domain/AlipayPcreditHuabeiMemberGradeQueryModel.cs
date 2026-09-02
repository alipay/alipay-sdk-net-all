using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMemberGradeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiMemberGradeQueryModel : AopObject
    {
        /// <summary>
        /// 查询业务发生时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号。用作幂等控制，注意同步不同的状态时，外部业务号必须不同，否则会被幂等掉，无法正确同步数据。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 注册渠道编码
        /// </summary>
        [XmlElement("register_channel")]
        public string RegisterChannel { get; set; }

        /// <summary>
        /// 业务场景，由支付宝分配，具体值由支付宝定义： D2D：高铁接站场景 INTERFLOW_PARTNER_MEMBER：互通联名会员场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 当pid无法区分商家时，合作商家需要传递此字段
        /// </summary>
        [XmlElement("vendor")]
        public string Vendor { get; set; }
    }
}
