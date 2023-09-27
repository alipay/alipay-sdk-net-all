using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EmployeeCardWalletInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EmployeeCardWalletInfo : AopObject
    {
        /// <summary>
        /// 零工钱包资产类别名称
        /// </summary>
        [XmlElement("asset_type_name")]
        public string AssetTypeName { get; set; }

        /// <summary>
        /// 脱敏资产编码
        /// </summary>
        [XmlElement("desensitize_card_no")]
        public string DesensitizeCardNo { get; set; }
    }
}
