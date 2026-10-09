using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockQualifiedInvestorApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockQualifiedInvestorApplyModel : AopObject
    {
        /// <summary>
        /// 身份证号的md5值 32位 大写
        /// </summary>
        [XmlElement("id_number_encrypt")]
        public string IdNumberEncrypt { get; set; }
    }
}
