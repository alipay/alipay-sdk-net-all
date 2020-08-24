using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceMylogisticfinsandboxMessagePublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceMylogisticfinsandboxMessagePublishModel : AopObject
    {
        /// <summary>
        /// 路由方法的参数
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 方法路由
        /// </summary>
        [XmlElement("method_name")]
        public string MethodName { get; set; }
    }
}
