using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMembergradeQueryResponse.
    /// </summary>
    public class AlipayUserMembergradeQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝用户的蚂蚁会员等级
        /// </summary>
        [XmlElement("grade")]
        public string Grade { get; set; }
    }
}
