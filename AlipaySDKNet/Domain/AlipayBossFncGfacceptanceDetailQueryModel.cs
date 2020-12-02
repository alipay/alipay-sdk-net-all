using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfacceptanceDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfacceptanceDetailQueryModel : AopObject
    {
        /// <summary>
        /// 16位。支付宝UID或者2088000000000XX0，倒数2、3位数字用来决策LDC ZoneUid和分库位
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 业财受理查询请求体
        /// </summary>
        [XmlElement("query")]
        public GFAOpenAPIQueryRequest Query { get; set; }
    }
}
