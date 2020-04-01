using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditamountQueryprocessorQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiPcreditamountQueryprocessorQueryModel : AopObject
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [XmlElement("params")]
        public TbapiQueryAmountBizContent Params { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
