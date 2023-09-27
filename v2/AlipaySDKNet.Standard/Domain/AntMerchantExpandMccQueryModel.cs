using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandMccQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandMccQueryModel : AopObject
    {
        /// <summary>
        /// 传入需要查询的code列表，以英文逗号分隔
        /// </summary>
        [XmlElement("mcc_code_list")]
        public string MccCodeList { get; set; }
    }
}
