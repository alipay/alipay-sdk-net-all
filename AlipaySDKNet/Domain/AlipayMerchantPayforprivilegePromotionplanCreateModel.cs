using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePromotionplanCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantPayforprivilegePromotionplanCreateModel : AopObject
    {
        /// <summary>
        /// 充享惠方案权益金部分，最小为0，权益金不超过5000元
        /// </summary>
        [XmlElement("benefit")]
        public string Benefit { get; set; }

        /// <summary>
        /// 方案的失效时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 外部业务号，外部商户自行生成，用于幂等控制
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 充享惠方案有偿券部分，消费者充值成功后自动发放，如果不需要有偿券，指定空列表；有偿券的总金额不得超过10000元，且不得超过本金的2倍
        /// </summary>
        [XmlArray("paid_voucher_list")]
        [XmlArrayItem("pay_for_privilege_paid_voucher_config")]
        public List<PayForPrivilegePaidVoucherConfig> PaidVoucherList { get; set; }

        /// <summary>
        /// 充享惠方案本金部分，单位元，必须大于0，本金不超过5000元
        /// </summary>
        [XmlElement("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 方案开始生效时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 创建方案后该方案的状态，ENABLED(启用), DISABLED(停用)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
