using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodPrepaymentCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodPrepaymentCancelModel : AopObject
    {
        /// <summary>
        /// 预付逆向入参
        /// </summary>
        [XmlElement("prepay_apply_cancel_order")]
        public PrePayApplyCancelOrder PrepayApplyCancelOrder { get; set; }
    }
}
