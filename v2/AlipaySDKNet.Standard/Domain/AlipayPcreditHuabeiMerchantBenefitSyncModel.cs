using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantBenefitSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiMerchantBenefitSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝统一用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 额外信息 Map JSON格式 {"k1":"v1","k2":"v2"}
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("gmt_operate")]
        public string GmtOperate { get; set; }

        /// <summary>
        /// 花呗侧权益实例id
        /// </summary>
        [XmlElement("hb_instance_id")]
        public string HbInstanceId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 权益状态 0:正常 1:已使用 2:退款中 3:退款成功 4:已过期
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
