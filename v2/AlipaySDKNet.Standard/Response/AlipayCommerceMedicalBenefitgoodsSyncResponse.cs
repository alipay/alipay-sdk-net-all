using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalBenefitgoodsSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalBenefitgoodsSyncResponse : AopResponse
    {
        /// <summary>
        /// 数据是否同步后台
        /// </summary>
        [XmlElement("sync_result")]
        public bool SyncResult { get; set; }
    }
}
