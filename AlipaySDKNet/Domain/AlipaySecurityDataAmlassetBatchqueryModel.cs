using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataAmlassetBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataAmlassetBatchqueryModel : AopObject
    {
        /// <summary>
        /// 资产的类型，包括LABEL、AML_LIST等
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 合作客户
        /// </summary>
        [XmlElement("client")]
        public string Client { get; set; }

        /// <summary>
        /// 名单or资产标签ID
        /// </summary>
        [XmlElement("lid")]
        public string Lid { get; set; }

        /// <summary>
        /// 客户ID列表
        /// </summary>
        [XmlArray("uids")]
        [XmlArrayItem("string")]
        public List<string> Uids { get; set; }
    }
}
