using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberCardOperator Data Structure.
    /// </summary>
    [Serializable]
    public class MemberCardOperator : AopObject
    {
        /// <summary>
        /// self: 商家的账号id spcenter_isv: 服务商平台isv账号 custom: 服务商自有账号体系的账号
        /// </summary>
        [XmlElement("op_id")]
        public string OpId { get; set; }

        /// <summary>
        /// self：商家 spcenter_isv：服务商平台isv账号 custom：自主对接
        /// </summary>
        [XmlElement("op_type")]
        public string OpType { get; set; }
    }
}
