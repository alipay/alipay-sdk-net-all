using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EmployeeCardWalletInfoResDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EmployeeCardWalletInfoResDTO : AopObject
    {
        /// <summary>
        /// 资产类型名称
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
