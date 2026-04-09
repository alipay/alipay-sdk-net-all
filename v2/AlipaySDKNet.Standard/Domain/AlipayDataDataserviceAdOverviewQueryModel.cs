using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdOverviewQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdOverviewQueryModel : AopObject
    {
        /// <summary>
        /// 钱包类型： 通用钱包-INTELLIGENT 外投钱包-XAB_BP
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }
    }
}
