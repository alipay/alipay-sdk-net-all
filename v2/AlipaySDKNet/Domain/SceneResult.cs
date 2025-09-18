using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneResult Data Structure.
    /// </summary>
    [Serializable]
    public class SceneResult : AopObject
    {
        /// <summary>
        /// 闪购发奖结果，其中price为其中子字段，代表发奖金额，单位为：分
        /// </summary>
        [XmlElement("aac_prospect_flash_sale")]
        public AACProspectFlashSaleResult AacProspectFlashSale { get; set; }
    }
}
