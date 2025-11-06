using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockSecuUserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockSecuUserQueryModel : AopObject
    {
        /// <summary>
        /// 当前访问用户的协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 要查询用户的协议号列表
        /// </summary>
        [XmlArray("agreement_no_list")]
        [XmlArrayItem("string")]
        public List<string> AgreementNoList { get; set; }
    }
}
