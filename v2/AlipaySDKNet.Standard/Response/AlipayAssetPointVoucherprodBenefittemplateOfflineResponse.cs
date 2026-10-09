using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetPointVoucherprodBenefittemplateOfflineResponse.
    /// </summary>
    public class AlipayAssetPointVoucherprodBenefittemplateOfflineResponse : AopResponse
    {
        /// <summary>
        /// 快速下线，true表示模版已过期并且已经退回资金，false表示模版已过期，但是尚未退回资金
        /// </summary>
        [XmlElement("quick_recycle")]
        public bool QuickRecycle { get; set; }
    }
}
