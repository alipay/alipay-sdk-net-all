using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetPointVoucherprodBenefittemplateCreateResponse.
    /// </summary>
    public class AlipayAssetPointVoucherprodBenefittemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 资产id，即创建的权益模板的id
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 权益结算平台的流水号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }
    }
}
