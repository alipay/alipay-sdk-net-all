using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpShareHolderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpShareHolderInfo : AopObject
    {
        /// <summary>
        /// 企业实缴明细
        /// </summary>
        [XmlElement("paid_detail")]
        public EpPaidDetailInfo PaidDetail { get; set; }

        /// <summary>
        /// 企业认缴明细
        /// </summary>
        [XmlElement("paid_in_detail")]
        public EpPaidInDetailInfo PaidInDetail { get; set; }

        /// <summary>
        /// 认缴额，单位万元
        /// </summary>
        [XmlElement("paid_in_money")]
        public string PaidInMoney { get; set; }

        /// <summary>
        /// 实缴额，单位万元
        /// </summary>
        [XmlElement("paid_money")]
        public string PaidMoney { get; set; }

        /// <summary>
        /// 股东名称
        /// </summary>
        [XmlElement("share_holder")]
        public string ShareHolder { get; set; }

        /// <summary>
        /// 股东类型
        /// </summary>
        [XmlElement("share_holder_type")]
        public string ShareHolderType { get; set; }

        /// <summary>
        /// 持股比
        /// </summary>
        [XmlElement("share_holding_ratio")]
        public string ShareHoldingRatio { get; set; }
    }
}
