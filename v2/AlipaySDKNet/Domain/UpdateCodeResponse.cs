using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UpdateCodeResponse Data Structure.
    /// </summary>
    [Serializable]
    public class UpdateCodeResponse : AopObject
    {
        /// <summary>
        /// 批量更新码值返回结果列表
        /// </summary>
        [XmlArray("update_code_result")]
        [XmlArrayItem("update_code_result")]
        public List<UpdateCodeResult> UpdateCodeResult { get; set; }
    }
}
