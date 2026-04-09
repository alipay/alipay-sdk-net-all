using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipaloverviewQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdPrincipaloverviewQueryModel : AopObject
    {
        /// <summary>
        /// 钱包类型： 通用钱包-INTELLIGENT 外投钱包-XAB_BP
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 资金模式： 共享模式-USER 专享模式-PRINCIPAL
        /// </summary>
        [XmlElement("charge_mode")]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 商家标志。
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }
    }
}
