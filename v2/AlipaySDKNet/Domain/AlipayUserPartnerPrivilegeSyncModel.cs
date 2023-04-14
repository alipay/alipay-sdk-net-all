using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserPartnerPrivilegeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPartnerPrivilegeSyncModel : AopObject
    {
        /// <summary>
        /// 业务发生时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 当前用户在特权周期内已经享有次数
        /// </summary>
        [XmlElement("current_count")]
        public long CurrentCount { get; set; }

        /// <summary>
        /// 当前用户在商家侧的等级英文编码（如 golden 可表示黄金会员），如果商家没有等级体系，则使用默认等级码：member
        /// </summary>
        [XmlElement("grade")]
        public string Grade { get; set; }

        /// <summary>
        /// 当前用户在特权记账周期内最大享有次数。例如，5元话费充值现金券，用户每月可领取并使用一次，那么，在记账周期（月）内用户最大享有次数为 1 次。
        /// </summary>
        [XmlElement("max_count")]
        public long MaxCount { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商家特权的ID，可唯一定位一个特权。可以是特权配置ID或数据库ID
        /// </summary>
        [XmlElement("privilege_id")]
        public string PrivilegeId { get; set; }

        /// <summary>
        /// 当前用户消费商家特权的状态：1.INIT（领取）；2.USED（已使用）；3.EXPIRED（已过期）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商家特权标题或名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 特权记账周期：1.LIFE（终身）；2.YEAR（年）；3.SEASON（季度）；4.MONTH（月）；5.WEEK（周）；6.DAY（日）
        /// </summary>
        [XmlElement("trans_quantum")]
        public string TransQuantum { get; set; }
    }
}
