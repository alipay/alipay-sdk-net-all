using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetPointVoucherprodBenefittemplateAddResponse.
    /// </summary>
    public class AlipayAssetPointVoucherprodBenefittemplateAddResponse : AopResponse
    {
        /// <summary>
        /// 实际追加金额，单元元
        /// </summary>
        [XmlElement("append_amount")]
        public string AppendAmount { get; set; }

        /// <summary>
        /// 结算平台的流水号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }
    }
}
