using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardExtendParamsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CardExtendParamsDTO : AopObject
    {
        /// <summary>
        /// 银行机构id
        /// </summary>
        [XmlArray("inst_id")]
        [XmlArrayItem("string")]
        public List<string> InstId { get; set; }

        /// <summary>
        /// 银行机构名称
        /// </summary>
        [XmlArray("inst_name")]
        [XmlArrayItem("string")]
        public List<string> InstName { get; set; }

        /// <summary>
        /// 是否需要开通钱包
        /// </summary>
        [XmlElement("open_wallet")]
        public string OpenWallet { get; set; }
    }
}
