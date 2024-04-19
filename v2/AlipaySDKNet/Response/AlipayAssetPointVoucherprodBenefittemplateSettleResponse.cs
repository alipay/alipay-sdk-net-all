using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetPointVoucherprodBenefittemplateSettleResponse.
    /// </summary>
    public class AlipayAssetPointVoucherprodBenefittemplateSettleResponse : AopResponse
    {
        /// <summary>
        /// 资产id，即结算的权益模板的id
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资金单据流水id，权益结算平台的结算流水号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 实际结算的金额
        /// </summary>
        [XmlElement("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 当前结算状态，I：结算已受理，尚未划拨资金；S：划拨资金完成；C： 划拨资金失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
