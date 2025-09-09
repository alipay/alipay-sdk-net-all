using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceConsultFactor Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceConsultFactor : AopObject
    {
        /// <summary>
        /// 咨询因子key，作为入参，用来查询机构。
        /// </summary>
        [XmlElement("factor_key")]
        public string FactorKey { get; set; }

        /// <summary>
        /// 咨询因子的值，此值提供给机构获取服务履约的可选信息，不会涉及用户信息。
        /// </summary>
        [XmlElement("factor_value")]
        public string FactorValue { get; set; }
    }
}
