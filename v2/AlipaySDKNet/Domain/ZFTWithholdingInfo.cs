using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZFTWithholdingInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZFTWithholdingInfo : AopObject
    {
        /// <summary>
        /// 代扣签约场景码
        /// </summary>
        [XmlElement("sign_scene")]
        public string SignScene { get; set; }

        /// <summary>
        /// 代扣产品业务模式；
        /// </summary>
        [XmlElement("withholding_service_feature_name")]
        public string WithholdingServiceFeatureName { get; set; }
    }
}
