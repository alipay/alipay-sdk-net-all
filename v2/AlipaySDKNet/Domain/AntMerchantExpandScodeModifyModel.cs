using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandScodeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandScodeModifyModel : AopObject
    {
        /// <summary>
        /// 批量申请修改吗接口
        /// </summary>
        [XmlArray("update_code_request")]
        [XmlArrayItem("update_code_request")]
        public List<UpdateCodeRequest> UpdateCodeRequest { get; set; }
    }
}
