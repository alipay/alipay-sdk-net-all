using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelBenefitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelBenefitQueryModel : AopObject
    {
        /// <summary>
        /// 权益同步时传递的业务幂等号
        /// </summary>
        [XmlElement("sync_out_biz_no")]
        public string SyncOutBizNo { get; set; }
    }
}
