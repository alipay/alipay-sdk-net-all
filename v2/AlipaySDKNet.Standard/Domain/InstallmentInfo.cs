using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstallmentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InstallmentInfo : AopObject
    {
        /// <summary>
        /// 分期数
        /// </summary>
        [XmlElement("install_count")]
        public string InstallCount { get; set; }

        /// <summary>
        /// 子期数对应的营销模型
        /// </summary>
        [XmlElement("operation_list")]
        public PrePayOperationInfo OperationList { get; set; }
    }
}
