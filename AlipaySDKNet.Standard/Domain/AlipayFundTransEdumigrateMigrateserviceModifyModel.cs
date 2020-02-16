using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTransEdumigrateMigrateserviceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransEdumigrateMigrateserviceModifyModel : AopObject
    {
        /// <summary>
        /// 调用的服务名称 操作类型 + 具体服务名称
        /// </summary>
        [XmlElement("handler")]
        public string Handler { get; set; }

        /// <summary>
        /// 迁移服务的具体参数 JSON结构
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }
    }
}
