using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubAccountInfoQueryOrder Data Structure.
    /// </summary>
    [Serializable]
    public class SubAccountInfoQueryOrder : AopObject
    {
        /// <summary>
        /// 开户申请时获取到的受理单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }
    }
}
