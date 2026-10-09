using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdSpecialAssetListRes Data Structure.
    /// </summary>
    [Serializable]
    public class AdSpecialAssetListRes : AopObject
    {
        /// <summary>
        /// 冻结单余额
        /// </summary>
        [XmlElement("available_unfreeze_amount")]
        public string AvailableUnfreezeAmount { get; set; }

        /// <summary>
        /// 冻结单id
        /// </summary>
        [XmlElement("rtb_freeze_order_id")]
        public string RtbFreezeOrderId { get; set; }

        /// <summary>
        /// 冻结单名称
        /// </summary>
        [XmlElement("special_name")]
        public string SpecialName { get; set; }

        /// <summary>
        /// 冻结单的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
