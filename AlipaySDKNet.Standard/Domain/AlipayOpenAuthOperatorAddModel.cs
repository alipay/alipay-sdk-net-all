using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAuthOperatorAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthOperatorAddModel : AopObject
    {
        /// <summary>
        /// 添加蚂蚁操作员参数
        /// </summary>
        [XmlElement("operator_add_vo")]
        public OperatorAddVO OperatorAddVo { get; set; }
    }
}
