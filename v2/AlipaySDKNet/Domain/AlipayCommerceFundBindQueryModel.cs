using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceFundBindQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceFundBindQueryModel : AopObject
    {
        /// <summary>
        /// 绑卡流水号，此处需要绑卡接口指定的out_bind_no
        /// </summary>
        [XmlElement("out_bind_no")]
        public string OutBindNo { get; set; }
    }
}
