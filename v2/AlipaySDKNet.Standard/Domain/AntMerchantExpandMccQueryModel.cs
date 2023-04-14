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
        /// 传入需要查询的code列表，以分号分隔；注：如果需要查询完整类目树，可以传入ROOT
        /// </summary>
        [XmlElement("mcc_code_list")]
        public string MccCodeList { get; set; }
    }
}
