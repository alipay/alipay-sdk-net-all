using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EmployeeCardInfoResDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EmployeeCardInfoResDTO : AopObject
    {
        /// <summary>
        /// 零工卡号
        /// </summary>
        [XmlElement("employee_card_no")]
        public string EmployeeCardNo { get; set; }

        /// <summary>
        /// 零工钱包信息
        /// </summary>
        [XmlElement("employee_card_wallet_info")]
        public EmployeeCardWalletInfoResDTO EmployeeCardWalletInfo { get; set; }
    }
}
